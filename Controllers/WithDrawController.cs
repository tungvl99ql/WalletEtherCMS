using CMSWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CMSWallet.Controllers
{
    public class WithDrawController : Controller
    {
        private readonly AppSettings appsetting;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public WithDrawController(IOptions<AppSettings> options, IHttpContextAccessor httpContextAccessor)
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

        public async Task<IActionResult> FilterWallet(string address, string tokenname, int value, int page = 1)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/FilterWallet", token, new filterwalletbody { address = address, token = tokenname, value = value, page = page });
            var res = JsonConvert.DeserializeObject<ResultList<Walletvalue>>(response);
            ViewData["tokenname"] = tokenname;
            return View(res.Data);
        }

        public async Task<IActionResult> FilterWalletView(string address)
        {
            ViewData["address"] = address;
            ViewData["page"] = 1;
            return View();
        }

        public async Task<IActionResult> ListWalletTX()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "transaction/GetWithDrawHistoryListWallet", token, new filterwalletbody { });
            var res = JsonConvert.DeserializeObject<ResultList<listwallethistorywithdraw>>(response);
            return View(res.Data);
        }

        public async Task<IActionResult> HistoryWalletTX(string address, int page =1)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "transaction/GetWithDrawHistoryWallet", token, new withdrawHistorybody { address = address,page = page});
            var res = JsonConvert.DeserializeObject<ResultList<historywithdraw>>(response);
            ViewData["page"] = page;
            ViewData["address"] = address;
            return View(res.Data);
        }

        [HttpPost]
        public async Task<JsonResult> WithdrawOne(string address,double value,string tokenname)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/WithDrawOne", _httpContextAccessor.HttpContext.Session.GetString("Token"), new withdrawonebody { address = address,token = tokenname, value = value });
            var res = JsonConvert.DeserializeObject<BaseResult<Withdrawone>>(response);
            return Json(res);
        }

        [HttpPost]
        public async Task<JsonResult> UpdateBalance(string address,string tokenname)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/UpdateBalanceOne", _httpContextAccessor.HttpContext.Session.GetString("Token"), new withdrawonebody { address = address, token = tokenname, value = value });
            var res = JsonConvert.DeserializeObject<BaseResult<Withdrawone>>(response);
            return Json(res);
        }
    }
    public class filterwalletbody
    {
        public string address { get; set; }
        public string token { get; set; }
        public int value { get; set; }
        public int page { get; set; }
    }

    public class withdrawonebody
    {
        public string address { get; set; }
        public string token { get; set; }
        public double value { get; set; }
    }
    public class withdrawHistorybody
    {
        public string address { get; set; }
        public int page { get; set; }
    }
}


