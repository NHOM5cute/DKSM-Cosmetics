#pragma checksum "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1774d45f425e1846e4b1f39acfa2b38b1a000614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1774d45f425e1846e4b1f39acfa2b38b1a000614", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6490fadcd53cf4d9b5d90d03d757e781c795e2e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\HỌC TẬP\NĂM 3\PHÁT TRIỂN ỨNG DỤNG TMĐT\CUỐI KỲ\DKSM-main\DKSM-main\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Admin Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div>
                        <p class=""m-b-0"">Net Revenue</p>
                        <h2 class=""m-b-0"">
                            <span>$14,966</span>
                        </h2>
                    </div>
                    <div class=""avatar avatar-icon avatar-lg avatar-blue"">
                        <i class=""anticon anticon-dollar""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div>
                        <p class=""m-b-0"">Bounce Rate</p>
                        <h2 class=""m-b-0"">
                            <span>26.80%</span>
        ");
            WriteLiteral(@"                </h2>
                    </div>
                    <div class=""avatar avatar-icon avatar-lg avatar-cyan"">
                        <i class=""anticon anticon-bar-chart""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div>
                        <p class=""m-b-0"">Orders</p>
                        <h2 class=""m-b-0"">
                            <span>3057</span>
                        </h2>
                    </div>
                    <div class=""avatar avatar-icon avatar-lg avatar-red"">
                        <i class=""anticon anticon-profile""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
    ");
            WriteLiteral(@"            <div class=""d-flex justify-content-between align-items-center"">
                    <div>
                        <p class=""m-b-0"">Total Expense</p>
                        <h2 class=""m-b-0"">
                            <span>$6,138</span>
                        </h2>
                    </div>
                    <div class=""avatar avatar-icon avatar-lg avatar-gold"">
                        <i class=""anticon anticon-bar-chart""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <h5>Overall Rating</h5>
                </div>
                <div class=""d-flex align-items-center m-t-20"">
                    <h1 class=""m-b-0 m-r-10 font-weight-normal"">4.5</h1>
                    <div class=""star-rating m-t-15"">
                        <inp");
            WriteLiteral(@"ut type=""radio"" id=""star1-5"" name=""rating-1"" value=""5"" checked disabled /><label for=""star1-5"" title=""5 star""></label>
                        <input type=""radio"" id=""star1-4"" name=""rating-1"" value=""4"" disabled /><label for=""star1-4"" title=""4 star""></label>
                        <input type=""radio"" id=""star1-3"" name=""rating-1"" value=""3"" disabled /><label for=""star1-3"" title=""3 star""></label>
                        <input type=""radio"" id=""star1-2"" name=""rating-1"" value=""2"" disabled /><label for=""star1-2"" title=""2 star""></label>
                        <input type=""radio"" id=""star1-1"" name=""rating-1"" value=""1"" disabled /><label for=""star1-1"" title=""1 star""></label>
                    </div>
                </div>
                <p><span class=""text-success font-weight-bold"">+1.5</span> point from last month</p>
                <div class=""m-t-30"" style=""height: 150px"">
                    <canvas class=""chart"" id=""rating-chart""></canvas>
                </div>
            </div>
        </div>
    </div>
 ");
            WriteLiteral(@"   <div class=""col-lg-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-md-flex justify-content-between align-items-center"">
                    <h5>Total Sales</h5>
                    <div class=""d-flex"">
                        <div class=""m-r-10"">
                            <span class=""badge badge-secondary badge-dot m-r-10""></span>
                            <span class=""text-gray font-weight-semibold font-size-13"">Revenue</span>
                        </div>
                        <div class=""m-r-10"">
                            <span class=""badge badge-purple badge-dot m-r-10""></span>
                            <span class=""text-gray font-weight-semibold font-size-13"">Margin</span>
                        </div>
                    </div>
                </div>
                <div class=""m-t-50"" style=""height: 225px"">
                    <canvas class=""chart"" id=""sales-chart""></canvas>
                </div>
            </div>
        </div>
    </d");
            WriteLiteral(@"iv>
    <div class=""col-lg-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <h5>Monthly Target</h5>
                </div>
                <div class=""d-flex align-items-center position-relative m-v-50"" style=""height:150px;"">
                    <div class=""w-100 position-absolute"" style=""height:150px; top:0;"">
                        <canvas class=""chart m-h-auto"" id=""porgress-chart""></canvas>
                    </div>
                    <h2 class=""w-100 text-center text-large m-b-0 text-success font-weight-normal"">$3,531</h2>
                </div>
                <div class=""d-flex justify-content-center align-items-center"">
                    <span class=""badge badge-success badge-dot m-r-10""></span>
                    <span><span class=""font-weight-semibold"">70%</span> of Your Goal</span>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
