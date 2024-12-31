using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationLayer
{
    public class CafeMenuItemService
    {
        private readonly CafeMenuItemRepository _cafeMenuItemRepository;
        public CafeMenuItemService(CafeMenuItemRepository cafeMenuItemRepository)
        {
            _cafeMenuItemRepository = cafeMenuItemRepository;
        }

        public bool AddCafeMenuItem(CafeMenuItem cafeMenuItem)
        {
            try
            {
                int result = _cafeMenuItemRepository.InsertCafeMenuItem(cafeMenuItem);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }

        }


        // Update an existing MenuItemSizeCategory
        public bool EditCafeMenuItem(CafeMenuItem cafeMenuItem)
        {
            try
            {
                return _cafeMenuItemRepository.EditCafeMenuItem(cafeMenuItem);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while updating the menu item.", ex);
            }
        }

        // Delete a MenuItemSizeby ID
        public bool DeleteCafeMenuItem(int cafeMenuItemId)
        {
            try
            {
                return _cafeMenuItemRepository.DeleteCafeMenuItem(cafeMenuItemId);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while deleting the menu item.", ex);
            }
        }




        // Search MenuItemSize by keyword
        public List<CafeMenuItem> GetCafeMenuItem(Dictionary<string, object> searchParameters)
        {
            try
            {
                return _cafeMenuItemRepository.GetCafeMenuItem(searchParameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while searching for menu item.", ex);
            }
        }

    }
}
