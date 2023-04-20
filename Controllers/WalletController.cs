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
            ViewData["role"] = _httpContextAccessor.HttpContext.Session.GetString("Role");
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Get(appsetting.API_URL + "wallet/ListWallet", token);
            //Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<Datalistwallet>>(response);
            //Debug.WriteLine(res);
            return View(res.Data.listwallet);
        }

        // rút từ ví project về 1 ví khác
        public async Task<IActionResult> TransferOther(string address)
        {
            ViewData["address"] = address;
            return View();
        }

        public IActionResult ImportWallet()
        {
            return View();
        }
        public async Task<IActionResult> ApiCallbackWallet(string address)
        {

            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/GetApiCallback", token, new geturlcallbackbody { address = address});
            //Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<DataApicallback>>(response);
            return View(res.Data);
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

        public IActionResult DeleteWallet(string address)
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

        public async Task<IActionResult> ChildWallet(string address,int page = 1) //  danh sach wallet child
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/ListWalletChild", token, new getlistchildwalletbody { address = address,page = page });
            Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<Datalistwalletchild>>(response);
            Debug.WriteLine(res);
            ViewData["address"] = address;
            ViewData["page"] = page;
            return View(res.Data.listwalletchild);
        }

        public async Task<IActionResult> RequestTransfer(string address, int page = 1) //  danh sach lenh chuyen
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/ListTransferrquest", token, new getlistchildwalletbody { address = address, page = page });
            
            var res = JsonConvert.DeserializeObject<ResultList<DataListRequestTransfer>>(response);
            ViewData["address"] = address;
            ViewData["page"] = page;
            return View(res.Data);
        }

        public async Task<IActionResult> HisTransfer(string address, int page = 1) //  lich su chuyen token sang tk khac
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/HisTransferother", token, new getlistchildwalletbody { address = address, page = page });

            var res = JsonConvert.DeserializeObject<ResultList<HistransferTo>>(response);
            ViewData["address"] = address;
            ViewData["page"] = page;
            return View(res.Data);
        }

        [HttpPost]
        public async Task<JsonResult> Accept_reject_requesttransfer(string id,string action)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/AcceptOrRejectTransferrquest", _httpContextAccessor.HttpContext.Session.GetString("Token"),new acceptorrejectbody
            {
                id = id,
                action = action
            });
            var res = JsonConvert.DeserializeObject<BaseResult<DataRes>>(response);
            return Json(res);
        }


        [HttpPost]
        public async Task<JsonResult> Transferto(string address,string password,string toaddress,string value,string tokenname)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/TransferTo", _httpContextAccessor.HttpContext.Session.GetString("Token"), new transfertoBody { 
                address = address,
                password = password,
                recipientaddress = toaddress,
                value = value,
                tokenName = tokenname
            });
            var res = JsonConvert.DeserializeObject<BaseResult<Withdrawone>>(response);
            return Json(res);
        }

        [HttpPost] 
        public async Task<JsonResult> Create(string projectname)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/CreateWallet", _httpContextAccessor.HttpContext.Session.GetString("Token"), new newwallet { projectname = projectname });
            var res = JsonConvert.DeserializeObject<BaseResult<DataCreatewallet>>(response);
            return Json(res);
        }

        [HttpPost]
        public async Task<JsonResult> PostDeleteProject(string address,string pass,string name)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/DeleteWallet", _httpContextAccessor.HttpContext.Session.GetString("Token"), new deleteProject { address = address,password = pass,projectname = name });
            var res = JsonConvert.DeserializeObject<BaseResult<DataCreatewallet>>(response);
            return Json(res);
        }

        [HttpPost]
        public async Task<JsonResult> CreateChild(string phrase, string address)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/CreateWalletchild", _httpContextAccessor.HttpContext.Session.GetString("Token"), new createchildwalletbody { phrase = phrase,address = address });
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
        [HttpPost]
        public async Task<JsonResult> PostImportWallet(string phrase,string projectname)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/ImportWallet", token, new importwalletbody { phrase = phrase, projectname  = projectname });
            Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<DataCreatewallet>>(response);
            return Json(res);

        }

        [HttpPost]
        public async Task<JsonResult> SetCallback(string projectname, string address, string url,string body,string idtelegram)
        {
            var response = await CallAPI.Post(appsetting.API_URL + "wallet/SetApiCallback", _httpContextAccessor.HttpContext.Session.GetString("Token"), new DataApicallback { address = address.Trim(),urlcallback = url,bodycontent = body,telegram = idtelegram,projectname = projectname });
            Debug.WriteLine(response);
            var res = JsonConvert.DeserializeObject<BaseResult<DataCreatewallet>>(response);
            return Json(res);
        }
    }
    public class getlistchildwalletbody
    {
        public string address { get; set; }
        public int page { get; set; }
    }
    public class createchildwalletbody
    {
        public string phrase { get; set; } 
        public string address { get; set; }
    }
    public class getprivatekeybody
    {
        public string phrase { get; set; }
        public string path { get; set; }
    }
    public class acceptorrejectbody
    {
        public string id { get; set; }
        public string action { get; set; }
    }
    public class importwalletbody
    {
        public string phrase { get; set; }
        public string projectname { get; set; }
    }

    public class geturlcallbackbody
    {
        public string address { get; set; }
    }
    public class newwallet
    {
        public string projectname { get; set; }
    }

    public class deleteProject
    {
        public string address { get; set; }
        public string password { get; set; }
        public string projectname { get; set; }
    }

    public class transfertoBody
    {
        public string address { get; set; }
        public string password { get; set; }
        public string recipientaddress { get; set; }
        public string tokenName { get; set; }
        public string value { get; set; }
        
    }
}
