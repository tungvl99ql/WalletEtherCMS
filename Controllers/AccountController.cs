using CMSWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CMSWallet.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppSettings appsetting;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AccountController(IOptions<AppSettings> options, IHttpContextAccessor httpContextAccessor)
        {
            appsetting = options.Value;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Changepass()
        {
            return View();
        }
        public IActionResult Listmanager()
        {
            return View();
        }
        public IActionResult Createmanager()
        {
            return View();
        }
        public async Task<IActionResult> Infor()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Get(appsetting.API_URL + "users/Profile", token);
            var res = JsonConvert.DeserializeObject<BaseResult<Profile>>(response);
            return View(res.Data);
        }

        public async Task<IActionResult> AdvanceSetting()
        {
            //var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            //var response = await CallAPI.Get(appsetting.API_URL + "users/Profile", token);
            //var res = JsonConvert.DeserializeObject<BaseResult<Profile>>(response);
            return View();
        }

        public async Task<IActionResult> Createmanagerpost(string username)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "users/createManager", token, new createmanagerbody { username = username});
            var res = JsonConvert.DeserializeObject<BaseResult<Hideinforwallet>>(response);
            return Json(res);
        }

        public async Task<IActionResult> HidePhrase()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Get(appsetting.API_URL + "users/Hidephrase", token);
            var res = JsonConvert.DeserializeObject<BaseResult<Hideinforwallet>>(response);
            return Json(res.Data);
        }

        public async Task<IActionResult> changepassPost(string oldpass,string newpass)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "users/changePass", token,new changepassbody { oldpass = oldpass,newpass = newpass } );
            var res = JsonConvert.DeserializeObject<BaseResult<Hideinforwallet>>(response);
            return Json(res);
        }

        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Remove("Token");
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("EndToken");
            return RedirectToAction("Index", "Auth");
        }

        public async Task<IActionResult> Upgrade()
        {

            return View();
        }
    }
    public class changepassbody
    {
        public string oldpass { get; set; }
        public string newpass { get; set; }
    }

    public class createmanagerbody
    {
        public string username { get; set; }
    }
}
