#pragma checksum "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4207b4b5de97bbcab117dcea61b796d6bdde16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCapModels_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCapModels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4207b4b5de97bbcab117dcea61b796d6bdde16", @"/Areas/Admin/Views/NhaCungCapModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba75fa8dcc7734ec702e6911ee0bea2377ebd8af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhaCungCapModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnAsp.Areas.Admin.Models.NhaCungCapModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
  
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
                                <input type=""text"" placeholder=""Search..."" class=""form-control"" id=""keyword"" style=""color: white"">
                                <a id=""chon""><i class=""fa fa-search""></i></a>


                            </div>
                        </div>
                    </div>
                    <div class=""add-product"">
                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 971, "\"", 1082, 6);
            WriteAttributeValue("", 981, "showModal(\'", 981, 11, true);
#nullable restore
#line 25 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
WriteAttributeValue("", 992, Url.Action("Create","NhaCungCapModels",null,Context.Request.Scheme), 992, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1060, "\',\'Thêm", 1060, 7, true);
            WriteAttributeValue(" ", 1067, "Nhà", 1068, 4, true);
            WriteAttributeValue(" ", 1071, "Cung", 1072, 5, true);
            WriteAttributeValue(" ", 1076, "Cấp\')", 1077, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color:aqua; color:black; font-size:20px; margin-top: -10px;""><b>Add Nhà Cung Cấp</b></a>
                    </div>
                    <table>
                        <thead>
                            <tr>
                                <th>Tên nhà cung cấp</th>
                                <th>Số điện thoại</th>
                                <th>Trạng thái</th>
                                <th>Chức năng</th>
                            </tr>
                        </thead>
                        <tbody id=""ketqua"">
");
#nullable restore
#line 37 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 41 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TenNCC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 44 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.SdtNCC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 47 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2371, "\"", 2504, 7);
            WriteAttributeValue("", 2381, "showModal(\'", 2381, 11, true);
#nullable restore
#line 50 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
WriteAttributeValue("", 2392, Url.Action("Edit","NhaCungCapModels",new {id=$"{item.IdNCC}"},Context.Request.Scheme), 2392, 86, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2478, "\',\'Cập", 2478, 6, true);
            WriteAttributeValue(" ", 2484, "nhật", 2485, 5, true);
            WriteAttributeValue(" ", 2489, "Nhà", 2490, 4, true);
            WriteAttributeValue(" ", 2493, "Cung", 2494, 5, true);
            WriteAttributeValue(" ", 2498, "Cấp\')", 2499, 6, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Edit\" class=\"pd-setting-ed\"><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i></a>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2667, "\"", 2797, 6);
            WriteAttributeValue("", 2677, "showModal(\'", 2677, 11, true);
#nullable restore
#line 51 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
WriteAttributeValue("", 2688, Url.Action("Delete","NhaCungCapModels",new {id=$"{item.IdNCC}"},Context.Request.Scheme), 2688, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2776, "\',\'Xóa", 2776, 6, true);
            WriteAttributeValue(" ", 2782, "Nhà", 2783, 4, true);
            WriteAttributeValue(" ", 2786, "Cung", 2787, 5, true);
            WriteAttributeValue(" ", 2791, "Cấp\')", 2792, 6, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Trash\" class=\"pd-setting-ed\"><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Quoc Trung\Documents\GitHub\clone-TMDT\DoAnAsp\Areas\Admin\Views\NhaCungCapModels\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
                        <script>
                            $(document).ready(function () {
                                $(""#chon"").click(function () {
                                    $.ajax({
                                        method: ""GET"",
                                        url: ""../../api/NhaCungCapModels/GETdata"",
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
                WriteLiteral(@"                            i += ` <tr>
                                                                                                        <td>
                                                                                                           ${value.TenNCC}
                                                                                                        </td>
                                                                                                        
                                                                                                        <td>
                                                                                                            ${value.SdtNCC}
                                                                                                        </td>
                                                                                                        
                                                                                ");
                WriteLiteral(@"                        <td>
                                                                                                                <input type=""checkbox"" ${status} disabled>
                                                                                                           </td>
                                                                                                        <td>
                                                                                                            <a href=""/admin/NhaCungCapModels/Edit/`+ value.idNCC + `"" data-toggle=""tooltip"" title=""Edit"" class=""pd-setting-ed""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i></a>

                                                                                                            <a href=""/admin/NhaCungCapModels/Delete/`+ value.idNCC + `"" data-toggle=""tooltip"" title=""Trash"" class=""pd-setting-ed""><i class=""fa fa-trash-o"" aria-hidden=""true""></i></a>
                                               ");
                WriteLiteral(@"                                                             </td>
                                                                                                        </tr>`
                                        });
                                       
                                        $('#ketqua').html(i);
                                    })
                                });
                            });

                        </script>
                    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnAsp.Areas.Admin.Models.NhaCungCapModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
