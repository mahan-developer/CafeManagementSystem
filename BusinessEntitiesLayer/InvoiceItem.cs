using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class InvoiceItem
    {
        private int _invoceItemID;
        [Column("int")]
        public int InvoiceItemID
        {
            get { return _invoceItemID; }
            set { _invoceItemID = value; }
        }

        private int _invoiceID;
        [Column("int")]
        public int InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }

        private int _cafeMenuItemID;
        [Column("int")]
        public int CafeMenuItemID
        {
            get { return _cafeMenuItemID; }
            set { _cafeMenuItemID = value; }
        }

        private string _cafeMenuItemCategory;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemCategory
        {
            get { return _cafeMenuItemCategory; }
            set { _cafeMenuItemCategory = value; }
        }

        private string _cafeMenuItemName;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemName
        {
            get { return _cafeMenuItemName; }
            set { _cafeMenuItemName = value; }
        }

        private string _cafeMenuItemSize;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemSize
        {
            get { return _cafeMenuItemSize; }
            set { _cafeMenuItemSize = value; }
        }


        private int _quantity;
        [Column("int")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }

        }

        private decimal _cafeMenuItemPrice;
        [Column("DECIMAL", 18, 2)]
        public decimal CafeMenuItemPrice
        {
            get { return _cafeMenuItemPrice; }
            set { _cafeMenuItemPrice = value; }
        }

        private DateTime _itemUpdateDate;
        [Column("DATETIME")]
        public DateTime ItemUpdateDate
        {
            get { return _itemUpdateDate; }
            set { _itemUpdateDate = value; }
        }

    }
}
