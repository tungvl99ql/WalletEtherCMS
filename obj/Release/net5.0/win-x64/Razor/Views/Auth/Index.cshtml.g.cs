#pragma checksum "E:\GITHUB\WalletEtherCMS\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "144d914df09af4f7ab4274e8a7594809cce933e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144d914df09af4f7ab4274e8a7594809cce933e9", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a91999e00b81552b61b5b3f4959eac38fc9f1d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GITHUB\WalletEtherCMS\Views\Auth\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144d914df09af4f7ab4274e8a7594809cce933e93354", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Corona Admin</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""../../assets/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""../../assets/vendors/css/vendor.bundle.base.css"">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- Layout styles -->
    <link rel=""stylesheet"" href=""../../assets/css/style.css"">
    <!-- End layout styles -->
    <link rel=""shortcut icon"" href=""../../assets/images/favicon.png"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144d914df09af4f7ab4274e8a7594809cce933e95081", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <div class=""container-fluid page-body-wrapper full-page-wrapper"">
            <div class=""row w-100 m-0"">
                <div class=""content-wrapper full-page-wrapper d-flex align-items-center auth login-bg"">
                    <div class=""card col-lg-4 mx-auto"">
                        <div class=""card-body px-5 py-5"">
                            <h3 class=""card-title text-left mb-3"">Login</h3>
                                <div class=""form-group"">
                                    <label>Username *</label>
                                    <input id=""username"" type=""text"" class=""form-control p_input"">
                                </div>
                                <div class=""form-group"">
                                    <label>Password *</label>
                                    <input id=""password"" type=""text"" class=""form-control p_input"">
                                </div>
                                <div class=""for");
                WriteLiteral(@"m-group d-flex align-items-center justify-content-between"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
                                            <input type=""checkbox"" class=""form-check-input""> Remember me
                                        </label>
                                    </div>
                                    <a href=""#"" class=""forgot-pass"">Forgot password</a>
                                </div>
                                <div class=""text-center"">
                                    <button onclick=""Login()"" class=""btn btn-primary btn-block enter-btn"">Login</button>
                                </div>
                                <p class=""sign-up"">Don't have an Account?<a href=""#""> Sign Up</a></p>
                            
                        </div>
                    </div>
                </div>
                <!-- content-wrapper ends -->
            <");
                WriteLiteral(@"/div>
            <!-- row ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""../../assets/vendors/js/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src=""../../assets/js/off-canvas.js""></script>
    <script src=""../../assets/js/hoverable-collapse.js""></script>
    <script src=""../../assets/js/misc.js""></script>
    <script src=""../../assets/js/settings.js""></script>
    <script src=""../../assets/js/todolist.js""></script>
    <!-- endinject -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>

    function Login() {
     let username = document.getElementById(""username"").value;
        let password = document.getElementById(""password"").value;
        console.log(""username"", username)
        console.log(""password"", password)
        let param = {
            'username': username,
            'password': password
        };

         $.ajax({
            type: 'POST',
            url: """);
#nullable restore
#line 92 "E:\GITHUB\WalletEtherCMS\Views\Auth\Index.cshtml"
             Write(Url.Action("Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: param,
            async: true,
            success: function (data) {
                console.log(""data"", data)
                var datajson = JSON.parse(data);
                if (datajson.Success) {
                    location.href = '/';
                }else{
                    alert(datajson.Message)
                }
            }});
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
