#pragma checksum "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd60fccb3a245acc0ec78b09612b61f033aa0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallet_GetPrivateKey), @"mvc.1.0.view", @"/Views/Wallet/GetPrivateKey.cshtml")]
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
#line 1 "E:\GITHUB\WalletEtherCMS\Views\_ViewImports.cshtml"
using CMSWallet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GITHUB\WalletEtherCMS\Views\_ViewImports.cshtml"
using CMSWallet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd60fccb3a245acc0ec78b09612b61f033aa0bb", @"/Views/Wallet/GetPrivateKey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a91999e00b81552b61b5b3f4959eac38fc9f1d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Wallet_GetPrivateKey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml"
  
    string addressP = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-6 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Get private key Wallet</h4>
            <div class=""form-group"">
                <label for=""exampleInputUsername1"">Address</label>
                <input type=""text"" class=""form-control"" id=""address"" style=""color:black"" disabled");
            BeginWriteAttribute("value", " value=\"", 410, "\"", 438, 1);
#nullable restore
#line 10 "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml"
WriteAttributeValue("", 418, ViewData["address"], 418, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleInputUsername1\">Path</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"path\" style=\"color:black\" disabled");
            BeginWriteAttribute("value", " value=\"", 659, "\"", 684, 1);
#nullable restore
#line 14 "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml"
WriteAttributeValue("", 667, ViewData["path"], 667, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Phrase</label>
                <input type=""text"" class=""form-control"" id=""phrase"" placeholder="". . ."">
            </div>
            

            <button onclick=""Create()"" class=""btn btn-primary mr-2"">Get key </button>
            <button class=""btn btn-dark"">Cancel</button>
        </div>
    </div>
</div>

<script>
    function Create() {
        //var Url = ");
#nullable restore
#line 30 "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml"
               Write(Html.Raw(Json.Serialize(ViewData["address"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        let phrase = document.getElementById(""phrase"").value;
        let path = document.getElementById(""path"").value;
        let address = document.getElementById(""address"").value;

        let param = {
            'phrase': phrase,
            'path': path,
            'address': address
        };

        $.ajax({
            type: 'POST',
            url: """);
#nullable restore
#line 43 "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml"
             Write(Url.Action("PostGetPrivateKey"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            data: param,\r\n            async: true,\r\n            success: function (data) {\r\n                //console.log(\"data\", data.data[0].privatekey)\r\n                if (data.success) {\r\n                    //var direct = ");
#nullable restore
#line 49 "E:\GITHUB\WalletEtherCMS\Views\Wallet\GetPrivateKey.cshtml"
                              Write(ViewData["address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                    //var url = ""/Wallet/ChildWallet?address="" + Url;
                    //location.href = url;
                    
                    alert(""Privatkey=> ""+ data.data[0].privatekey)
                } else {
                    alert(data.message)
                }
            }
        });
    }
</script>");
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
