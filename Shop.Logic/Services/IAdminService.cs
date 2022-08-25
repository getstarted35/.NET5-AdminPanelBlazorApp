using Shop.DataModels.CustomModels; //ShopLogic ClassLibary sını referanslardan data ya bağladık. Sonra burada göründü .ctrl ile
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Services
{                                                                                   
    public interface IAdminService
    {
        ResponseModel AdminLogin(LoginModel loginModel);
        CategoryModel SaveCategory(CategoryModel newCategory);
        List<CategoryModel> GetCategories();

        bool UpdateCategory(CategoryModel categoryToUpdate);
        bool DeleteCategory(CategoryModel categoryToDelete);

    }
}
