#pragma checksum "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e5280dbafd9c0f9ca674dadd54541f7b261bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Employee_EmployeeDetails), @"mvc.1.0.view", @"/Areas/Employee/Views/Employee/EmployeeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Employee/EmployeeDetails.cshtml", typeof(AspNetCore.Areas_Employee_Views_Employee_EmployeeDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e5280dbafd9c0f9ca674dadd54541f7b261bb1", @"/Areas/Employee/Views/Employee/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9ee2ee05adad2bf34424caccb0d8d26bdf24fe", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Employee_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store_Management_System.Areas.Employee.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml"
  
    //Layout = "_LayoutForEmployee";
    ViewData["Title"] = "Employee";

#line default
#line hidden
            BeginContext(146, 708, true);
            WriteLiteral(@"
<h1 style=""text-align:center"">Employee Information</h1>

<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Employee Id</td>
                <td style=""text-align:center; font-weight: bold;"">Name</td>
                <td style=""text-align:center; font-weight: bold;"">Address</td>
                <td style=""text-align:center; font-weight: bold;"">Contact</td>
                <td style=""text-align:center; font-weight: bold;"">Email</td>
            </tr>
        </thead>

            <tr>
                <td style=""text-align:center"">");
            EndContext();
            BeginContext(855, 17, false);
#line 22 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml"
                                         Write(Model.Employee_Id);

#line default
#line hidden
            EndContext();
            BeginContext(872, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(926, 19, false);
#line 23 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml"
                                         Write(Model.Employee_Name);

#line default
#line hidden
            EndContext();
            BeginContext(945, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(999, 22, false);
#line 24 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml"
                                         Write(Model.Employee_Address);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1075, 22, false);
#line 25 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml"
                                         Write(Model.Employee_Contact);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1151, 20, false);
#line 26 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Employee\Views\Employee\EmployeeDetails.cshtml"
                                         Write(Model.Employee_Email);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 46, true);
            WriteLiteral("</td>\r\n            </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store_Management_System.Areas.Employee.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591