#pragma checksum "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b21099bb173c4bf01011b329d51cebc42980b572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Payment_Views_Payment_Receipt), @"mvc.1.0.view", @"/Areas/Payment/Views/Payment/Receipt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Payment/Views/Payment/Receipt.cshtml", typeof(AspNetCore.Areas_Payment_Views_Payment_Receipt))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21099bb173c4bf01011b329d51cebc42980b572", @"/Areas/Payment/Views/Payment/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9ee2ee05adad2bf34424caccb0d8d26bdf24fe", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Payment_Views_Payment_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Store_Management_System.Areas.Payment.ViewModel.PaymentVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(116, 184, true);
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Payment Receipt</h1>\r\n\r\n<div class=\"container\" style=\"width: 20%;\">\r\n    <div class=\"form-group\">\r\n        <div class=\"input-group-addon\">\r\n            ");
            EndContext();
            BeginContext(300, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fee3a1c2d2d64366b9c32c025a85941c", async() => {
                BeginContext(370, 103, true);
                WriteLiteral("\r\n                <input placeholder=\"Search By Id\" class=\"form-control\" name=\"id\" />\r\n                ");
                EndContext();
                BeginContext(473, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5005dfb4aa854e92b51198c58dad895d", async() => {
                    BeginContext(558, 38, true);
                    WriteLiteral("<input type=\"submit\" value=\"Search\" />");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(600, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(621, 1392, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""container-fluid"" style=""width: 100%"">
    <div class=""row"">
        <div class=""col-xl-12"">
            <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
                <thead>
                    <tr>
                        <td style=""text-align:center; font-weight: bold;"">Product Name</td>
                        <td style=""text-align:center; font-weight: bold;"">Brand Name</td>
                        <td style=""text-align:center; font-weight: bold;"">Product Quantity</td>
                        <td style=""text-align:center; font-weight: bold;"">Product Price</td>
                        <td style=""text-align:center; font-weight: bold;"">Employee Name</td>
                        <td style=""text-align:center; font-weight: bold;"">Customer Name</td>
                        <td style=""text-align:center; font-weight: bold;"">Date</td>
                        <td style=""text-align:center; font-weight: bold;"">Payment Type<");
            WriteLiteral(@"/td>
                        <td style=""text-align:center; font-weight: bold;"">No of Items</td>
                        <td style=""text-align:center; font-weight: bold;"">Vat (%)</td>
                        <td style=""text-align:center; font-weight: bold;"">Vat Amount</td>
                        <td style=""text-align:center; font-weight: bold;"">Total Cost</td>
");
            EndContext();
            BeginContext(2104, 53, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n");
            EndContext();
#line 39 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                 foreach (var f in Model)
                {

#line default
#line hidden
            BeginContext(2219, 72, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2292, 14, false);
#line 42 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(2306, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2364, 12, false);
#line 43 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Brand_Name);

#line default
#line hidden
            EndContext();
            BeginContext(2376, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2434, 18, false);
#line 44 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Product_Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2452, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2510, 15, false);
#line 45 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Product_Price);

#line default
#line hidden
            EndContext();
            BeginContext(2525, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2583, 15, false);
#line 46 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Employee_Name);

#line default
#line hidden
            EndContext();
            BeginContext(2598, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2656, 15, false);
#line 47 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Customer_Name);

#line default
#line hidden
            EndContext();
            BeginContext(2671, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2729, 6, false);
#line 48 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2735, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2793, 14, false);
#line 49 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Payment_Type);

#line default
#line hidden
            EndContext();
            BeginContext(2807, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2865, 13, false);
#line 50 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.No_Of_Items);

#line default
#line hidden
            EndContext();
            BeginContext(2878, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2936, 19, false);
#line 51 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Percentage_Of_Vat);

#line default
#line hidden
            EndContext();
            BeginContext(2955, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(3013, 15, false);
#line 52 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Amount_Of_Vat);

#line default
#line hidden
            EndContext();
            BeginContext(3028, 57, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(3086, 12, false);
#line 53 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                                             Write(f.Total_Cost);

#line default
#line hidden
            EndContext();
            BeginContext(3098, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(3511, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 60 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\Receipt.cshtml"
                }

#line default
#line hidden
            BeginContext(3553, 56, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Store_Management_System.Areas.Payment.ViewModel.PaymentVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591