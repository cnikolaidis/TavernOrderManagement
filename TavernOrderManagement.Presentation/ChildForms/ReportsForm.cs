namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using System.Windows.Forms;
    using Utilities;
    using System;
    #endregion

    public partial class ReportsForm : Form
    {
        #region Constructor
        public ReportsForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region Event Methods
        protected void ButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            switch (btnSender.Name)
            {
                case @"printReportBtn":
                    PrintReportOperation();
                    break;
                case @"cancelBtn":
                    CancelOperation();
                    break;
            }
        }
        #endregion

        #region Operation Methods
        private void PrintReportOperation()
        {
            try
            {

            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void CancelOperation()
        {
            try
            {
                Dispose();
                Close();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion
    }
}
