#pragma checksum "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dcbb88e09777fb0184ca6debb2903be7e9555fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WithDraw_FilterWallet), @"mvc.1.0.view", @"/Views/WithDraw/FilterWallet.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\_ViewImports.cshtml"
using CMSWallet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
using CMSWallet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcbb88e09777fb0184ca6debb2903be7e9555fe", @"/Views/WithDraw/FilterWallet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a91999e00b81552b61b5b3f4959eac38fc9f1d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WithDraw_FilterWallet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
  
    List<Walletvalue> ls = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Balance </h4>\r\n        <p class=\"card-description\">\r\n");
            WriteLiteral("        </p>\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr");
            BeginWriteAttribute("class", " class=\"", 380, "\"", 388, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <th style=\"color:white\">Wallet</th>\r\n                        <th style=\"color:white\">Wallet balance (");
#nullable restore
#line 17 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                                                           Write(ViewData["tokenname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</th>\r\n                        <th style=\"color:white\">BNB</th>\r\n                        <th style=\"color:white\">Option</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 23 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                      
                        foreach (var item in ls)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td style=\"color:white\"> ");
#nullable restore
#line 27 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                                                    Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td");
            BeginWriteAttribute("id", " id=\"", 992, "\"", 1010, 1);
#nullable restore
#line 28 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 997, item.address, 997, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:white\">");
#nullable restore
#line 28 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                                                                      Write(item.value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                                <td");
            BeginWriteAttribute("id", " id=\"", 1087, "\"", 1109, 2);
            WriteAttributeValue("", 1092, "bnb-", 1092, 4, true);
#nullable restore
#line 29 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 1096, item.address, 1096, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:white\">  </td>\r\n                                <td>\r\n                                    <a style=\"display: -webkit-inline-box;\" class=\"btn btn-light\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Withdraw to project wallet\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1353, "\"", 1403, 5);
            WriteAttributeValue("", 1363, "Withdrawone(", 1363, 12, true);
#nullable restore
#line 31 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 1375, item.value, 1375, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1386, ",\'", 1386, 2, true);
#nullable restore
#line 31 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 1388, item.address, 1388, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1401, "\')", 1401, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div");
            BeginWriteAttribute("id", " id=\"", 1451, "\"", 1477, 2);
            WriteAttributeValue("", 1456, "loading-", 1456, 8, true);
