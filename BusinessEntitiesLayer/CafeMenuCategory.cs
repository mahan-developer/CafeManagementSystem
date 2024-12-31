using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class CafeMenuCategory
    {
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

    }
}
