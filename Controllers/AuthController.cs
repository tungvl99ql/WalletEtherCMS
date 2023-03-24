using CMSWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CMSWallet.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppSettings appsetting;
        public AuthController(IOptions<AppSettings> options)
        {
            appsetting = options.Value;
        }
        public IActionResult Index()
        {
            Debug.WriteLine("API=>" + appsetting.API_URL);
            return View();
        }

        public IActionResult Register()
        {
            Debug.WriteLine("API=>" + appsetting.API_URL);
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Login(string username, string password)
        {
            var response = await CallAPI.PostAsync(appsetting.API_URL+ "users/login", new Loginbody { username = username,password = password});
            //Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<DataLogin>>(response);
            if (res.Success)
            {
                Debug.WriteLine(res.Data.accesstoken);
                HttpContext.Session.SetString("Token", res.Data.accesstoken);
                HttpContext.Session.SetString("UserName", username);
            }
            return Json(response);
        }

        [HttpPost]
        public async Task<JsonResult> postRegister(string username, string password, string repassword)
        {

            if (password != repassword)
            {
                return Json(new BaseResult<DataLogin>
                {
                    Data = null,
                    Message = "mật khẩu không khớp!",
                    Success = false,
                });
            }

            var response = await CallAPI.PostAsync(appsetting.API_URL + "users/register", new Regbody { username = username, password = password });
            //Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<DataReg>>(response);
            
            return Json(res);
        }

    }

    public class Loginbody
    {
       public string username { get; set; }
       public string password { get; set; }
    }
    public class Regbody
    {
        public string username { get; set; }
        public string password { get; set; }
    }

}
