#pragma checksum "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff294afab8ea6784feb58afff76777a852a7213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Payment_Views_Payment_ViewPaymentList), @"mvc.1.0.view", @"/Areas/Payment/Views/Payment/ViewPaymentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Payment/Views/Payment/ViewPaymentList.cshtml", typeof(AspNetCore.Areas_Payment_Views_Payment_ViewPaymentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff294afab8ea6784feb58afff76777a852a7213", @"/Areas/Payment/Views/Payment/ViewPaymentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9ee2ee05adad2bf34424caccb0d8d26bdf24fe", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Payment_Views_Payment_ViewPaymentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Store_Management_System.Areas.Payment.Models.Payment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(111, 192, true);
            WriteLiteral("\r\n    <h1 style=\"text-align:center\">Payment Information</h1>\r\n\r\n<div class=\"container\" style=\"width: 20%;\">\r\n    <div class=\"form-group\">\r\n        <div class=\"input-group-addon\">\r\n            ");
            EndContext();
            BeginContext(303, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07ea96475f7145ea9a77b4d4ae908709", async() => {
                BeginContext(373, 103, true);
                WriteLiteral("\r\n                <input placeholder=\"Search By Id\" class=\"form-control\" name=\"id\" />\r\n                ");
                EndContext();
                BeginContext(476, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e19db1b0084fa78c29b7b9a4283d74", async() => {
                    BeginContext(561, 38, true);
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
                BeginContext(603, 14, true);
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
            BeginContext(624, 1315, true);
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
                        <td style=""text-align:center; font-weight: bold;"">Payment Id</td>
                        <td style=""text-align:center; font-weight: bold;"">Date</td>
                        <td style=""text-align:center; font-weight: bold;"">Payment Type</td>
                        <td style=""text-align:center; font-weight: bold;"">No of Items</td>
                        <td style=""text-align:center; font-weight: bold;"">Vat (%)</td>
                        <td style=""text-align:center; font-weight: bold;"">Vat Amount</td>
                        <td style=""text-align:center; font-weight: bold;"">Total Cost</td>
                        <td style=""text-align:center; font-weight: bold;"">P_Id</td>
                   ");
            WriteLiteral(@"     <td style=""text-align:center; font-weight: bold;"">E_Id</td>
                        <td style=""text-align:center; font-weight: bold;"">C_Id</td>
                        <td style=""text-align:center; font-weight: bold;"">Action</td>
                    </tr>
                </thead>
");
            EndContext();
#line 37 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                 foreach (var f in Model)
                 {

#line default
#line hidden
            BeginContext(2002, 80, true);
            WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2083, 12, false);
#line 40 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.Payment_Id);

#line default
#line hidden
            EndContext();
            BeginContext(2095, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2157, 6, false);
#line 41 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2225, 14, false);
#line 42 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.Payment_Type);

#line default
#line hidden
            EndContext();
            BeginContext(2239, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2301, 13, false);
#line 43 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.No_Of_Items);

#line default
#line hidden
            EndContext();
            BeginContext(2314, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2376, 19, false);
#line 44 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.Percentage_Of_Vat);

#line default
#line hidden
            EndContext();
            BeginContext(2395, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2457, 15, false);
#line 45 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.Amount_Of_Vat);

#line default
#line hidden
            EndContext();
            BeginContext(2472, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2534, 12, false);
#line 46 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.Total_Cost);

#line default
#line hidden
            EndContext();
            BeginContext(2546, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2608, 6, false);
#line 47 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.P_Id);

#line default
#line hidden
            EndContext();
            BeginContext(2614, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2676, 6, false);
#line 48 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.E_Id);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 61, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2744, 6, false);
#line 49 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                 Write(f.C_Id);

#line default
#line hidden
            EndContext();
            BeginContext(2750, 91, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(2841, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22f4e12ed8346da8b15373357ee53ad", async() => {
                BeginContext(2925, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                             WriteLiteral(f.Payment_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2936, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2966, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deac80b44851484f96ec7affee095517", async() => {
                BeginContext(3047, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                          WriteLiteral(f.Payment_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3055, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3085, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01cd416bcdf043b28c58aa09d0f7570c", async() => {
                BeginContext(3168, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                                                            WriteLiteral(f.Payment_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3178, 62, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 57 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Payment\Views\Payment\ViewPaymentList.cshtml"
                 }

#line default
#line hidden
            BeginContext(3260, 56, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Store_Management_System.Areas.Payment.Models.Payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591