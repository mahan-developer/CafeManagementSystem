using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class Invoice
    {

        private int _invoiceID;
        [Column("int")]
        public int InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }


        private int _customerID;
        [Column("int")]
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }


        private string _customerName;
        [Column("NVARCHAR", 50)]
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }


        private DateTime _invoiceDate;
        [Column("DATETIME")]
        public DateTime InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }

        private DateTime _invoiceUpdateDate;
        [Column("DATETIME")]
        public DateTime InvoiceUpdateDate
        {
            get { return _invoiceUpdateDate; }
            set { _invoiceUpdateDate = value; }
        }

        private decimal _invoicePrice;
        [Column("DECIMAL", 18, 2)]
        public decimal InvoicePrice
        {
            get { return _invoicePrice; }
            set { _invoicePrice = value; }
        }

        private string _paymentMethod;
        [Column("NVARCHAR", 8)]
        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        private string _orderMode;
        [Column("NVARCHAR", 8)]
        public string OrderMode
        {
            get { return _orderMode; }
            set { _orderMode = value; }
        }

        private string _invoiceDescripton;
        [Column("NVARCHAR", 255)]
        public string InvoiceDescripton
        {
            get { return _invoiceDescripton; }
            set { _invoiceDescripton = value; }
        }
    }
}
