#pragma checksum "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4648ee015dad556b476f678c4c7426c764ccba03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPhamModels_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPhamModels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4648ee015dad556b476f678c4c7426c764ccba03", @"/Areas/Admin/Views/SanPhamModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba75fa8dcc7734ec702e6911ee0bea2377ebd8af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SanPhamModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnAsp.Areas.Admin.Models.SanPhamModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Anh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""product-status mg-b-30"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""product-status-wrap"">
                    <h4>Products List</h4>
                    <div class=""col-lg-6 col-md-7 col-sm-6 col-xs-12"">
                        <div class=""header-top-menu tabl-d-n hd-search-rp"">
                            <div class=""breadcome-heading"">
                                <input type=""text"" placeholder=""Search..."" class=""form-control"" id=""keyword"" style=""color: white"">
                                <a id=""chon""><i class=""fa fa-search""></i></a>

                                
                            </div>
                        </div>
                    </div>
                    <div class=""add-product"">
                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 992, "\"", 1096, 5);
            WriteAttributeValue("", 1002, "showModal(\'", 1002, 11, true);
#nullable restore
#line 23 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
WriteAttributeValue("", 1013, Url.Action("Create","SanPhamModels",null,Context.Request.Scheme), 1013, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1078, "\',\'Thêm", 1078, 7, true);
            WriteAttributeValue(" ", 1085, "sản", 1086, 4, true);
            WriteAttributeValue(" ", 1089, "phẩm\')", 1090, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color:aqua; color:black; font-size:20px; margin-top: -10px;""><b>Add User</b></a>
                    </div>
                    <table>
                        <thead>
                            <tr>
                                <th>Tên sản phẩm</th>
                                <th>Ảnh</th>
                                <th>Giá</th>
                                <th>Đơn vị tính</th>
                                <th>Số lượng tồn kho</th>
                                <th>Nhà cung cấp</th>
                                <th>Loại sản phẩm</th>
                                <th>Mô tả</th>
                                <th>Trạng thái</th>
                                <th>Chức năng</th>
                            </tr>
                        </thead>
                        <tbody id=""ketqua"">

");
#nullable restore
#line 42 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 46 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TenSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4648ee015dad556b476f678c4c7426c764ccba037264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2349, "~/template/admin/img/", 2349, 21, true);
#nullable restore
#line 49 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
AddHtmlAttributeValue("", 2370, Html.DisplayFor(modelItem => item.Anh), 2370, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 53 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Donvitinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Soluongton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.nhacungcap.TenNCC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.nhacungcap.TenNCC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 68 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 71 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Trangthai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3764, "\"", 3889, 6);
            WriteAttributeValue("", 3774, "showModal(\'", 3774, 11, true);
#nullable restore
#line 74 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
WriteAttributeValue("", 3785, Url.Action("Edit","SanPhamModels",new {id=$"{item.IdSP}"},Context.Request.Scheme), 3785, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3867, "\',\'Cập", 3867, 6, true);
            WriteAttributeValue(" ", 3873, "nhật", 3874, 5, true);
            WriteAttributeValue(" ", 3878, "sản", 3879, 4, true);
            WriteAttributeValue(" ", 3882, "phẩm\')", 3883, 7, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Edit\" class=\"pd-setting-ed\"><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4052, "\"", 4174, 5);
            WriteAttributeValue("", 4062, "showModal(\'", 4062, 11, true);
#nullable restore
#line 75 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
WriteAttributeValue("", 4073, Url.Action("Delete","SanPhamModels",new {id=$"{item.IdSP}"},Context.Request.Scheme), 4073, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4157, "\',\'Xóa", 4157, 6, true);
            WriteAttributeValue(" ", 4163, "sản", 4164, 4, true);
            WriteAttributeValue(" ", 4167, "phẩm\')", 4168, 7, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Trash\" class=\"pd-setting-ed\"><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\SanPhamModels\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
                        <script>
                            $(document).ready(function () {
                                $(""#chon"").click(function () {
                                    $.ajax({
                                        method: ""GET"",
                                        url: ""../../api/SanPhamModels/GETdata"",
                                        data: { 'keyword': $(""#keyword"").val() }
                                    }).done(function (data) {

                                        var dataJS = JSON.parse(data);
                                        console.log(dataJS);
                                        var i = '';
                                        $.each(dataJS, function (index, value) {
                                            var status = '';
                                            if (value.Trangthai) {
                                                status = 'checked'
                                            }
                   ");
                WriteLiteral(@"                         i += ` <tr>
                                                                                <td>
                                                                                   ${value.TenSP}
                                                                                </td>
                                                                                <td>
                                                                                    <img src=""/template/admin/img/${value.Anh}"" alt=""Anh"" />

                                                                                </td>
                                                                                <td>
                                                                                    ${value.Gia}
                                                                                </td>
                                                                                <td>
                                        ");
                WriteLiteral(@"                                          ${value.Donvitinh}
                                                                                </td>
                                                                                <td>
                                                                                    ${value.Soluongton}
                                                                                </td>
                                                                                <td>
                                                                                   ${value.IdNCC}
                                                                                </td>
                                                                                <td>
                                                                                   ${value.IdLSP}
                                                                                </td>
                                                     ");
                WriteLiteral(@"                           <td>
                                                                                    ${value.Mota}
                                                                                </td>
                                                                                <td>
                                                                                        <input type=""checkbox"" ${status} disabled>
                                                                                   </td>
                                                                                <td>
                                                                                    <a href=""/admin/SanPhamModels/Edit/`+ value.IdSP + `"" data-toggle=""tooltip"" title=""Edit"" class=""pd-setting-ed""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i></a>

                                                                                    <a href=""/admin/SanPhamModels/Delete/`+ value.IdSP + `"" data-toggle=");
                WriteLiteral(@"""tooltip"" title=""Trash"" class=""pd-setting-ed""><i class=""fa fa-trash-o"" aria-hidden=""true""></i></a>
                                                                                    </td>
                                                                                </tr>`
                                        });
                                        //console.log('i nè ' + i);
                                        $('#ketqua').html(i);
                                    })
                                });
                            });

                        </script>
                    ");
            }
            );
            WriteLiteral("                    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnAsp.Areas.Admin.Models.SanPhamModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
