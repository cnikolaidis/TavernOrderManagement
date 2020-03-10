namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using DataAccessLayer.Services.ModelServices;
    using DataAccessLayer.Models.Dtos;
    using static Utilities.Enums;
    using DataAccessLayer.Models;
    using System.Windows.Forms;
    using System.Globalization;
    using System.Linq;
    using Utilities;
    using System;
    #endregion

    public partial class ProductViewForm : Form
    {
        #region Properties
        private Crud _crudOperation;
        private ProductDto _product;
        private CultureInfo _customCulture;
        #endregion

        #region Constructor
        public ProductViewForm(Crud crudOp, ProductDto product = null)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            SetApplicationCulture();
            InitializeFormOperation(crudOp, product);
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            InitializeCategoriesOperation();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            switch (btnSender.Name)
            {
                case @"saveItemBtn":
                    SaveItemOperation();
                    break;
                case @"clearBtn":
                    ClearOperation();
                    break;
            }
        }
        #endregion

        #region Operation Methods
        private void InitializeFormOperation(Crud crudOp, ProductDto product)
        {
            try
            {
                _crudOperation = crudOp;
                switch (_crudOperation)
                {
                    case Crud.Create:
                        Text = @"Εισαγωγή προϊόντος";
                        break;
                    case Crud.Update:
                        Text = @"Επεξεργασία προϊόντος";
                        _product = product;
                        SetProductFields(_product);
                        break;
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
                var catsListItems = S.CategoryService
                    .ListByCriteria(new CategoryCriteriaDto())
                    .Select(x => new ComboBoxViewItem
                    {
                        Text = x.Name,
                        Value = x.Id
                    }).ToList();

                itemCategoryInput.DataSource = catsListItems;
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void SaveItemOperation()
        {
            try
            {
                switch (_crudOperation)
                {
                    case Crud.Create:
                        CreateProduct();
                        break;
                    case Crud.Update:
                        UpdateProduct();
                        break;
                }

                Dispose();
                Close();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void ClearOperation()
        {
            try
            {
                InitializeCategoriesOperation();
                itemNameInput.Clear();
                itemPriceInput.Clear();
                isKgQuantityCheck.Checked = false;
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion

        #region Custom Methods
        private void SetProductFields(ProductDto product)
        {
            itemNameInput.Text = product.Name;
            itemCategoryInput.Text = product.Category;
            itemPriceInput.Text = product.Price.ToString(_customCulture);
            isKgQuantityCheck.Checked = product.FixedQuantity;
        }

        private void CreateProduct()
        {
            var name = itemNameInput.Text;
            var category = itemCategoryInput.Text;
            var price = itemPriceInput.Text;
            var fixedQuantity = isKgQuantityCheck.Checked;

            if (name.IsEmpty() || price.IsEmpty())
            {
                @"Συμπληρώστε όλα τα πεδία".WarnMsg(@"Κενά πεδία");
                return;
            }

            _product = new ProductDto
            {
                Name = name,
                Price = price.ToDecimal(),
                Category = category,
                FixedQuantity = fixedQuantity,
                DateCreated = DateTime.Now
            };

            var prodCreated = S.ProductService.Create(_product);
            if (prodCreated == 0)
                @"Σφάλμα στην δημιουργία προϊόντος. Ελέγξτε εαν υπάρχει προϊόν με το ίδιο όνομα".WarnMsg(@"Σφάλμα δημιουργίας προϊόντος");
        }

        private void UpdateProduct()
        {
            var name = itemNameInput.Text;
            var category = itemCategoryInput.SelectedText;
            var price = itemPriceInput.Text;
            var fixedQuantity = isKgQuantityCheck.Checked;

            if (name.IsEmpty() || price.IsEmpty())
            {
                @"Συμπληρώστε όλα τα πεδία".WarnMsg(@"Κενά πεδία");
                return;
            }

            _product.Name = name;
            _product.Price = price.ToDecimal();
            _product.Category = category;
            _product.FixedQuantity = fixedQuantity;

            S.ProductService.Update(_product);
        }

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
        #endregion
    }
}
