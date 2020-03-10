namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using static Utilities.Enums;
    using System.Windows.Forms;
    using Utilities;
    using System;
    #endregion

    public partial class SetQuantityForm : Form
    {
        #region Properties
        public decimal QuantitySelected;
        public UserAction Action = UserAction.Cancelled;
        #endregion

        #region Constructor
        public SetQuantityForm()
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
                case @"cancelQuantityInput":
                    CancelQuantityOperation();
                    break;
                case @"completeQuantityInput":
                    CompleteQuantityOperation();
                    break;
                case @"clearBtn":
                    ClearOperation();
                    break;
                default:
                    $"Invalid Event Handle {btnSender.Name}".ErrMsg();
                    break;
            }
        }

        protected void NumberButtonClicked(object sender, EventArgs e)
        {
            if (!(sender is Button btnSender))
                return;

            quantityInput.Text += btnSender.Text;
        }
        #endregion

        #region Operation Methods
        private void CancelQuantityOperation()
        {
            try
            {
                quantityInput.Clear();
                Action = UserAction.Cancelled;
                Close();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }

        private void CompleteQuantityOperation()
        {
            try
            {
                if (quantityInput.Text.IsEmpty() || quantityInput.Text.ToDecimal() == 0)
                    @"Εισάγετε έγκυρη ποσότητα".WarnMsg(@"Εσφαλμένη εισαγωγή");
                else
                {
                    QuantitySelected = quantityInput.Text.ToDecimal();
                    Action = UserAction.Submitted;
                    quantityInput.Clear();
                    Close();
                }
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
                quantityInput.Clear();
            }
            catch (Exception x)
            {
                x.ShowException();
            }
        }
        #endregion
    }
}
