using CMSWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CMSWallet.Controllers
{
    public class TransactionController : Controller
    {
        private readonly AppSettings appsetting;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TransactionController(IOptions<AppSettings> options, IHttpContextAccessor httpContextAccessor)
        {
            appsetting = options.Value;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> Index()
        {
           
            var response = await CallAPI.Get(appsetting.API_URL + "transaction/ListWalletTx", _httpContextAccessor.HttpContext.Session.GetString("Token")); ;
            Debug.WriteLine(response);

            var res = JsonConvert.DeserializeObject<ResultList<ListAddressTransaction>>(response);
            return View("index2",res.Data);
        }


        public async Task<IActionResult> LsTx(string address, int page = 1)
        {
            
            var response = await CallAPI.Post(appsetting.API_URL + "transaction/ListTx", _httpContextAccessor.HttpContext.Session.GetString("Token"),new lstxbody { address = address ,page = page }) ;
            Debug.WriteLine(response);

            var res = JsonConvert.DeserializeObject<BaseResult<Datatransaction1>>(response);
            ViewData["address"] = address;
            ViewData["page"] = page;

            return View("Index", res.Data.txs);
        }

        [HttpPost]
        public async Task<JsonResult> Callbackapi(string hash)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/CallBackApi", _httpContextAccessor.HttpContext.Session.GetString("Token"), new callbackapinbody { txhash = hash });
            var res = JsonConvert.DeserializeObject<BaseResult<string>>(response);
            return Json(res);
        }
    }

    public class gettransactionbody
    {
        public int Page { get; set; }
    }

    public class callbackapinbody
    {
        public string txhash { get; set; }
    }
    public class lstxbody
    {
        public string address { get; set; }
        public int page { get; set; }
    }
}
