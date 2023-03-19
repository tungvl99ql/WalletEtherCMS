using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CMSWallet.Controllers
{
    public class APIController : Controller
    {
        [HttpPost, Route("Api/test")]
        public async Task<JsonResult> test([FromBody] testbody _testbody)
        {
            //Debug.WriteLine("hash=>", ts.hash);
            //Debug.WriteLine("value=>", ts.value); 
            //Debug.WriteLine("address=>", ts.address);

            return Json("OK");
        }
    }
    public class testbody
    {
        public string hash { get; set; }
        public string address { get; set; }
        public double value { get; set; }
    }
}
