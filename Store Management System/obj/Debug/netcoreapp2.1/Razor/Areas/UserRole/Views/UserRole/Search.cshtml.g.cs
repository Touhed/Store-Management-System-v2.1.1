#pragma checksum "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\UserRole\Views\UserRole\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "804752bef53053076d9d575d468611dcd89899f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserRole_Views_UserRole_Search), @"mvc.1.0.view", @"/Areas/UserRole/Views/UserRole/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserRole/Views/UserRole/Search.cshtml", typeof(AspNetCore.Areas_UserRole_Views_UserRole_Search))]
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
#line 1 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\_ViewImports.cshtml"
using Store_Management_System;

#line default
#line hidden
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\_ViewImports.cshtml"
using Store_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804752bef53053076d9d575d468611dcd89899f4", @"/Areas/UserRole/Views/UserRole/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9ee2ee05adad2bf34424caccb0d8d26bdf24fe", @"/Areas/_ViewImports.cshtml")]
    public class Areas_UserRole_Views_UserRole_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store_Management_System.Areas.UserRole.Models.UserRole>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\UserRole\Views\UserRole\Search.cshtml"
  
    ViewData["Title"] = "UserRole Details";

#line default
#line hidden
            BeginContext(115, 472, true);
            WriteLiteral(@"
<h1 style=""text-align:center"">User Role Details Information</h1>

<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">User Id</td>
                <td style=""text-align:center; font-weight: bold;"">User Type</td>
            </tr>
        </thead>

        <tr>
            <td style=""text-align:center"">");
            EndContext();
            BeginContext(588, 12, false);
#line 18 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\UserRole\Views\UserRole\Search.cshtml"
                                     Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(600, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(650, 14, false);
#line 19 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\UserRole\Views\UserRole\Search.cshtml"
                                     Write(Model.UserType);

#line default
#line hidden
            EndContext();
            BeginContext(664, 42, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store_Management_System.Areas.UserRole.Models.UserRole> Html { get; private set; }
    }
}
#pragma warning restore 1591