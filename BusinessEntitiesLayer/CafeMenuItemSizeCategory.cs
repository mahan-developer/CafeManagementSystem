using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class CafeMenuItemSizeCategory
    {
        private int _cafeMenuItemSizeCategoryID;
        [Column("int")]
        public int CafeMenuItemSizeCategoryID
        {
            get { return _cafeMenuItemSizeCategoryID; }
            set { _cafeMenuItemSizeCategoryID = value; }
        }


        private string _cageMenuItemSizeCategoryName;
        [Column("NVARCHAR", 25)]
        public string CafeMenuItemSizeCategoryName
        {
            get { return _cageMenuItemSizeCategoryName; }
            set { _cageMenuItemSizeCategoryName = value; }
        }
    }
}
