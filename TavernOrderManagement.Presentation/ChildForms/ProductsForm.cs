namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using DataAccessLayer.Services.ModelServices;
    using DataAccessLayer.Models.Dtos;
    using System.Collections.Generic;
    using DataAccessLayer.Models;
    using System.Windows.Forms;
    using System.Globalization;
    using System.Linq;
    using Utilities;
    using System;
    #endregion

    public partial class ProductsForm : Form
    {
        #region Properties
        private static ProductCriteriaDto _filterCriteria;
        private CultureInfo _customCulture;
        #endregion

        #region Constructor
        public ProductsForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;

            _filterCriteria = new ProductCriteriaDto();
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            SetApplicationCulture();
            InitializeProductsOperation();
            InitializeCategoriesOperation();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            switch (btnSender.Name)
            {
                case @"newItemBtn":
                    NewItemOperation();
                    break;
                case @"clearFiltersBtn":
                    ClearFiltersOperation();
                    break;
            }
        }

        protected void UpdateButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            if (!btnSender.Name.Contains(@"updprod"))
                return;

            var pId = btnSender.Name.Replace(@"updprod", string.Empty).ToInt();
            EditItemOperation(pId);
        }

        protected void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            if (!btnSender.Name.Contains(@"updprod"))
                return;

            var pId = btnSender.Name.Replace(@"delprod", string.Empty).ToInt();
            DeleteItemOperation(pId);
        }

        protected void CellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView grdSender))
                return;

            var columnClicked = grdSender.Columns[e.ColumnIndex];

            if (!(columnClicked is DataGridViewButtonColumn))
                return;

            var rowClicked = grdSender.Rows[e.RowIndex];
            var pId = rowClicked.Cells[1].Value.ToInt();
            switch (columnClicked.Name)
            {
                case @"editProd":
                    EditItemOperation(pId);
                    break;
                case @"deleteProd":
                    DeleteItemOperation(pId);
                    break;
            }
        }

        protected void SearchBoxTextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox txtSender))
                return;

            if (!txtSender.Name.Contains(@"searchBox"))
                return;

            var searchTerm = txtSender.Text;
            _filterCriteria.NameContains = searchTerm;

            SearchWithCriteria();
        }

        protected void CategoryBoxIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBox cbSender))
                return;

            if (!cbSender.Name.Contains(@"categoryBox"))
                return;

            _filterCriteria.Category = cbSender.SelectedIndex != 0 ? cbSender.Text : string.Empty;
            SearchWithCriteria();
        }

        protected void CustomQuantityCheckChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox chSender))
                return;

            if (!chSender.Name.Equals(@"customQuantity"))
                return;

            if (chSender.Checked)
                _filterCriteria.FixedQuantity = true;
            else _filterCriteria.FixedQuantity = null;

            SearchWithCriteria();
        }

        protected void DatesCheckChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox chSender))
                return;

            switch (chSender.Name)
            {
                case @"dateFromEnabled":
                    dateFrom.Enabled = chSender.Checked;
                    break;
                case @"dateToEnabled":
                    dateTo.Enabled = chSender.Checked;
                    break;
            }

            if (dateFromEnabled.Checked) _filterCriteria.DateFrom = dateFrom.Value.Date;
            else _filterCriteria.DateFrom = null;
            if (dateToEnabled.Checked) _filterCriteria.DateTo = dateTo.Value.Date;
            else _filterCriteria.DateTo = null;

            SearchWithCriteria();
        }

        protected void DatesChanged(object sender, EventArgs e)
        {
            if (!(sender is DateTimePicker))
                return;

            if (dateFrom.Enabled) _filterCriteria.DateFrom = dateFrom.Value.Date;
            if (dateTo.Enabled) _filterCriteria.DateTo = dateTo.Value.Date;

            SearchWithCriteria();
        }
        #endregion

        #region Operation Methods
        private void InitializeProductsOperation(List<ProductDto> productLst = null)
        {
            try
            {
                var productsList = productLst ?? S.ProductService.ListByCriteria(new ProductCriteriaDto());

                var itemIndex = 1;
                foreach (var product in productsList)
                {
                    itemDataGrid.Rows.Add(
                        itemIndex.ToString(),
                        product.Id,
                        product.DateCreated?.ToString("dd/MM/yyyy"),
                        product.DateCreated?.ToString("HH:mm:ss"),
                        product.Category,
                        product.Name,
                        product.Price,
                        product.FixedQuantity);
                    itemIndex++;
                }
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void InitializeCategoriesOperation()
        {
            try
            {
                var categoriesDs = new List<ComboBoxViewItem> { new ComboBoxViewItem { Text = @"- Κενό -", Value = 0 } };
                var categoriesList = S.CategoryService.ListByCriteria(new CategoryCriteriaDto())
                    .Select(x => new ComboBoxViewItem()
                    {
                        Text = x.Name,
                        Value = x.Id
                    }).ToList();

                categoriesDs.AddRange(categoriesList);
                categoryBox.DataSource = categoriesDs;
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void NewItemOperation()
        {
            try
            {
                using (var prodViewFrm = new ProductViewForm(Enums.Crud.Create))
                    prodViewFrm.ShowDialog();

                itemDataGrid.Rows.Clear();
                InitializeProductsOperation();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void EditItemOperation(int pId)
        {
            try
            {
                var product = S.ProductService
                    .ListByCriteria(new ProductCriteriaDto { Id = pId })
                    .FirstOrDefault();

                if (product == null)
                    return;

                using (var prodViewFrm = new ProductViewForm(Enums.Crud.Update, product))
                    prodViewFrm.ShowDialog();

                if (FiltersOn())
                    return;

                itemDataGrid.Rows.Clear();
                InitializeProductsOperation();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void DeleteItemOperation(int pId)
        {
            try
            {
                var productSelected = S.ProductService
                    .ListByCriteria(new ProductCriteriaDto { Id = pId })
                    .FirstOrDefault();

                if (productSelected != null)
                    S.ProductService.Delete(productSelected);

                if (FiltersOn())
                    return;

                itemDataGrid.Rows.Clear();
                InitializeProductsOperation();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void ClearFiltersOperation()
        {
            try
            {
                searchBox.Clear();
                InitializeCategoriesOperation();
                dateFromEnabled.Checked = false;
                dateToEnabled.Checked = false;
                customQuantity.Checked = false;

                InitializeProductsOperation();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion

        #region Custom Methods
        private void SetApplicationCulture()
        {
            try
            {
                _customCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Clone() as CultureInfo;

                if (_customCulture == null)
                    throw new Exception(@"Issue with Thread CurrentCulture");

                _customCulture.NumberFormat.NumberDecimalSeparator = @".";
                System.Threading.Thread.CurrentThread.CurrentCulture = _customCulture;
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private bool FiltersOn()
        {
            var hasSearchTerm = !searchBox.Text.IsEmpty();
            var hasCategory = !categoryBox.Text.Equals(@"- Κενό -");
            var hasDateFrom = dateFromEnabled.Checked;
            var hasDateTo = dateToEnabled.Checked;
            var hasCustomQ = customQuantity.Checked;

            return hasSearchTerm || hasCategory || hasDateFrom || hasDateTo || hasCustomQ;
        }

        private void SearchWithCriteria()
        {
            try
            {
                var productsMatched = S.ProductService.ListByCriteria(_filterCriteria);

                itemDataGrid.Rows.Clear();
                InitializeProductsOperation(productsMatched.ToList());
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion
    }
}
