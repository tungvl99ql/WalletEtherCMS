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
            var response = await CallAPI.Post(appsetting.API_URL + "transaction/GetTransaction", _httpContextAccessor.HttpContext.Session.GetString("Token"), new gettransactionbody { Page = 1 }); ;
            Debug.WriteLine(response);

            var res = JsonConvert.DeserializeObject<ResultList<DataTransaction>>(response);
            //return Json(res);
            return View(res.Data);
        }
    }

    public class gettransactionbody
    {
        public int Page { get; set; }
    }
}
