using CMSWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace CMSWallet.Controllers
{
    public class WalletController : Controller
    {
        private readonly AppSettings appsetting;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public WalletController(IOptions<AppSettings> options, IHttpContextAccessor httpContextAccessor)
        {
            appsetting = options.Value;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> Index() //  danh sach wallet 
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Get(appsetting.API_URL + "wallet/ListWallet", _httpContextAccessor.HttpContext.Session.GetString("Token"));
            //Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<Datalistwallet>>(response);
            //Debug.WriteLine(res);
            return View(res.Data.listwallet);
        }

        public IActionResult ImportWallet()
        {
            return View();
        }
        public async Task <IActionResult> InforWallet(string address)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/InforWallet", _httpContextAccessor.HttpContext.Session.GetString("Token"), new getlistchildwalletbody { address = address});
            Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<Datainforwallet>>(response);
            return View(res.Data);
        }
        public IActionResult CreateWallet() 
        {
            return View();
        }
        public IActionResult CreateChildWallet(string address)
        {
            ViewData["address"] = address;
            return View();
        }

        public async Task<IActionResult> GetPrivateKey(string address,string path)
        {
            //var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            //var response = await CallAPI.Post(appsetting.API_URL + "wallet/Getprivatekey", token, new getprivatekeybody { phrase = phrase,path = path });
            //Debug.WriteLine(response);
            //var res = JsonConvert.DeserializeObject<ResultList<DataChildwallet>>(response);
            //Debug.WriteLine(res);
            ViewData["address"] = address; 
            ViewData["path"] = path;
            return View();
        }

        public async Task<IActionResult> ChildWallet(string address) //  danh sach wallet child
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/ListWalletChild", token, new getlistchildwalletbody { address = address });
            Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<Datalistwalletchild>>(response);
            Debug.WriteLine(res);
            return View(res.Data.listwalletchild);
        }

        [HttpGet] 
        public async Task<JsonResult> Create()
        {
            var response = await CallAPI.Get(appsetting.API_URL + "wallet/CreateWallet", _httpContextAccessor.HttpContext.Session.GetString("Token"));
            var res = JsonConvert.DeserializeObject<BaseResult<DataCreatewallet>>(response);
            return Json(res);
        }

        [HttpPost]
        public async Task<JsonResult> CreateChild(string phrase, int amount)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/CreateWalletchild", _httpContextAccessor.HttpContext.Session.GetString("Token"), new createchildwalletbody { phrase = phrase,amount = amount});
            Debug.WriteLine(response);

            var res = JsonConvert.DeserializeObject<ResultList<string>>(response);
            return Json(res);
        }

        [HttpPost]
        public async Task<JsonResult> PostGetPrivateKey(string phrase, string path,string address)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/Getprivatekey", token, new getprivatekeybody { phrase = phrase, path = path });
            Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<ResultList<DataChildwallet>>(response);
            if (res.Data[0].address != address)
            {
                return Json(new BaseResult<string>
                {
                    Data = null,
                    Success = false,
                    Message = "Không trùng địa chỉ ví với phrase!"
                });
            }
            else
            {
                return Json(res);
            }
            
        }
    }
    public class getlistchildwalletbody
    {
        public string address { get; set; }
    }
    public class createchildwalletbody
    {
        public string phrase { get; set; } 
        public int amount { get; set; }
    }
    public class getprivatekeybody
    {
        public string phrase { get; set; }
        public string path { get; set; }
    }
}
