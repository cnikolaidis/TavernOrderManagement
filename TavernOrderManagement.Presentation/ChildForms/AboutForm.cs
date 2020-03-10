namespace TavernOrderManagement.Presentation.ChildForms
{
    #region Usings
    using System.Windows.Forms;
    #endregion

    public sealed partial class AboutForm : Form
    {
        #region Constructor
        public AboutForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            Text = string.Empty;
        }
        #endregion
    }
}
