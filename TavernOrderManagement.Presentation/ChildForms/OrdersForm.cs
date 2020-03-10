namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using System.Windows.Forms.DataVisualization.Charting;
    using DataAccessLayer.Services.ModelServices;
    using DataAccessLayer.Models.Dtos;
    using System.Collections.Generic;
    using DataAccessLayer.Models;
    using Utilities.UtilityForms;
    using System.Globalization;
    using System.Windows.Forms;
    using System.Drawing;
    using System.Linq;
    using Utilities;
    using System;
    #endregion

    public partial class OrdersForm : Form
    {
        #region Properties
        private static ChartArea _chartArea;
        private static Series _series;
        private static OrderCriteriaDto _filterCriteria;
        private CultureInfo _customCulture;
        #endregion

        #region Constructor
        public OrdersForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;

            _filterCriteria = new OrderCriteriaDto();
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            SetApplicationCulture();
            InitializeTablesOperation();
            InitializeOrdersOperation();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            switch (btnSender.Name)
            {
                case @"goFiltersBtn":
                    GoFiltersOperation();
                    break;
            }
        }

        protected void OrdersGridSelectionChanged(object sender, EventArgs e)
        {
            if (!(sender is DataGridView grdSender))
                return;

            if (grdSender.SelectedRows.Count <= 0)
                return;

            var rowClicked = grdSender.SelectedRows[0];
            var selectedOrderId = rowClicked.Cells[1].Value.ToInt();
            var orderItems = S.OrderItemService
                .ListByCriteria(new OrderItemCriteriaDto { OrderId = selectedOrderId })
                .ToList();

            if (!orderItems.Any())
                return;

            var itemIndex = 1;
            orderItemsDataGrid.Rows.Clear();
            foreach (var item in orderItems)
            {
                orderItemsDataGrid.Rows.Add(
                    itemIndex.ToString(),
                    item.Id,
                    item.Name,
                    item.Price,
                    item.Quantity,
                    item.Price * item.Quantity);
                itemIndex++;
            }
        }

        protected void ChartClicked(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            ChartClickedOperation();
        }
        #endregion

        #region Operation Methods
        private void InitializeTablesOperation()
        {
            try
            {
                var categoriesDs = new List<ComboBoxViewItem> { new ComboBoxViewItem { Text = @"- Κενό -", Value = 0 } };
                for (int i = 1; i < 51; i++)
                    categoriesDs.Add(new ComboBoxViewItem { Text = $"{i}", Value = i });

                tableBox.DataSource = categoriesDs;
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void InitializeOrdersOperation(OrderCriteriaDto criterias = null)
        {
            try
            {
                ordersDataGrid.Rows.Clear();
                orderItemsDataGrid.Rows.Clear();

                if (criterias == null)
                {
                    var dateF = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    var dateT = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                    dateFromEnabled.Checked = true;
                    dateFrom.Value = dateF;
                    dateFrom.Enabled = true;
                    dateToEnabled.Checked = true;
                    dateTo.Value = dateT;
                    dateTo.Enabled = true;

                    _filterCriteria = new OrderCriteriaDto { DateFrom = dateF, DateTo = dateT };
                }

                var itemIndex = 1;
                var ordersList = S.OrderService
                    .ListByCriteria(_filterCriteria)
                    .ToList();

                foreach (var order in ordersList)
                {
                    ordersDataGrid.Rows.Add(
                        itemIndex.ToString(),
                        order.Id,
                        order.Table,
                        order.DateCreated.Date.ToString("dd/MM/yyyy"),
                        order.DateCreated.ToString("HH:mm:ss"),
                        order.TotalAmount);
                    itemIndex++;
                }

                sumLbl.Text = ordersList.Sum(x => x.TotalAmount).ToString(_customCulture);

                if (ordersList.Any())
                    LoadChart(ordersList.ToList());
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void GoFiltersOperation()
        {
            try
            {
                DateTime? dateF;
                if (dateFromEnabled.Checked) dateF = dateFrom.Value.Date;
                else dateF = null;
                DateTime? dateT;
                if (dateToEnabled.Checked) dateT = dateTo.Value.Date;
                else dateT = null;

                _filterCriteria = new OrderCriteriaDto
                {
                    Table = tableBox.SelectedIndex != 0 ? tableBox.Text.ToInt() : 0,
                    DateFrom = dateF,
                    DateTo = dateT
                };

                InitializeOrdersOperation(_filterCriteria);
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void ChartClickedOperation()
        {
            try
            {
                var chartFrm = new ChartViewForm { ChartArea = _chartArea, Series = _series };
                chartFrm.ShowDialog();
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

        private void LoadChart(List<OrderDto> orderList)
        {
            var ordersPerDay = orderList
                .GroupBy(x => x.DateCreated.Date)
                .SelectMany(x => new Dictionary<DateTime, List<OrderDto>>
                {
                    { x.Key, x.ToList() }
                })
                .OrderBy(x => x.Key)
                .ToList();

            var chartArea = new ChartArea
            {
                BackColor = Color.FromKnownColor(KnownColor.Control),
                AxisX = new Axis
                {
                    Title = @"Ημέρες",
                    MajorGrid = new Grid { LineColor = Color.Black },
                    LabelStyle = new LabelStyle { Font = new Font(@"Bookman Old Style", 10) }
                },
                AxisY = new Axis
                {
                    Title = @"Παραγγελίες",
                    MajorGrid = new Grid { LineColor = Color.Black },
                    LabelStyle = new LabelStyle { Font = new Font(@"Bookman Old Style", 10) },
                    Minimum = ordersPerDay.Select(x => x.Value.Count).Min(),
                    Maximum = ordersPerDay.Select(x => x.Value.Count).Max()
                }
            };

            ordersPerDayChart.ChartAreas.Clear();
            ordersPerDayChart.ChartAreas.Add(chartArea);
            _chartArea = chartArea;

            var series = new Series
            {
                Name = @"Παραγγελίες",
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.String,
                BorderWidth = 3,
                Color = Color.Green,
                MarkerSize = 10,
                MarkerStyle = MarkerStyle.Circle,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                Font = new Font(@"Bookman Old Style", 10, FontStyle.Bold),
                MarkerColor = Color.SpringGreen,
                LabelBackColor = Color.White,
                LabelBorderColor = Color.Black
            };

            series.Points.DataBindXY(
                ordersPerDay.Select(x => $"{x.Key.Day}/{x.Key.Month}/{x.Key.Year}").ToList(),
                ordersPerDay.Select(x => x.Value.Count).ToList());

            ordersPerDayChart.Series.Clear();
            ordersPerDayChart.Series.Add(series);
            _series = series;

            ordersPerDayChart.Invalidate();
        }
        #endregion
    }
}
