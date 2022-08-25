using Shop.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;                  


namespace Shop.Admin1.Services
{
    public interface IAdminPanelService     
    {
        Task<ResponseModel> AdminLogin(LoginModel loginModel); //login için
        Task<CategoryModel> SaveCategory(CategoryModel newCategory); //category için
        Task<List<CategoryModel>> GetCategories();
        Task<bool> UpdateCategory(CategoryModel categoryToUpdate);
        Task<bool> DeleteCategory(CategoryModel categoryToDelete);
    }
}
//Bu sayfayı adminpanelservice de yaptıgımız işlemlerden sonra hallediyoruz
//Örn: Category Razor açtık içini doldurduk code{} içini/Admınpanel serviceden retun awaitleri yazdık/burayada asağıdakılerı
//sONRA apiControllera gidiyoruz oraya da burdan sonraki işlemleri giriyoruz/ShopLogic libarysinde ki admin service gidiyoruz sonra Onun Interfaceıneservisine gidiyoruz
