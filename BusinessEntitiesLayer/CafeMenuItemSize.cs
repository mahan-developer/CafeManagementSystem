using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class CafeMenuItemSize
    {
        private int _cafeMenuItemSizeID;
        [Column("int")]
        public int CafeMenuItemSizeID
        {
            get { return _cafeMenuItemSizeID; }
            set { _cafeMenuItemSizeID = value; }
        }

        private int _cafeMenuItemSizeCategoryID;
        [Column("int")]
        public int CafeMenuItemSizeCategoryID
        {
            get { return _cafeMenuItemSizeCategoryID; }
            set { _cafeMenuItemSizeCategoryID = value; }
        }

        private string _cafeMenuItemSizeCategoryName;
        [Column("NVARCHAR", 15)]
        public string CafeMenuItemSizeCategoryName
        {
            get { return _cafeMenuItemSizeCategoryName; }
            set { _cafeMenuItemSizeCategoryName = value; }
        }

        private string _cafeMenuItemSizeName;
        [Column("NVARCHAR", 15)]
        public string CafeMenuItemSizeName
        {
            get { return _cafeMenuItemSizeName; }
            set { _cafeMenuItemSizeName = value; }
        }


    }
}
