using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;
using System.Globalization;

namespace HBorsWinApp
{
#if DEBUG
    public partial class ListSearchUC<TEntity, TEntityForm, TEntitySearch> : NonGenericListSearchUC where TEntity : ListSearchEntity where TEntityForm : CustomUserControl<TEntity> where TEntitySearch : PagedRequest
#else
     public partial class ListSearchUC<TEntity,TEntityForm, TEntitySearch> : CustomUserControl<ListSearchEntity> where TEntity : ListSearchEntity where TEntityForm:CustomUserControl<TEntity> where TEntitySearch: PagedRequest
#endif

    {
        ListSearchEntity entity_object;
        FilterUserControl filter_control;
        int default_page_size;
        SRL.WinTools.DataGridViewTool.DgvPaging dgv_paging;
        public ListSearchUC(ListSearchEntity entity_object_, FilterUserControl filter_)
        {
            entity_object = entity_object_;
            filter_control = filter_;
            InitializeComponent();
            default_page_size = 10;
        }

        private void ProductsUC_Load(object sender, EventArgs e)
        {
            LoadPage();

        }
        protected override void LoadPage()
        {
            dgv.SelectionChanged += Dgv_SelectionChanged;
            dgv.SizeChanged += Dgv_SizeChanged;
            LoadAsynch();
        }


        bool dgv_first_size_changed = false;
        private void Dgv_SizeChanged(object sender, EventArgs e)
        {
            if (!dgv_first_size_changed)
            {
                dgv_first_size_changed = true;
                default_page_size = ((dgv.Height - 28) / dgv.RowTemplate.Height) - 1;//28 is dgv.ColumnHeadersHeight after load

                dgv_paging = new SRL.WinTools.DataGridViewTool.DgvPaging(tbPageNo, lblRecordOfAll, lblTotalPage, llNext, llLastPage, llFirstPage, llPrevious,llGoTo, default_page_size, SearchList);
                SearchList();
            }
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Visible = btnEdit.Visible = dgv.SelectedRows.Count == 1;

        }

        protected override void LoadAsynch()
        {
            if (filter_control != null) pnlFilter.LoadUC(filter_control);

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearchList();
        }

        private void SearchList(int page_start = 1, int? page_size = null)
        {
            if (page_size == null) page_size = default_page_size;

            List<Control> filter_controls = filter_control.GetChildInputControls();

            Dictionary<string, object> filter_input = filter_controls.ConvertValuesToJson();
            dgv.page_start = page_start;
            dgv.page_size = (int)page_size;

            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderGettingData,true,null);
            asynch.CallAwaitable(() => entity_object.LoadToDgv<TEntity, TEntitySearch>(dgv, filter_input), () =>
            {  
                dgv_paging.DgvPagingSearchCallback(page_start,dgv.Rows.Count,dgv.entity_count_all,dgv.entity_page_count);
            });
            dgv_paging.DgvPagingSearchAction(page_start);
        }
       
        private void DgvPagingSearchCallback2(DataGridList dgv, int page_start)
        {
            tbPageNo.Text = page_start.ToString();
            lblRecordOfAll.Text = $"نمایش {dgv.Rows.Count} از {dgv.entity_count_all}";
            lblTotalPage.Text = $"از {dgv.entity_page_count}";
            if (dgv.entity_page_count == page_start)
            {
                llNext.Enabled = llLastPage.Enabled = false;
            }
            else
            {
                llNext.Enabled = llLastPage.Enabled = true;
            }
        }

        private void DgvPagingSearchAction2(int page_start)
        {

            if (page_start == 1)
            {
                llFirstPage.Enabled = llPrevious.Enabled = false;
            }
            else
            {
                llFirstPage.Enabled = llPrevious.Enabled = true;
            }
        }


        private void llFirstPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SearchList(1, default_page_size);
        }

        private void llPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SearchList(dgv.page_start - 1, default_page_size);
        }

        private void llNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SearchList(dgv.page_start + 1, default_page_size);
        }

        private void llLastPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SearchList(dgv.entity_page_count, default_page_size);
        }

        private void llGoTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //int to_page = int.Parse(tbPageNo.Text);

            //if (to_page > dgv.entity_page_count)
            //{
            //    tbPageNo.Text = dgv.entity_page_count.ToString();
            //    llGoTo_LinkClicked(tbPageNo, e);
            //}
            //else SearchList(to_page, default_page_size);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FormLoader<TEntity>(SRL.ClassManagement.CreateInstance<TEntityForm>(System.Web.UI.WebControls.FormViewMode.Insert, null)).ShowDialog();
            if (form == DialogResult.OK)
            {
                Constants.main_loader.Warn(Constants.MessageText.DefaultAddOk, null, 5000);
                SearchList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                if (DeletionConfirm() == DialogResult.Yes)
                {
                    long id = long.Parse(dgv.SelectedRows[0].Cells["id"].Value.ToString());
                    AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultDeleting);
                    asynch.CallAwaitable(() => entity_object.Delete(id),
                        () =>
                        {
                            Constants.main_loader.Warn(Constants.MessageText.DefaultDeleteOk, null, 5000);
                            SearchList();
                        });

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                long id = long.Parse(dgv.SelectedRows[0].Cells["id"].Value.ToString());
                var entity_form = SRL.ClassManagement.CreateInstance<TEntityForm>(System.Web.UI.WebControls.FormViewMode.Edit, id);
                var form_loader = new FormLoader<TEntity>(entity_form).ShowDialog();

                if (form_loader == DialogResult.OK)
                {
                    Constants.main_loader.Warn(Constants.MessageText.DefaultAddOk, null, 5000);
                    SearchList();
                }
                else if (form_loader == DialogResult.Abort)
                {
                    Constants.main_loader.Warn(Constants.MessageText.UpdateCancel, null, 4000);
                }
            }
        }
    }

    public class NonGenericListSearchUC : CustomUserControl<ListSearchEntity> { }
}
