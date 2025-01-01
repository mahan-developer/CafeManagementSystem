using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace CafeManager
{
    public class PrintService
    {
        private PrintDocument _printDocument;
        private List<string[]> _data;
        private string _shopName;
        private string _shopAddress;
        private string _shopPhone;
        private string _total;
        private string _description;
        private Image _logo;

        private float _dpiX;
        private float _dpiY;

        public PrintService(float dpiX, float dpiY)
        {
            _printDocument = new PrintDocument();
            _printDocument.PrintPage += PrintDocument_PrintPage;

            _dpiX = dpiX;
            _dpiY = dpiY;
        }

        public PrintDocument GetPrintDocument() => _printDocument;


        public void SetInvoiceData(string shopName, string shopAddress,string shopPhone, Image logo, List<string[]> data, string total, string description)
        {
            _shopName = shopName;
            _shopAddress = shopAddress;
            _shopPhone = shopPhone;
            _logo = logo;
            _data = data;
            _total = total;
            _description = description;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 6);
            Font boldFont = new Font("Arial", 6, FontStyle.Bold);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Brushes.Black);

            int startX = (int)(5 * _dpiX / 25.4); 
            int startY = (int)(5 * _dpiY / 25.4); 
            int lineHeight = (int)(6 * _dpiY / 25.4); 

            int totalWidth = (int)(80 * _dpiX / 25.4); 

            
     
            int col1Width = totalWidth / 2;
            int col2Width = totalWidth - col1Width;
            graphics.DrawRectangle(pen, startX, startY, col1Width, lineHeight);
            graphics.DrawRectangle(pen, startX + col1Width, startY, col2Width, lineHeight);
            graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), font, brush, startX + 2, startY + 2);
            graphics.DrawString(_shopName, boldFont, brush, startX + col1Width + 2, startY + 2);

            startY += lineHeight;

            int logoHeight = 50;
            graphics.DrawRectangle(pen, startX, startY, col1Width, logoHeight);
            graphics.DrawRectangle(pen, startX + col1Width, startY, col2Width, logoHeight);
            graphics.DrawString(_shopAddress + "\n" + _shopPhone, font, brush, startX + 2, startY + 2);
            


            try
            {
                int logoMaxWidth = col2Width - 10;
                int logoMaxHeight = logoHeight - 10;

                float logoAspectRatio = (float)_logo.Width / _logo.Height;

                int adjustedLogoWidth = logoMaxWidth;
                int adjustedLogoHeight = (int)(logoMaxWidth / logoAspectRatio);

                if (adjustedLogoHeight > logoMaxHeight)
                {
                    adjustedLogoHeight = logoMaxHeight;
                    adjustedLogoWidth = (int)(logoMaxHeight * logoAspectRatio);
                }

                int logoX = startX + col1Width + (col2Width - adjustedLogoWidth) / 2;
                int logoY = startY + (logoHeight - adjustedLogoHeight) / 2;
                if (_logo != null)
                {
                    graphics.DrawImage(_logo, logoX, logoY, adjustedLogoWidth, adjustedLogoHeight);
                }
                else
                {
                    graphics.DrawImage(Properties.Resources.cat_hotchok2, logoX, logoY, adjustedLogoWidth, adjustedLogoHeight);
                }
            }
            catch
            {
                graphics.DrawString("[No Logo]", font, brush, startX + col1Width + 2, startY + 2);
            }

            startY += logoHeight;

            int col3Width = totalWidth / 6;
            string[] headers = { "Row", "Item", "Size", "U.Price", "Qty", "T.Price" };
            graphics.DrawRectangle(pen, startX, startY, 25, lineHeight);
            graphics.DrawString(headers[0], boldFont, brush, startX + 2, startY + 2);

            graphics.DrawRectangle(pen, startX + 25, startY, 126, lineHeight);
            graphics.DrawString(headers[1], boldFont, brush, startX + 27, startY + 2);

            graphics.DrawRectangle(pen, startX + 151, startY, 44, lineHeight);
            graphics.DrawString(headers[2], boldFont, brush, startX + 153, startY + 2);

            graphics.DrawRectangle(pen, startX + 195, startY, 40, lineHeight);
            graphics.DrawString(headers[3], boldFont, brush, startX + 197, startY + 2);

            graphics.DrawRectangle(pen, startX + 235, startY, 25, lineHeight);
            graphics.DrawString(headers[4], boldFont, brush, startX + 237, startY + 2);

            graphics.DrawRectangle(pen, startX + 260, startY, 42, lineHeight);
            graphics.DrawString(headers[5], boldFont, brush, startX + 262, startY + 2);


            startY += lineHeight;

            
            foreach (var row in _data)
            {
                graphics.DrawRectangle(pen, startX, startY, 25, lineHeight);
                graphics.DrawString(row[0], boldFont, brush, startX + 2, startY + 2);

                graphics.DrawRectangle(pen, startX + 25, startY, 126, lineHeight);
                graphics.DrawString(row[1], boldFont, brush, startX + 27, startY + 2);

                graphics.DrawRectangle(pen, startX + 151, startY, 44, lineHeight);
                graphics.DrawString(row[2], boldFont, brush, startX + 153, startY + 2);

                graphics.DrawRectangle(pen, startX + 195, startY, 40, lineHeight);
                graphics.DrawString(row[3], boldFont, brush, startX + 197, startY + 2);

                graphics.DrawRectangle(pen, startX + 235, startY, 25, lineHeight);
                graphics.DrawString(row[4], boldFont, brush, startX + 237, startY + 2);

                graphics.DrawRectangle(pen, startX + 260, startY, 42, lineHeight);
                graphics.DrawString(row[5], boldFont, brush, startX + 262, startY + 2);


                startY += lineHeight;
            }
            int descHeight = (int)(10 * _dpiY / 25.4);
            graphics.DrawRectangle(pen, startX, startY, col1Width, descHeight);
            graphics.DrawString(_description, font, brush, startX + 2, startY + 2);

            graphics.DrawRectangle(pen, startX + col1Width, startY, col2Width, descHeight);
            graphics.DrawString("Total: " + _total, boldFont, brush, startX + col1Width + 2, startY + 2);



        }

    }
}
