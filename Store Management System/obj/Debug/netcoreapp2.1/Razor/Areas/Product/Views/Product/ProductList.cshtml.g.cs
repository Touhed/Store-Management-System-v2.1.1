#pragma checksum "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49ab9b447e982481460a9633e09c39f9d784d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Product_Views_Product_ProductList), @"mvc.1.0.view", @"/Areas/Product/Views/Product/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Product/Views/Product/ProductList.cshtml", typeof(AspNetCore.Areas_Product_Views_Product_ProductList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b49ab9b447e982481460a9633e09c39f9d784d6b", @"/Areas/Product/Views/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9ee2ee05adad2bf34424caccb0d8d26bdf24fe", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Product_Views_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Store_Management_System.Areas.Product.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
  
    //Layout = "_LayoutForProduct";
    ViewData["Title"] = "Product";

#line default
#line hidden
            BeginContext(148, 188, true);
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Product Information</h1>\r\n\r\n<div class=\"container\" style=\"width: 20%;\">\r\n    <div class=\"form-group\">\r\n        <div class=\"input-group-addon\">\r\n            ");
            EndContext();
            BeginContext(336, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0ea361ed784e8a993190943e1dd482", async() => {
                BeginContext(406, 103, true);
                WriteLiteral("\r\n                <input placeholder=\"Search By Id\" class=\"form-control\" name=\"id\" />\r\n                ");
                EndContext();
                BeginContext(509, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a149b226a0e41c6bfda229668998582", async() => {
                    BeginContext(594, 38, true);
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
                BeginContext(636, 14, true);
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
            BeginContext(657, 701, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Product Id</td>
                <td style=""text-align:center; font-weight: bold;"">Name</td>
                <td style=""text-align:center; font-weight: bold;"">Brand Name</td>
                <td style=""text-align:center; font-weight: bold;"">Quantity</td>
                <td style=""text-align:center; font-weight: bold;"">Price</td>
                <td style=""text-align:center; font-weight: bold;"">Action</td>
            </tr>
        </thead>
");
            EndContext();
#line 31 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
         foreach (var f in Model)
        {

#line default
#line hidden
            BeginContext(1404, 64, true);
            WriteLiteral("            <tr>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1469, 12, false);
#line 34 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
                                         Write(f.Product_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1481, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1535, 14, false);
#line 35 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
                                         Write(f.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1603, 12, false);
#line 36 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
                                         Write(f.Brand_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1615, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1669, 18, false);
#line 37 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
                                         Write(f.Product_Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1687, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1741, 15, false);
#line 38 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
                                         Write(f.Product_Price);

#line default
#line hidden
            EndContext();
            BeginContext(1756, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "H:\MY BOOKS\# IUBAT\Visual Projects\Store Management System v2.1.1\Store Management System\Areas\Product\Views\Product\ProductList.cshtml"
        }

#line default
#line hidden
            BeginContext(1793, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Store_Management_System.Areas.Product.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591