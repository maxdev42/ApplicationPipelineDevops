#pragma checksum "C:\Users\MaxDev42\source\repos\git\TestAppCI\TestAppCi.Client\Views\Home\TestApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c735024b8842e59062d0c2c7354230a5bc23012b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestApi), @"mvc.1.0.view", @"/Views/Home/TestApi.cshtml")]
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
#line 1 "C:\Users\MaxDev42\source\repos\git\TestAppCI\TestAppCi.Client\Views\_ViewImports.cshtml"
using TestAppCi.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MaxDev42\source\repos\git\TestAppCI\TestAppCi.Client\Views\_ViewImports.cshtml"
using TestAppCi.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c735024b8842e59062d0c2c7354230a5bc23012b", @"/Views/Home/TestApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97988187d8950d3c34078cc195519bf7f800b682", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MaxDev42\source\repos\git\TestAppCI\TestAppCi.Client\Views\Home\TestApi.cshtml"
  
    ViewData["Title"] = "Test API";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 4 "C:\Users\MaxDev42\source\repos\git\TestAppCI\TestAppCi.Client\Views\Home\TestApi.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

<br>
<div>
    <button type=""button"" class=""btn btn-info"" id=""btnLaunchTestApi"" onclick=""runTestApi();"">Launch Test API Process</button>
    <br><br>
    <section id=""about"">
        <div class=""border container"">
            <div class=""row"">
                <div class=""col-lg-8 mx-auto"">
                    <h2 id=""resultSectionTitle"">See results below :</h2>
                    <br><br>
                    <ul id=""content"">
                    </ul>
                </div>
            </div>
        </div>
    </section>
</div>


<style>
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
