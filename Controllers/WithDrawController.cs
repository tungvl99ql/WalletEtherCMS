using CMSWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
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
    }
    public class filterwalletbody
    {
        public string address { get; set; }
        public string token { get; set; }
        public int value { get; set; }
        public int page { get; set; }
    }
}


