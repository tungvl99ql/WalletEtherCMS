#pragma checksum "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4043a60e45db125a65d1220e4ca0a49070c71591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
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
#line 1 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
using CMSWallet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4043a60e45db125a65d1220e4ca0a49070c71591", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a91999e00b81552b61b5b3f4959eac38fc9f1d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
  
    List<DataTransaction> ls = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">History Transactions</h4>\r\n        <p class=\"card-description\">\r\n");
            WriteLiteral("        </p>\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr");
            BeginWriteAttribute("class", " class=\"", 396, "\"", 404, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <th style=""color:white"">TxHash</th>
                        <th style=""color:white"">From</th>
                        <th style=""color:white"">To</th>
                        <th style=""color:white"">Amount</th>
                        <th style=""color:white"">Token</th>
                        <th style=""color:white"">CreatedDate</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                      
                        foreach (var item in ls)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td");
            BeginWriteAttribute("onclick", " onclick=\"", 1020, "\"", 1050, 3);
            WriteAttributeValue("", 1030, "openTx(\'", 1030, 8, true);
#nullable restore
#line 29 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1038, item.hash, 1038, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1048, "\')", 1048, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:white\"> ");
#nullable restore
#line 29 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                                                                                   Write(Exten.Tinyhash(item.hash));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"color:white\">");
#nullable restore
#line 30 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                                                   Write(Exten.Tinyhash(item.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"color:white\">");
#nullable restore
#line 31 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                                                   Write(Exten.Tinyhash(item.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"color:white\">");
#nullable restore
#line 32 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                                                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"color:white\">");
#nullable restore
#line 33 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                                                   Write(item.Symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <img style=\"margin-left:5px\" src=\"https://s2.coinmarketcap.com/static/img/coins/64x64/825.png\"></td>\r\n                                <td style=\"color:white\">");
#nullable restore
#line 34 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                                                   Write(item.Createddate);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ></td>\r\n                            </tr>\r\n");
#nullable restore
#line 36 "E:\GITHUB\WalletEtherCMS\Views\Transaction\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<script>

    function openTx(hash){
        var url = ""https://testnet.bscscan.com/tx/"" + hash;
        console.log(""url=>"",url);
        window.open(url, '_blank').focus();
    }

</script>

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
