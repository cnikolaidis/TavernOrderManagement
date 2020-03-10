namespace TavernOrderManagement.Presentation
{
    #region Usings
    using DataAccessLayer.Services.ModelServices;
    using DataAccessLayer.Models.Dtos;
    using System.Collections.Generic;
    using DataAccessLayer.Services;
    using System.Windows.Forms;
    using System.Globalization;
    using System.Drawing;
    using System.Linq;
    using ChildForms;
    using System.IO;
    using Utilities;
    using System;
    #endregion

    public partial class MainForm : Form
    {
        #region Properties
        private CultureInfo _customCulture;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            SetApplicationCulture();
            InitializeProducts();
            InitializeOrderState();
        }

        protected void MenuItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem currentSender = (sender as ToolStripMenuItem);

            if (currentSender != null)
            {
                switch (currentSender.Name)
                {
                    case @"editItemsMenuItem":
                        EditItemsMenuItemOperation();
                        break;
                    case @"ordersMenuItem":
                        EditOrdersOperation();
                        break;
                    case @"daySumMenuItem":
                        DaySumMenuItemOperation();
                        break;
                    case @"printReportMenuItem":
                        PrintReportMenuItemOperation();
                        break;
                    case @"aboutMenuItem":
                        AboutMenuItemOperation();
                        break;
                    case @"exitMenuItem":
                        ExitMenuItemOperation();
                        break;
                    default:
                        $"Invalid Event Handle {currentSender.Name}".ErrMsg();
                        break;
                }
            }
        }

        protected void TablesButtonClicked(object sender, EventArgs e)
        {
            Button btnSender = sender as Button;

            if (btnSender != null && btnSender.Name.Contains(@"table"))
            {
                var tblState = btnSender.BackColor == Color.SpringGreen ? @"Reserved" : @"Free";
                var tblId = btnSender.Name.Replace(@"table", string.Empty).ToInt();

                if (tblState.Equals(@"Reserved"))
                    ReservedTableOperation(tblId);
                else FreeTableOperation(tblId);
            }
        }

        protected void ProductButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            if (!btnSender.Name.Contains(@"product"))
                return;

            if (showTableLbl.Text.IsEmpty())
                @"Επιλέξτε τραπέζι πρώτα".WarnMsg(@"Άδειο πεδίο");
            else
            {
                var productId = btnSender.Name.Replace(@"product", string.Empty).ToInt();
                ProductSelectedOperation(productId);
            }
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            switch (btnSender.Name)
            {
                case @"refreshItemListBtn":
                    RefreshItemOperation();
                    break;
                case @"cancelOrderBtn":
                    CancelOrderOperation();
                    break;
                case @"finishOrderBtn":
                    FinishOrderOperation();
                    break;
                case @"printOrderBtn":
                    PrintOrderOperation();
                    break;
                case @"moveOrderBtn":
                    MoveOrderOperation();
                    break;
                case @"deleteOrderItemBtn":
                    DeleteOrderItemOperation();
                    break;
                default:
                    $"Invalid Event Handle {btnSender.Name}".ErrMsg();
                    break;
            }
        }
        #endregion

        #region Operation Methods

        #region Menu Item Operations
        private void EditItemsMenuItemOperation()
        {
            try
            {
                using (var prodsForm = new ProductsForm())
                    prodsForm.ShowDialog();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void EditOrdersOperation()
        {
            try
            {
                using (var ordersFrm = new OrdersForm())
                    ordersFrm.ShowDialog();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void DaySumMenuItemOperation()
        {
            try
            {
                if (!$"Εκτύπωση συνόλου για ημέρα {DateTime.Now.ToString("dd/MM/yyyy")}. Συνέχεια?".SimpleQMsg())
                    return;

                var todayAmount = OrderingService.GetTodaysSum();
                PrintingService.DaySummary(todayAmount);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void PrintReportMenuItemOperation()
        {
            try
            {
                using (var reportsFrm = new ReportsForm())
                    reportsFrm.ShowDialog();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void AboutMenuItemOperation()
        {
            try
            {
                using (var aboutFrm = new AboutForm())
                    aboutFrm.ShowDialog();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void ExitMenuItemOperation()
        {
            try
            {
                Dispose();
                Close();
                Application.Exit();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion

        private void RefreshItemOperation()
        {
            try
            {
                if (!"Είστε σίγουροι ότι θέλετε να ανανεώσετε τα είδη ?\n[Η ΔΙΑΔΙΚΑΣΙΑ ΘΑ ΚΡΑΤΗΣΕΙ ΚΑΠΟΙΑ ΔΕΥΤΕΡΟΛΕΠΤΑ]".SimpleQMsg(@"Ακύρωση Ανανέωσης"))
                    return;

                itemListTLP.Controls.Clear();
                InitializeProducts();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void CancelOrderOperation()
        {
            try
            {
                var tblId = showTableLbl.Text.ToInt();
                if (!$"Θέλετε να ακυρώσετε την παραγγελία στο τραπέζι {tblId}".SimpleQMsg(@"Ακύρωση παραγγελίας"))
                    return;

                OrderingService.RemoveOrder(tblId);
                RefreshOrderControls(OrderingService.PendingOrders);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void FinishOrderOperation()
        {
            try
            {
                if (!@"Η παραγγελία θα κλείσει. Συνέχεια?".SimpleQMsg(@"Προσοχή"))
                    return;

                var tblId = showTableLbl.Text.ToInt();
                var tableOrder = OrderingService.GetTableOrder(tblId);
                if (tableOrder == null)
                    return;

                OrderingService.FinalizeOrder(tblId);
                RefreshOrderControls(OrderingService.PendingOrders);
                ToggleOrderEditButtons(false);

                @"Το τραπέζι έκλεισε".InfoMsg(@"Επιτυχία παραγγελίας");
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void PrintOrderOperation()
        {
            try
            {
                if (!@"Η παραγγελία θα εκτυπωθεί. Συνέχεια?".SimpleQMsg(@"Προσοχή"))
                    return;

                var tblId = showTableLbl.Text.ToInt();
                var tableOrder = OrderingService.GetTableOrder(tblId);
                if (tableOrder != null)
                    PrintingService.ReceiptForOrder(tableOrder);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void MoveOrderOperation()
        {
            try
            {
                var tblId = showTableLbl.Text.ToInt();
                var toTable = 0;

                using (var form = new TableNumsForm(tblId))
                {
                    form.ShowDialog();
                    if (form.Action == Enums.UserAction.Submitted)
                        toTable = form.ToTable;
                }

                OrderingService.MoveOrder(tblId, toTable);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void DeleteOrderItemOperation()
        {
            try
            {
                var selectedItems = orderList.SelectedItems;
                var totalListItems = orderList.Items;
                var tblId = showTableLbl.Text.ToInt();

                if (selectedItems.Count == 0)
                    @"Δεν έχει επιλεγεί είδος".WarnMsg(@"Αποτυχία");
                else
                {
                    foreach (ListViewItem item in selectedItems)
                    {
                        var itemName = item.SubItems[0].Text;
                        var orderTotalToShow = sumPriceLbl.Text.ToDecimal() - (item.SubItems[1].ToDecimal() * item.SubItems[2].ToDecimal());
                        sumPriceLbl.Text = orderTotalToShow.ToString(_customCulture);
                        orderList.Items.Remove(item);

                        OrderingService.RemoveItemFromOrder(tblId, itemName);
                        ReservedTableOperation(tblId);
                    }
                }

                if (totalListItems.Count != 0)
                    return;

                foreach (var control in tablesTLP.Controls)
                {
                    if (!(control is Button) || !(control as Button).Text.Equals(tblId.ToString()))
                        continue;

                    var tableBtn = control as Button;
                    tableBtn.BackColor = Color.Transparent;
                }
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void FreeTableOperation(int tblId)
        {
            try
            {
                showTableLbl.Text = tblId.ToString();
                orderList.Items.Clear();
                sumPriceLbl.Text = @"00.00";
                ToggleOrderEditButtons(false);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void ReservedTableOperation(int tblId)
        {
            try
            {
                var tableOrder = OrderingService.GetTableOrder(tblId);
                if (tableOrder == null)
                    return;

                orderList.Items.Clear();
                foreach (var oItm in tableOrder.OrderItems)
                {
                    var itemPrice = oItm.Price.ToString(_customCulture);
                    var itemQuantity = oItm.Quantity.ToString(_customCulture);
                    var itemSum = (oItm.Price * oItm.Quantity).ToString(_customCulture);
                    orderList.Items.Add(new ListViewItem(new[] { oItm.Name, itemPrice, itemQuantity, itemSum }));
                }

                var orderSum = tableOrder.TotalAmount;

                sumPriceLbl.Text = orderSum.ToString(@"###.00");
                showTableLbl.Text = tblId.ToString();

                ToggleOrderEditButtons(true);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void ProductSelectedOperation(int pId)
        {
            try
            {
                decimal quantitySelected = 1;
                var quantityAction = Enums.UserAction.Submitted;
                var product = S.ProductService
                    .ListByCriteria(new ProductCriteriaDto { Id = pId })
                    .FirstOrDefault();

                if (product == null)
                    return;

                if (product.FixedQuantity)
                {
                    using (var setQForm = new SetQuantityForm())
                    {
                        setQForm.ShowDialog();
                        if (setQForm.Action == Enums.UserAction.Submitted)
                            quantitySelected = setQForm.QuantitySelected;
                        else quantityAction = Enums.UserAction.Cancelled;
                    }
                }

                if (quantityAction != Enums.UserAction.Submitted)
                    return;

                var tblId = showTableLbl.Text.ToInt();
                var orderItem = new OrderItemDto()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantitySelected
                };

                OrderingService.SetupOrder(tblId, orderItem);
                ReservedTableOperation(tblId);
                RefreshOrderControls(OrderingService.PendingOrders);
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

        private void InitializeProducts()
        {
            try
            {
                itemListTLP.RowCount = 0;
                itemListTLP.RowStyles.Clear();
                itemListTLP.AutoScroll = true;

                var productsList = S.ProductService.ListByCriteria(new ProductCriteriaDto()).ToList();

                var drinksFishProducts = productsList
                    .Where(x => x.Category.Equals(@"Ποτά") || x.Category.Equals(@"Ψάρια"))
                    .Select(x => x)
                    .ToList();
                ConstructColumn(0, itemListTLP, drinksFishProducts);

                var orektikaPastaProducts = productsList
                    .Where(x => x.Category.Equals(@"Ορεκτικά") || x.Category.Equals(@"Παστά"))
                    .Select(x => x)
                    .ToList();
                ConstructColumn(1, itemListTLP, orektikaPastaProducts);

                var ostrakaSaganakiaThalassinaProducts = productsList
                    .Where(x => x.Category.Equals(@"Όστρακα") || x.Category.Equals(@"Σαγανάκια") || x.Category.Equals(@"Θαλασσινά"))
                    .Select(x => x)
                    .ToList();
                ConstructColumn(2, itemListTLP, ostrakaSaganakiaThalassinaProducts);

                var salatesZymarikaMageireftaProducts = productsList
                    .Where(x => x.Category.Equals(@"Σαλάτες") || x.Category.Equals(@"Ζυμαρικά") || x.Category.Equals(@"Μαγειρευτά"))
                    .Select(x => x)
                    .ToList();
                ConstructColumn(3, itemListTLP, salatesZymarikaMageireftaProducts);

                MakeProductButtonsVisible(itemListTLP);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        protected void ConstructColumn(int col, TableLayoutPanel tlp, List<ProductDto> productsList)
        {
            var productCategories = productsList
                .Select(x => x.Category)
                .Distinct()
                .ToList();

            var controlIndex = 0;
            for (var i = 0; i < productCategories.Count; i++)
            {
                var labelFont = new Font(@"Bookman Old Style", 10, FontStyle.Bold);
                var currentCategory = productCategories[i];
                var categoryProducts = productsList
                    .Where(x => x.Category.Equals(currentCategory))
                    .Select(x => x)
                    .OrderBy(x => x.Name)
                    .ToList();

                var categoryLbl = new Label()
                {
                    Dock = DockStyle.Fill,
                    Height = 27,
                    Font = labelFont,
                    Text = currentCategory,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.Fixed3D,
                    BackColor = Color.LightBlue,
                    Visible = false
                };
                tlp.Controls.Add(categoryLbl, col, controlIndex);
                controlIndex++;

                foreach (var eachProduct in categoryProducts)
                {
                    tlp.RowStyles.Add(new RowStyle());

                    var btnFont = new Font(@"Bookman Old Style", 10, FontStyle.Bold);
                    var productBtn = new Button()
                    {
                        Dock = DockStyle.Fill,
                        Height = 27,
                        Font = btnFont,
                        Name = $"product{eachProduct.Id}",
                        Text = eachProduct.Name,
                        Visible = false,
                        FlatStyle = FlatStyle.Flat
                    };
                    productBtn.Click += ProductButtonClicked;
                    productBtn.MouseEnter += delegate
                    {
                        productBtn.ForeColor = Color.Navy;
                        productBtn.BackColor = Color.White;
                    };
                    productBtn.MouseLeave += delegate
                    {
                        productBtn.ForeColor = Color.White;
                        productBtn.BackColor = Color.Navy;
                    };

                    tlp.Controls.Add(productBtn, col, controlIndex);
                    controlIndex++;
                }
            }
        }

        protected void MakeProductButtonsVisible(TableLayoutPanel tlp)
        {
            foreach (var eachCtrl in tlp.Controls)
            {
                if (!(eachCtrl is Button))
                    continue;

                (eachCtrl as Button).BackColor = Color.Navy;
                (eachCtrl as Button).ForeColor = Color.White;
                (eachCtrl as Button).Visible = true;
            }

            foreach (var eachCtrl in tlp.Controls)
                if (eachCtrl is Label)
                    (eachCtrl as Label).Visible = true;
        }

        private void InitializeOrderState()
        {
            try
            {
                if (!File.Exists(@"currentOrders.xml"))
                    return;

                var statedOrders = XmlStateService.GetOrdersState();
                OrderingService.PendingOrders = statedOrders;
                RefreshOrderControls(statedOrders);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        protected void RefreshOrderControls(List<OrderDto> ordersList)
        {
            foreach (var ctrl in tablesTLP.Controls)
            {
                if (!(ctrl is Button) || (ctrl as Button).Name.Equals(@"tablesTitleBtn"))
                    continue;

                var btn = ctrl as Button;
                var tblId = btn.Name.Replace(@"table", string.Empty).ToInt();
                var orderForTbl = ordersList.FirstOrDefault(x => x.Table == tblId);
                btn.BackColor = orderForTbl != null
                    ? Color.SpringGreen
                    : Color.White;
            }

            if (showTableLbl.Text.IsEmpty())
                orderList.Items.Clear();
            else
            {
                var tblId = showTableLbl.Text.ToInt();
                var tableOrder = OrderingService.GetTableOrder(tblId);
                if (tableOrder == null)
                    orderList.Items.Clear();
                else ReservedTableOperation(tblId);
            }
        }

        private void ToggleOrderEditButtons(bool onOff)
        {
            cancelOrderBtn.Enabled = onOff;
            finishOrderBtn.Enabled = onOff;
            printOrderBtn.Enabled = onOff;
            moveOrderBtn.Enabled = onOff;
        }
        #endregion
    }
}
