using System;
using System.Collections.Generic;
using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;

namespace BusinessApplicationLayer
{
    public class CafeMenuItemSizeCategoryService
    {
        private readonly CafeMenuItemSizeCategoryRepository _cafeMenuItemSizeCategoryRepository;

        public CafeMenuItemSizeCategoryService(CafeMenuItemSizeCategoryRepository cafeMenuItemSizeCategoryRepository)
        {
            _cafeMenuItemSizeCategoryRepository = cafeMenuItemSizeCategoryRepository ?? throw new ArgumentNullException(nameof(cafeMenuItemSizeCategoryRepository));
        }


        


        // Add a new MenuItemSizeCategory
        public bool AddCafeMenuItemSizeCategory(CafeMenuItemSizeCategory cafeMenuItemSizeCategory)
        {
            try
            {
                int result = _cafeMenuItemSizeCategoryRepository.InsertMenuItemSizeCategory(cafeMenuItemSizeCategory);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while adding the menu item size category.", ex);
            }
        }

        // Update an existing MenuItemSizeCategory
        public bool EditCafeMenuItemSizeCategory(CafeMenuItemSizeCategory cafeMenuItemSizeCategory)
        {
            try
            {
                return _cafeMenuItemSizeCategoryRepository.EditMenuItemSizeCategory(cafeMenuItemSizeCategory);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while updating the menu item size category.", ex);
            }
        }

        // Delete a MenuItemSizeCategory by ID
        public bool DeleteCafeMenuItemSizeCategory(int cafeMenuItemSizeCategoryId)
        {
            try
            {
                return _cafeMenuItemSizeCategoryRepository.DeleteMenuItemSizeCategory(cafeMenuItemSizeCategoryId);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while deleting the menu item size category.", ex);
            }
        }


       

        // Search MenuItemSizeCategories by keyword
        public List<CafeMenuItemSizeCategory> GetCafeMenuItemSizeCategories(Dictionary<string, object> searchParameters)
        {
            try
            {
                return _cafeMenuItemSizeCategoryRepository.GetCafeMenuItemSizeCategory(searchParameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while searching for menu item size categories.", ex);
            }
        }

        
    }
}
