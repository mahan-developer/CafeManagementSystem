using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;

namespace BusinessApplicationLayer
{
    public class CafeMenuItemSizeService
    {
        private readonly CafeMenuItemSizeRepository _cafeMenuItemSizeRepository;
        public CafeMenuItemSizeService(CafeMenuItemSizeRepository cafeMenuItemSizeRepository)
        {
            _cafeMenuItemSizeRepository = cafeMenuItemSizeRepository;
        }

        public bool AddMenuItemSize(CafeMenuItemSize menuItemSize)
        {
            try
            {
                int result = _cafeMenuItemSizeRepository.InsertCafeMenuItemSize(menuItemSize);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }

        }



        // Update an existing MenuItemSizeCategory
        public bool EditCafeMenuItemSize(CafeMenuItemSize cafeMenuItemSize)
        {
            try
            {
                return _cafeMenuItemSizeRepository.EditCafeMenuItemSize(cafeMenuItemSize);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while updating the menu item size.", ex);
            }
        }

        // Delete a MenuItemSizeby ID
        public bool DeleteCafeMenuItemSize(int cafeMenuItemSizeId)
        {
            try
            {
                return _cafeMenuItemSizeRepository.DeleteCafeMenuItemSize(cafeMenuItemSizeId);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while deleting the menu item size.", ex);
            }
        }




        // Search MenuItemSize by keyword
        public List<CafeMenuItemSize> GetCafeMenuItemSize(Dictionary<string, object> searchParameters)
        {
            try
            {
                return _cafeMenuItemSizeRepository.GetCafeMenuItemSize(searchParameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while searching for menu item size.", ex);
            }
        }

    }
}
