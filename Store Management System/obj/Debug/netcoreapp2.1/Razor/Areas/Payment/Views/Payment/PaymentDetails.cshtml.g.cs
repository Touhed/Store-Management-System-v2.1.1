#pragma checksum "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9d1f253798b8fab71272966c36f4c2d011eb3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Payment_Views_Payment_PaymentDetails), @"mvc.1.0.view", @"/Areas/Payment/Views/Payment/PaymentDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Payment/Views/Payment/PaymentDetails.cshtml", typeof(AspNetCore.Areas_Payment_Views_Payment_PaymentDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9d1f253798b8fab71272966c36f4c2d011eb3e", @"/Areas/Payment/Views/Payment/PaymentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9ee2ee05adad2bf34424caccb0d8d26bdf24fe", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Payment_Views_Payment_PaymentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store_Management_System.Areas.Payment.Models.Payment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(105, 1106, true);
            WriteLiteral(@"
<h1 style=""text-align:center"">Payment Information</h1>

<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Payment Id</td>
                <td style=""text-align:center; font-weight: bold;"">Date</td>
                <td style=""text-align:center; font-weight: bold;"">Payment Type</td>
                <td style=""text-align:center; font-weight: bold;"">No of Items</td>
                <td style=""text-align:center; font-weight: bold;"">Vat (%)</td>
                <td style=""text-align:center; font-weight: bold;"">Vat Amount</td>
                <td style=""text-align:center; font-weight: bold;"">Total Cost</td>
                <td style=""text-align:center; font-weight: bold;"">P_Id</td>
                <td style=""text-align:center; font-weight: bold;"">E_Id</td>
                <td style=""text-align:center; font-weight: bold;"">C_Id</td>
            <");
            WriteLiteral("/tr>\r\n        </thead>\r\n\r\n        <tr>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1212, 16, false);
#line 26 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.Payment_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1278, 10, false);
#line 27 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1338, 18, false);
#line 28 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.Payment_Type);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1406, 17, false);
#line 29 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.No_Of_Items);

#line default
#line hidden
            EndContext();
            BeginContext(1423, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1473, 23, false);
#line 30 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.Percentage_Of_Vat);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1546, 19, false);
#line 31 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.Amount_Of_Vat);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1615, 16, false);
#line 32 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.Total_Cost);

#line default
#line hidden
            EndContext();
            BeginContext(1631, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1681, 10, false);
#line 33 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.P_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1691, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1741, 10, false);
#line 34 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.E_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1751, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1801, 10, false);
#line 35 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\PaymentDetails.cshtml"
                                     Write(Model.C_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1811, 42, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store_Management_System.Areas.Payment.Models.Payment> Html { get; private set; }
    }
}
#pragma warning restore 1591
