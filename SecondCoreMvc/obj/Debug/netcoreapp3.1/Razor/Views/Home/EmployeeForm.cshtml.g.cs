#pragma checksum "C:\Users\semre\source\repos\SecondCoreMvc\SecondCoreMvc\Views\Home\EmployeeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5605d113602e7369a5a0f9fb368fa706e0594e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeForm), @"mvc.1.0.view", @"/Views/Home/EmployeeForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5605d113602e7369a5a0f9fb368fa706e0594e6", @"/Views/Home/EmployeeForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e35f7e043cbbcf7d9f0f7aebe929f18aca66773", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\semre\source\repos\SecondCoreMvc\SecondCoreMvc\Views\Home\EmployeeForm.cshtml"
 using (Html.BeginForm("Index9","Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b> Key:</b>\r\n");
#nullable restore
#line 4 "C:\Users\semre\source\repos\SecondCoreMvc\SecondCoreMvc\Views\Home\EmployeeForm.cshtml"
Write(Html.TextBox("key"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<input  type=\"submit\" value=\"Search\"/ >\r\n");
#nullable restore
#line 6 "C:\Users\semre\source\repos\SecondCoreMvc\SecondCoreMvc\Views\Home\EmployeeForm.cshtml"
}

#line default
#line hidden
#nullable disable
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
