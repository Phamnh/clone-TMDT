#pragma checksum "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b675a5b99fe0d5030f687093ac782febf6d2137e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminModels_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminModels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b675a5b99fe0d5030f687093ac782febf6d2137e", @"/Areas/Admin/Views/AdminModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba75fa8dcc7734ec702e6911ee0bea2377ebd8af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnAsp.Areas.Admin.Views.AdminModel>>
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
#line 3 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b675a5b99fe0d5030f687093ac782febf6d2137e4864", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Search...\" class=\"form-control\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 778, "\"", 785, 0);
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
            BeginWriteAttribute("onclick", " onclick=\"", 1031, "\"", 1140, 6);
            WriteAttributeValue("", 1041, "showModal(\'", 1041, 11, true);
#nullable restore
#line 24 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
WriteAttributeValue("", 1052, Url.Action("Create","AdminModels",null,Context.Request.Scheme), 1052, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1115, "\',\'Thêm", 1115, 7, true);
            WriteAttributeValue(" ", 1122, "tài", 1123, 4, true);
            WriteAttributeValue(" ", 1126, "khoản", 1127, 6, true);
            WriteAttributeValue(" ", 1132, "Admin\')", 1133, 8, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color:aqua; color:black; font-size:20px; margin-top: -10px;""><b>Add Tài Khoản Admin</b></a>
                    </div>
                    <table>
                        <thead>
                            <tr>
                                <th>Username</th>
                                <th>Password</th>
                                <th>Họ tên</th>
                                <th>Số điện thoại</th>
                                <th>Email</th>
                                <th>Chức năng</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 38 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 45 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 48 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Hoten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 51 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Sdt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 54 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2841, "\"", 2974, 7);
            WriteAttributeValue("", 2851, "showModal(\'", 2851, 11, true);
#nullable restore
#line 57 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
WriteAttributeValue("", 2862, Url.Action("Edit","AdminModels",new {id=$"{item.IdAdmin}"},Context.Request.Scheme), 2862, 83, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2945, "\',\'Cập", 2945, 6, true);
            WriteAttributeValue(" ", 2951, "nhật", 2952, 5, true);
            WriteAttributeValue(" ", 2956, "danh", 2957, 5, true);
            WriteAttributeValue(" ", 2961, "sách", 2962, 5, true);
            WriteAttributeValue(" ", 2966, "Admin\')", 2967, 8, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Edit\" class=\"pd-setting-ed\"><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3137, "\"", 3257, 4);
            WriteAttributeValue("", 3147, "showModal(\'", 3147, 11, true);
#nullable restore
#line 58 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
WriteAttributeValue("", 3158, Url.Action("Delete","AdminModels",new {id=$"{item.IdAdmin}"},Context.Request.Scheme), 3158, 85, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3243, "\',\'Xóa", 3243, 6, true);
            WriteAttributeValue(" ", 3249, "Admin\')", 3250, 8, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Trash\" class=\"pd-setting-ed\"><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n\r\n                                 \r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\AdminModels\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnAsp.Areas.Admin.Views.AdminModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
