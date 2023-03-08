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
            }
            return Json(response);
        }

    }

    public class Loginbody
    {
       public string username { get; set; }
       public string password { get; set; }
    }
    
}
