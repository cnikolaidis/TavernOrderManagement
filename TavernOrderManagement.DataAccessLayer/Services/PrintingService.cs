namespace TavernOrderManagement.DataAccessLayer.Services
{
    #region Usings
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using System.Globalization;
    using System.Drawing;
    using Models.Dtos;
    using Utilities;
    using System;
    #endregion

    public static class PrintingService
    {
        #region Properties
        private static CultureInfo _customCulture;
        #endregion

        #region Service Public Methods
        public static void ReceiptForOrder(OrderDto order)
        {
            SetApplicationCulture();
            PrintDialog selectPrinterDiag = new PrintDialog();
            if (selectPrinterDiag.ShowDialog() == DialogResult.OK)
            {
                PrintDocument docToPrint = new PrintDocument
                {
                    DocumentName = $"ORDER_Table_{order.Table}",
                    PrintController = new StandardPrintController(),
                    PrinterSettings = new PrinterSettings
                    {
                        PrinterName = selectPrinterDiag.PrinterSettings.PrinterName
                    }
                };

                docToPrint.PrintPage += (s, e) =>
                {
                    float x = 10;
                    float y = 10;

                    var theTempPrint = @"ΟΥΖΕΡΙ 'ΠΑΠΑΔΗΣ'";
                    var theTempFont = new Font("Consolas", 17, FontStyle.Bold);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    y += 20;
                    theTempPrint = $"ΤΡΑΠΕΖΙ: {order.Table}";
                    theTempFont = new Font("Consolas", 12, FontStyle.Bold);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    theTempPrint = $"{DateTime.Now.ToString("dd/MM/yyyy")} {DateTime.Now.ToString("HH:mm")}";
                    theTempFont = new Font("Consolas", 10, FontStyle.Regular);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    y += 20;
                    theTempPrint = @"Ενδεικτική Παραγγελία";
                    theTempFont = new Font("Consolas", 10, FontStyle.Bold);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                    e.Graphics.DrawLine(new Pen(Color.Black), new Point((int)x, ((int)y + 20)),
                        new Point(((int)x + 300), ((int)y + 20)));
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    y += 10;
                    theTempPrint = @"ΕΙΔΟΣ";
                    theTempFont = new Font("Consolas", 14, FontStyle.Bold);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);

                    theTempPrint = @"€";
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), (x + 200), y);
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    theTempFont = new Font("Consolas", 8, FontStyle.Bold);
                    foreach (var item in order.OrderItems)
                    {
                        theTempPrint = item.Name;
                        e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);

                        theTempPrint = $"{item.Price} x {item.Quantity}";
                        e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), (x + 170), y);
                        y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;
                    }

                    theTempFont = new Font("Consolas", 14, FontStyle.Bold);

                    y += 10;

                    e.Graphics.DrawLine(new Pen(Color.Black), new Point((int)x, (int)y),
                        new Point(((int)x + 300), (int)y));

                    theTempPrint = "ΣΥΝΟΛΟ";
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);

                    theTempPrint = order.TotalAmount.ToString(_customCulture);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), (x + 170), y);
                };

                docToPrint.Print();
                docToPrint.Dispose();
            }
        }

        public static void DaySummary(decimal daySum)
        {
            SetApplicationCulture();
            PrintDialog selectPrinterDiag = new PrintDialog();
            if (selectPrinterDiag.ShowDialog() == DialogResult.OK)
            {
                var dateTime = DateTime.Now;
                PrintDocument docToPrint = new PrintDocument
                {
                    DocumentName = $"Day_{dateTime.ToString("ddMMyyyy")}_SUM",
                    PrintController = new StandardPrintController(),
                    PrinterSettings = new PrinterSettings
                    {
                        PrinterName = selectPrinterDiag.PrinterSettings.PrinterName
                    }
                };

                docToPrint.PrintPage += (s, e) =>
                {
                    float x = 10;
                    float y = 10;
                    
                    StringFormat strFormat = new StringFormat();
                    strFormat.Alignment = StringAlignment.Center;

                    var theTempPrint = "ΟΥΖΕΡΙ 'ΠΑΠΑΔΗΣ'";
                    var theTempFont = new Font("Consolas", 18, FontStyle.Bold);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    theTempPrint = "ΣΥΝΟΛΟ ΗΜΕΡΑΣ";
                    theTempFont = new Font("Consolas", 15, FontStyle.Regular);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                    y += e.Graphics.MeasureString(theTempPrint, theTempFont).Height;

                    theTempPrint = $"{daySum.ToString(_customCulture)} €";
                    theTempFont = new Font("Consolas", 18, FontStyle.Bold);
                    e.Graphics.DrawString(theTempPrint, theTempFont, new SolidBrush(Color.Black), x, y);
                };

                docToPrint.Print();
                docToPrint.Dispose();
            }
        }
        #endregion

        #region Custom Methods
        private static void SetApplicationCulture()
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
