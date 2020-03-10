namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using static Utilities.Enums;
    using System.Windows.Forms;
    using Utilities;
    using System;
    #endregion

    public partial class TableNumsForm : Form
    {
        #region Properties
        public int ToTable;
        public UserAction Action = UserAction.Cancelled;

        private readonly int _fromTable;
        #endregion

        #region Constructor
        public TableNumsForm(int fromTable = 0)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            if (fromTable != 0)
                _fromTable = fromTable;
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            for (var i = 1; i < 52; i++)
                tablesComboBox.Items.Add(i.ToString());
            tablesComboBox.Text = $@"{_fromTable}";
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            switch (btnSender.Name)
            {
                case @"okBtn":
                    OkOperation();
                    break;
                case "cancelBtn":
                    CancelOperation();
                    break;
            }
        }
        #endregion

        #region Operation Methods
        private void OkOperation()
        {
            try
            {
                if (tablesComboBox.Text.IsEmpty())
                    @"Δεν έχετε επιλέξει τραπέζι".WarnMsg(@"Κενό πεδίο");
                else
                {
                    ToTable = tablesComboBox.Text.ToInt();
                    Action = UserAction.Submitted;
                    Close();
                }
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
                Action = UserAction.Cancelled;
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
