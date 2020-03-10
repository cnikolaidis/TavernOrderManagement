namespace TavernOrderManagement.Utilities.UtilityForms
{
    #region Usings
    using System.Windows.Forms.DataVisualization.Charting;
    using System.Windows.Forms;
    using System;
    #endregion

    public partial class ChartViewForm : Form
    {
        #region Properties
        public ChartArea ChartArea { get; set; }
        public Series Series { get; set; }
        #endregion

        #region Constructor
        public ChartViewForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            CenterToScreen();
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            LoadChart();
        }
        #endregion

        #region Custom Methods
        private void LoadChart()
        {
            try
            {
                if (ChartArea == null || Series == null)
                    return;

                chartCtrl.ChartAreas.Clear();
                chartCtrl.ChartAreas.Add(ChartArea);

                chartCtrl.Series.Clear();
                chartCtrl.Series.Add(Series);

                chartCtrl.Invalidate();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion
    }
}
