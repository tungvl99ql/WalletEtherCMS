#pragma checksum "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "417aae094e2a58ad88f352af5751e864cf606d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallet_HisTransfer), @"mvc.1.0.view", @"/Views/Wallet/HisTransfer.cshtml")]
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
#line 2 "E:\GITHUB\WalletEtherCMS\Views\_ViewImports.cshtml"
using CMSWallet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
using CMSWallet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"417aae094e2a58ad88f352af5751e864cf606d9e", @"/Views/Wallet/HisTransfer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a91999e00b81552b61b5b3f4959eac38fc9f1d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Wallet_HisTransfer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
  
    List<HistransferTo> ls = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">History Transfer</h4>\r\n        <p class=\"card-description\">\r\n");
            WriteLiteral("        </p>\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr");
            BeginWriteAttribute("class", " class=\"", 390, "\"", 398, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <th style=""color:white"">TxHash</th>
                        <th style=""color:white"">From</th>
                        <th style=""color:white"">To</th>
                        <th style=""color:white"">Value</th>
                        <th style=""color:white"">Token</th>
                        <th style=""color:white"">Status</th>
                        <th style=""color:white"">Message</th>
                        <th style=""color:white"">User</th>
                        <th style=""color:white"">Manager</th>
                        <th style=""color:white"">CreatedDate</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 30 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                      
                        foreach (var item in ls)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"");
            BeginWriteAttribute("href", " href=\"", 1325, "\"", 1367, 2);
            WriteAttributeValue("", 1332, "https://bscscan.com/tx/", 1332, 23, true);
#nullable restore
#line 34 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
WriteAttributeValue("", 1355, item.txhash, 1355, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 34 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                                                                            Write(Exten.Tinyhash(item.txhash));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"");
            BeginWriteAttribute("href", " href=\"", 1525, "\"", 1573, 2);
            WriteAttributeValue("", 1532, "https://bscscan.com/address/", 1532, 28, true);
#nullable restore
#line 35 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
WriteAttributeValue("", 1560, item.address, 1560, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 35 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                                                                                  Write(Exten.Tinyhash(item.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"");
            BeginWriteAttribute("href", " href=\"", 1732, "\"", 1775, 2);
            WriteAttributeValue("", 1739, "https://bscscan.com/address/", 1739, 28, true);
#nullable restore
#line 36 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
WriteAttributeValue("", 1767, item.to, 1767, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 36 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                                                                             Write(Exten.Tinyhash(item.to));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"> ");
#nullable restore
#line 37 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                  Write(item.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 38 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                 if (item.token == "USDT_TESTNET" || item.token == "USDT")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:white\">");
#nullable restore
#line 40 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                       Write(item.token);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <img style=\"margin-left:5px\" src=\"https://s2.coinmarketcap.com/static/img/coins/64x64/825.png\"></td>\r\n");
#nullable restore
#line 41 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                }
                                else if (item.token == "USDC")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:white\">");
#nullable restore
#line 44 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                       Write(item.token);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <img style=\"margin-left:5px\" src=\"https://s2.coinmarketcap.com/static/img/coins/64x64/3408.png\"></td>\r\n");
#nullable restore
#line 45 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                }
                                else if (item.token == "BUSD")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:white\">");
#nullable restore
#line 48 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                       Write(item.token);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <img style=\"margin-left:5px\" src=\"https://s2.coinmarketcap.com/static/img/coins/64x64/4687.png\"></td>\r\n");
#nullable restore
#line 49 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                }
                                else if (item.token == "DAI")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:white\">");
#nullable restore
#line 52 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                       Write(item.token);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <img style=\"margin-left:5px\" src=\"https://s2.coinmarketcap.com/static/img/coins/64x64/4943.png\"></td>\r\n");
#nullable restore
#line 53 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                 if (item.status)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td> <a class=\"btn btn-info\"> Success </a></td>\r\n");
#nullable restore
#line 57 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a class=\"btn btn-success\"> Faile  </a></td>\r\n");
#nullable restore
#line 62 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"> ");
#nullable restore
#line 63 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                  Write(item.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"> ");
#nullable restore
#line 64 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                  Write(item.user);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"> ");
#nullable restore
#line 65 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                  Write(item.manager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td style=\"color:white\"> <a style=\"text-decoration: none;color:white\"> ");
#nullable restore
#line 66 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                                                                                                  Write(item.createddate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 68 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div style=\"margin-top:20px\">\r\n");
            WriteLiteral("\r\n    <div class=\"template-demo\">\r\n");
#nullable restore
#line 83 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
         if (int.Parse(ViewData["page"].ToString()) > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 4554, "\"", 4682, 1);
#nullable restore
#line 85 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
WriteAttributeValue("", 4561, Url.Action("HisTransfer","Wallet",new {address= ViewData["address"] ,page = int.Parse(ViewData["page"].ToString()) -1 }), 4561, 121, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mdi mdi-arrow-left\"></a>\r\n");
#nullable restore
#line 86 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"mdi mdi-arrow-left\"></a>\r\n");
#nullable restore
#line 90 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 4822, "\"", 4830, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
               Write(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4865, "\"", 4992, 1);
#nullable restore
#line 92 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
WriteAttributeValue("", 4872, Url.Action("HisTransfer","Wallet",new {address= ViewData["address"] ,page = int.Parse(ViewData["page"].ToString())+1 }), 4872, 120, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mdi mdi-arrow-right\"></a>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n<script>\r\n    function NextorPrePage(v) {\r\n        var address = ");
#nullable restore
#line 101 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewData["address"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        var page = ");
#nullable restore
#line 102 "E:\GITHUB\WalletEtherCMS\Views\Wallet\HisTransfer.cshtml"
              Write(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        if (v == -1) {\r\n            console.log(\"pre page : \", address, page);\r\n\r\n        } else {\r\n            console.log(\"next page: \", address, page);\r\n        }\r\n    }\r\n</script>\r\n\r\n\r\n\r\n");
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
