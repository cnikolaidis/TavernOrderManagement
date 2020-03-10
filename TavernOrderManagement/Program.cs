namespace TavernOrderManagement
{
    #region Usings
    using System.Windows.Forms;
    using System;
    #endregion

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Presentation.MainForm());
        }
    }
}
