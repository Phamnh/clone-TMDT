#pragma checksum "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "886216633167ce40c27f8f964392fd9cc6a8fcb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ChiTietHoaDonModels_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ChiTietHoaDonModels/Index.cshtml")]
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
#line 1 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnAsp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnAsp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"886216633167ce40c27f8f964392fd9cc6a8fcb6", @"/Areas/Admin/Views/ChiTietHoaDonModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba75fa8dcc7734ec702e6911ee0bea2377ebd8af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ChiTietHoaDonModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnAsp.Areas.Admin.Models.ChiTietHoaDonModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""product-status mg-b-30"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""product-status-wrap"">
                    <h4>Products List</h4>
                    <div class=""col-lg-6 col-md-7 col-sm-6 col-xs-12"">
                        <div class=""header-top-menu tabl-d-n hd-search-rp"">
                            <div class=""breadcome-heading"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "886216633167ce40c27f8f964392fd9cc6a8fcb64921", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Search...\" class=\"form-control\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 787, "\"", 794, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"add-product\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1040, "\"", 1158, 7);
            WriteAttributeValue("", 1050, "showModal(\'", 1050, 11, true);
#nullable restore
#line 24 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
WriteAttributeValue("", 1061, Url.Action("Create","ChiTietHoaDonModels",null,Context.Request.Scheme), 1061, 71, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1132, "\',\'Thêm", 1132, 7, true);
            WriteAttributeValue(" ", 1139, "chi", 1140, 4, true);
            WriteAttributeValue(" ", 1143, "tiết", 1144, 5, true);
            WriteAttributeValue(" ", 1148, "hóa", 1149, 4, true);
            WriteAttributeValue(" ", 1152, "đơn\')", 1153, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color:aqua; color:black; font-size:20px; margin-top: -10px;"">Add chi tiết hóa đơn</a>
                    </div>
                    <table>
                        <thead>
                            <tr>
                                <th>Số lượng</th>
                                <th>Tổng tiền</th>
                                <th>Ngày lập hóa đơn</th>
                                <th>Tên sản phẩm</th>
                                <th>Trạng thái</th>
                                <th>Chức năng</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 38 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 45 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Tongtien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 48 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdHD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 51 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 54 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Trangthai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2871, "\"", 3012, 8);
            WriteAttributeValue("", 2881, "showModal(\'", 2881, 11, true);
#nullable restore
#line 57 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
WriteAttributeValue("", 2892, Url.Action("Edit","ChiTietHoaDonModels",new {id=$"{item.IdCTHD}"},Context.Request.Scheme), 2892, 90, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2982, "\',\'Cập", 2982, 6, true);
            WriteAttributeValue(" ", 2988, "nhật", 2989, 5, true);
            WriteAttributeValue(" ", 2993, "chi", 2994, 4, true);
            WriteAttributeValue(" ", 2997, "tiết", 2998, 5, true);
            WriteAttributeValue(" ", 3002, "hóa", 3003, 4, true);
            WriteAttributeValue(" ", 3006, "đơn\')", 3007, 6, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Edit\" class=\"pd-setting-ed\"><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3175, "\"", 3313, 7);
            WriteAttributeValue("", 3185, "showModal(\'", 3185, 11, true);
#nullable restore
#line 58 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
WriteAttributeValue("", 3196, Url.Action("Delete","ChiTietHoaDonModels",new {id=$"{item.IdCTHD}"},Context.Request.Scheme), 3196, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3288, "\',\'Xóa", 3288, 6, true);
            WriteAttributeValue(" ", 3294, "chi", 3295, 4, true);
            WriteAttributeValue(" ", 3298, "tiết", 3299, 5, true);
            WriteAttributeValue(" ", 3303, "hóa", 3304, 4, true);
            WriteAttributeValue(" ", 3307, "đơn\')", 3308, 6, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Trash\" class=\"pd-setting-ed\"><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\ChiTietHoaDonModels\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnAsp.Areas.Admin.Models.ChiTietHoaDonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
