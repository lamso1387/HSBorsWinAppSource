using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HBorsWinApp
{
    public partial class FormLoader<T> : CustomForm where T : ListSearchEntity
    {

        private CustomUserControl<T> child_uc;
        public T EntityObject { get; set; }
        public FormLoader(CustomUserControl<T> uc)
        {
            child_uc = uc as CustomUserControl<T>;
            InitializeComponent();
            UpdateSize();

            pnlMain.LoadUC(child_uc);

            StartPosition = FormStartPosition.CenterScreen;


        }

        private void FormLoader_Activated(object sender, EventArgs e)
        {

        }

        private void FormLoader_Deactivate(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseLoader(DialogResult.Cancel);
        }

        private void CloseLoader(DialogResult result)
        {
            DialogResult = result;
            this.Close();

        }
        protected override void OnClosed(EventArgs e)
        {
            Constants.form_loader_loading = null;
            base.OnClosed(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                SaveAction();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAction();

        }

        private void SaveAction()
        { 
            bool is_valid = child_uc.CheckFormValidation();
            if (!is_valid)
            {
                Constants.form_loader_loading.Warn(child_uc.FirstValidationError);
                return;
            }

            EntityObject = child_uc.EntityObject;
            if (child_uc.view_mode == System.Web.UI.WebControls.FormViewMode.Insert)
            {

                AsynchAction asynk = new AsynchAction(Constants.MessageText.DefaultAdding, true, Constants.form_loader_loading);
                asynk.CallAwaitable(() => child_uc.AddAction(), () =>
                  CloseLoader(DialogResult.OK));

            }
            else if (child_uc.view_mode == System.Web.UI.WebControls.FormViewMode.Edit)
            {
                var data_edited = !SRL.ClassManagement.CheckClassObjectEqual<EditableAttribute, T>(EntityObject, child_uc.EntityToEditObject);
                var form_edited = child_uc.CheckFormEdited();
                var edited = data_edited || form_edited;
                if (edited)
                {
                    AsynchAction asynk = new AsynchAction(Constants.MessageText.DefaultEditing, true, Constants.form_loader_loading);
                    asynk.CallAwaitable(() => child_uc.EditAction(), () =>
                      CloseLoader(DialogResult.OK));
                }
                else
                {
                    CloseLoader(DialogResult.Abort);
                }

            }
        }

        private void FormLoader_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        private void LoadPage()
        {

            pnlDrag.MouseDown += PnlDrag_MouseDown;

            Constants.form_loader_loading = loader_loading;

            LoadAsync();
        }
        private void LoadAsync()
        {
            AsynchAction asynk = new AsynchAction(Constants.MessageText.LoadFormEditData, true, Constants.form_loader_loading);
            asynk.CallAwaitable(() => child_uc.LoadDataToEdit(() => child_uc.LoadAfterAsyncEditData(null)));

        }

        private void PnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void UpdateSize()
        {
            int extra_height = child_uc.Height - pnlMain.Height;
            int extra_width = child_uc.Width - pnlMain.Width;
            this.Height += extra_height;
            this.Width += extra_width;
        }
    }
}
