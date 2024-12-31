using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class CafeMenuItem
    {

        private int _cafeMenuItemID;
        [Column("int")]
        public int CafeMenuItemID
        {
            get { return _cafeMenuItemID; }
            set { _cafeMenuItemID = value; }
        }

        private int _cafeMenuCategoryID;
        [Column("int")]
        public int CafeMenuCategoryID
        {
            get { return _cafeMenuCategoryID; }
            set { _cafeMenuCategoryID = value; }
        }

        private string _cafeMenuCategoryName;
        [Column("NVARCHAR", 25)]
        public string CafeMenuCategoryName
        {
            get { return _cafeMenuCategoryName; }
            set { _cafeMenuCategoryName = value; }
        }

        private int _cafeMenuItemSizeCategoryID;
        [Column("int")]
        public int CafeMenuItemSizeCategoryID
        {
            get { return _cafeMenuItemSizeCategoryID; }
            set { _cafeMenuItemSizeCategoryID = value; }
        }

        private string _cafeMenuItemSizeCategoryName;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemSizeCategoryName
        {
            get { return _cafeMenuItemSizeCategoryName; }
            set { _cafeMenuItemSizeCategoryName = value; }
        }

        private int _cafeMenuItemSizeID;
        [Column("int")]
        public int CafeMenuItemSizeID
        {
            get { return _cafeMenuItemSizeID; }
            set { _cafeMenuItemSizeID = value; }
        }

        private string _cafeMenuItemSizeName;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemSizeName
        {
            get { return _cafeMenuItemSizeName; }
            set { _cafeMenuItemSizeName = value; }
        }

        private string _cafeMenuItemName;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemName
        {
            get { return _cafeMenuItemName; }
            set { _cafeMenuItemName = value; }
        }

        private decimal _cafeMenuItemPrice;
        [Column("DECIMAL", 18, 2)]
        public decimal CafeMenuItemPrice
        {
            get { return _cafeMenuItemPrice; }
            set { _cafeMenuItemPrice = value; }
        }

        private bool _cafeMenuItemIsAvailable;
        [Column("BIT")]
        public bool CafeMenuItemIsAvailable
        {
            get { return _cafeMenuItemIsAvailable; }
            set { _cafeMenuItemIsAvailable = value; }
        }

        private string _cafeMenuItemDescripton;
        [Column("NVARCHAR", 250)]
        public string CafeMenuItemDescripton
        {
            get { return _cafeMenuItemDescripton; }
            set { _cafeMenuItemDescripton = value; }
        }

        private string _cafeMenuItemImage;
        [Column("NVARCHAR", 20)]
        public string CafeMenuItemImage
        {
            get { return _cafeMenuItemImage; }
            set { _cafeMenuItemImage = value; }
        }

    }
}