#nullable restore
#line 32 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 1464, item.address, 1464, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:15px;height:15px; display:none"" class=""spinner-border"" role=""status"">
                                        </div> Withdraw to project wallet
                                    </a>
                                    <a class=""btn btn-success"" data-toggle=""tooltip"" data-placement=""top"" title=""update balance""");
            BeginWriteAttribute("onclick", " onclick=\"", 1808, "\"", 1851, 3);
            WriteAttributeValue("", 1818, "UpdateBalanceOne(\'", 1818, 18, true);
#nullable restore
#line 35 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 1836, item.address, 1836, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1849, "\')", 1849, 2, true);
            EndWriteAttribute();
            WriteLiteral(">update balance</a>\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 39 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Button trigger modal -->\r\n");
            WriteLiteral(@"
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Noti</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h4 id=""content"">
                    AHIHI
                </h4>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button onclick=""viewTX()"" style=""display: none;"" id=""viewtx"" type=""button"" class=""btn btn-primary"">View tx</button>
            </div>
        </div>
    </div>
</div>

<d");
            WriteLiteral("iv style=\"margin-top:20px\">\r\n");
            WriteLiteral("\r\n    <div class=\"template-demo\">\r\n");
#nullable restore
#line 82 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
         if (int.Parse(ViewData["page"].ToString()) > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 3541, "\"", 3730, 1);
#nullable restore
#line 84 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 3548, Url.Action("FilterWallet","WithDraw",new {address= ViewData["address"],tokenname= ViewData["tokenname"] ,value= ViewData["value"],page = int.Parse(ViewData["page"].ToString()) -1 }), 3548, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mdi mdi-arrow-left\"></a>\r\n");
#nullable restore
#line 85 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"mdi mdi-arrow-left\"></a>\r\n");
#nullable restore
#line 89 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 3870, "\"", 3878, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
               Write(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3913, "\"", 4102, 1);
#nullable restore
#line 91 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
WriteAttributeValue("", 3920, Url.Action("FilterWallet","WithDraw",new {address= ViewData["address"] ,tokenname= ViewData["tokenname"] ,value= ViewData["value"],page = int.Parse(ViewData["page"].ToString())+1 }), 3920, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""mdi mdi-arrow-right""></a>
    </div>
</div>
<script>
    var txhash = """";
    function Withdrawone(_value, _address) {

        document.getElementById(""loading-"" + _address).style.display = ""block"";

        var myModal = document.getElementById(""exampleModal"");
        var modal = new bootstrap.Modal(myModal);

        var content = document.getElementById(""content"");



        var tokenname = `");
#nullable restore
#line 107 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                    Write(Html.Raw(ViewData["tokenname"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("`;\r\n\r\n        let param = {\r\n            \'address\': _address,\r\n            \'value\': _value,\r\n            \'tokenname\': tokenname\r\n        };\r\n\r\n        $.ajax({\r\n            type: \'POST\',\r\n            url: \"");
#nullable restore
#line 117 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
             Write(Url.Action("WithdrawOne"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: param,
            async: true,
            success: function (data) {
                document.getElementById(""loading-"" + _address).style.display = ""none"";
                console.log(""data"", data)
                if (data.success) {
                    content.innerHTML = data.data.message;
                    document.getElementById(""viewtx"").style.display = ""block"";
                    txhash = data.data.txhash;
                    modal.show();

                } else {
                    content.innerHTML = data.data.message;
                    document.getElementById(""viewtx"").style.display = ""none"";
                    modal.show();

                }
            }
        });
    }

    function viewTX() {
        var URL = ""https://testnet.bscscan.com/tx/"" + txhash;
        window.open(URL, '_blank');
    }


    function UpdateBalanceOne(_address) {


        var tokenname = `");
#nullable restore
#line 148 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
                    Write(Html.Raw(ViewData["tokenname"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("`;\r\n\r\n        let param = {\r\n            \'address\': _address,\r\n            \'tokenname\': tokenname\r\n        };\r\n\r\n        $.ajax({\r\n            type: \'POST\',\r\n            url: \"");
#nullable restore
#line 157 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
             Write(Url.Action("UpdateBalance"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: param,
            async: true,
            success: function (data) {
                console.log(""data"", data)
                if (data.success) {
                    alert(""cập nhật số dư thành công!"");
                    var contentValue = document.getElementById(data.data.address);
                    contentValue.innerHTML = data.data.balance + "" $"";
                } else {
                    alert(data.data.message);

                }
            }
        });
    }

    document.addEventListener(""DOMContentLoaded"", async function () {
        var web3 = new Web3(""https://data-seed-prebsc-1-s1.binance.org:8545/"");
        var a = await web3.eth.getBalance(""0x2796e737c79156e26B75C63C7aF1691294f0Bf45"", function (error, result) {
            if (!error) {
                console.log(""Balance =>"", web3.utils.fromWei(result, 'ether'));
            } else {
                console.error(error);
            }
        });
        console.log(a);
        //awa");
            WriteLiteral("it getBalance();\r\n\r\n    });\r\n\r\n    async function getBalance() {\r\n        var list =  ");
#nullable restore
#line 189 "D:\PROJECT\NodeJs_project\WalletEtherCMS\Views\WithDraw\FilterWallet.cshtml"
               Write(Html.Raw(Json.Serialize(ls)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        for (var i = 0; i < list.length; i++) {
            var classId = ""bnb-"" + list[i].address;
            console.log(classId)
             //web3.eth.getBalance(list[i].address, function (error, result) {
             //   if (!error) {
             //       document.getElementById(classId).innerHTML = web3.utils.fromWei(result, 'ether') + ""BNB"";
             //   }
             //});
            var a = await web3.eth.getBalance(list[i].address);
            console.log(a);
        }
    }
</script>
<script src=""/js/web3.min.js""></script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
