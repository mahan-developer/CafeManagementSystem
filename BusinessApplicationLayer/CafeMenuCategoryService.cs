using System;
using System.Collections.Generic;
using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;

namespace BusinessApplicationLayer
{
    public class CafeMenuCategoryService
    {
        private readonly CafeMenuCategoryRepository _cafeMenuCategoryRepository;

        public CafeMenuCategoryService(CafeMenuCategoryRepository cafeMenuCategoryRepository)
        {
            _cafeMenuCategoryRepository = cafeMenuCategoryRepository;
        }


        // Add a new MenuCategory
        public bool AddCafeMenuCategory(CafeMenuCategory cafeMenuCategory)
        {
            try
            {
                int result = _cafeMenuCategoryRepository.InsertMenuCategory(cafeMenuCategory);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while adding the menu category.", ex);
            }
        }

        // Update an existing MenuCategory
        public bool EditCafeMenuCategory(CafeMenuCategory cafeMenuCategory)
        {
            try
            {
                return _cafeMenuCategoryRepository.EditMenuCategory(cafeMenuCategory);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while updating the menu category.", ex);
            }
        }

        // Delete a MenuCategory by ID
        public bool DeleteCafeMenuCategory(int cafeMenuCategoryId)
        {
            try
            {
                return _cafeMenuCategoryRepository.DeleteMenuCategory(cafeMenuCategoryId);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while deleting the menu category.", ex);
            }
        }




        // Search MenuItemSizeCategories by keyword
        public List<CafeMenuCategory> GetCafeMenuCategories(Dictionary<string, object> searchParameters)
        {
            try
            {
                return _cafeMenuCategoryRepository.GetCafeMenuCategory(searchParameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while searching for menu categories.", ex);
            }
        }



    }
}
