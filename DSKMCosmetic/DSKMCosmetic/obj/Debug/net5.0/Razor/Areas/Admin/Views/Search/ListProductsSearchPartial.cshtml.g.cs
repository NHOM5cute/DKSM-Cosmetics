#pragma checksum "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9c10f1b625f1c305c141c1a2bb20920cc7896e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Search_ListProductsSearchPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Search/ListProductsSearchPartial.cshtml")]
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
#line 1 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\_ViewImports.cshtml"
using DSKMCosmetic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\_ViewImports.cshtml"
using DSKMCosmetic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c10f1b625f1c305c141c1a2bb20920cc7896e", @"/Areas/Admin/Views/Search/ListProductsSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6490fadcd53cf4d9b5d90d03d757e781c795e2e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Search_ListProductsSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
 if (Model != null)
{
    foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 8 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <div class=\"d-flex align-items-center\">\n                    <h6 class=\"m-b-0 m-l-10\">");
#nullable restore
#line 11 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
                                        Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                </div>\n            </td>\n            <td>");
#nullable restore
#line 14 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 15 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
           Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 16 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 17 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
           Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" vnđ</td>\n            <td>");
#nullable restore
#line 18 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
           Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral(@"            <td>
                <div class=""d-flex align-items-center"">
                    <div class=""badge badge-success badge-dot m-r-10""></div>
                    <div>In Stock</div>
                </div>
            </td>
            <td class=""text-right"">
                <button class=""btn btn-icon btn-hover btn-sm btn-rounded pull-right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f9c10f1b625f1c305c141c1a2bb20920cc7896e7878", async() => {
                WriteLiteral("<i class=\"anticon anticon-edit\"></i>");
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
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
                                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </button>\n                <button class=\"btn btn-icon btn-hover btn-sm btn-rounded\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f9c10f1b625f1c305c141c1a2bb20920cc7896e10721", async() => {
                WriteLiteral("<i class=\"anticon anticon-delete\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
                                                                                             WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </button>\n            </td>\n\n        </tr>\n");
#nullable restore
#line 36 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Search\ListProductsSearchPartial.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
