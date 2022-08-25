using Shop.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components; //elle yazdık paket indirmeden var bi fırıldak
using System.Threading.Tasks;
using System.Net.Http;

namespace Shop.Admin1.Services
{
    public class AdminPanelService : IAdminPanelService
    {
        private readonly HttpClient httpClient;
        public AdminPanelService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<ResponseModel> AdminLogin(LoginModel loginModel) //Login.Razor alt kısımda kı loginModel bölümüne selam çakıyor burası
        {
            return await httpClient.PostJsonAsync<ResponseModel>("api/admin/AdminLogin", loginModel);
        }

        public async Task<CategoryModel> SaveCategory(CategoryModel newCategory)
        {
            return await httpClient.PostJsonAsync<CategoryModel>("api/admin/SaveCategory", newCategory); //ShopAdmın/Pages/CategoryRazor'a selam çakıyor burası
        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            return await httpClient.GetJsonAsync<List<CategoryModel>>("api/admin/GetCategories");
        }

        public async Task<bool> UpdateCategory(CategoryModel categoryToUpdate)
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/UpdateCategory", categoryToUpdate);
        }
        public async Task<bool> DeleteCategory(CategoryModel categoryToDelete)
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/DeleteCategory", categoryToDelete);
        }
    }
}















//Install-Package Microsoft.AspNetCore.Blazor.HttpClient -Version 3.2.0-preview3.20168.3 bunu sitesinden kurduk packmanagerden ıntstall ettık