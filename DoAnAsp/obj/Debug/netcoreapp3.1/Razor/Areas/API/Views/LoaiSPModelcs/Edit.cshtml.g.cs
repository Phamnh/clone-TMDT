#pragma checksum "D:\clone-TMDT\DoAnAsp\Areas\API\Views\LoaiSPModelcs\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06d420ac8c43cf6ae0498d195dee367761dc14d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_API_Views_LoaiSPModelcs_Edit), @"mvc.1.0.view", @"/Areas/API/Views/LoaiSPModelcs/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06d420ac8c43cf6ae0498d195dee367761dc14d", @"/Areas/API/Views/LoaiSPModelcs/Edit.cshtml")]
    public class Areas_API_Views_LoaiSPModelcs_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnAsp.Areas.Admin.Models.LoaiSPModelcs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\clone-TMDT\DoAnAsp\Areas\API\Views\LoaiSPModelcs\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>LoaiSPModelcs</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""IdLSP"" />
            <div class=""form-group"">
                <label asp-for=""TenLSP"" class=""control-label""></label>
                <input asp-for=""TenLSP"" class=""form-control"" />
                <span asp-validation-for=""TenLSP"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Trangthai"" /> ");
#nullable restore
#line 23 "D:\clone-TMDT\DoAnAsp\Areas\API\Views\LoaiSPModelcs\Edit.cshtml"
                                                                      Write(Html.DisplayNameFor(model => model.Trangthai));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\clone-TMDT\DoAnAsp\Areas\API\Views\LoaiSPModelcs\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnAsp.Areas.Admin.Models.LoaiSPModelcs> Html { get; private set; }
    }
}
#pragma warning restore 1591
