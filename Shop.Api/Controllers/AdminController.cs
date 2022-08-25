using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DataModels.CustomModels;
using Shop.Logic.Services; //Buradaki AdminService lerin ShopLogic Class libary sinde actıgımız service klasörüyle alakası var
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IWebHostEnvironment env;                
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService, IWebHostEnvironment _env)
        {
            this._adminService = adminService;
            this.env = _env;
        }

        [HttpPost]
        [Route("AdminLogin")]
        public IActionResult AdminLogin(LoginModel loginModel)
        {
            var data = _adminService.AdminLogin(loginModel);
            return Ok(data);
        }

        [HttpPost]
        [Route("SaveCategory")]
        public IActionResult SaveCategory(CategoryModel newCategory)
        {
            var data = _adminService.SaveCategory(newCategory);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetCategories")]

        public IActionResult GetCategories()
        {
            var data = _adminService.GetCategories();
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateCategory")]
        public IActionResult UpdateCategory(CategoryModel categoryToUpdate)
        {
            var data = _adminService.UpdateCategory(categoryToUpdate);
            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteCategory")]
        public IActionResult DeleteCategory(CategoryModel categoryToDelete)
        {
            var data = _adminService.DeleteCategory(categoryToDelete);
            return Ok(data);
        }
    }
}
