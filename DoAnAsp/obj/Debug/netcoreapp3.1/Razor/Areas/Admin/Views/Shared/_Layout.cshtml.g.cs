#pragma checksum "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b45d4d1f52d5ef04081823dfc2f9d15d3ed47c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnAsp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnAsp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b45d4d1f52d5ef04081823dfc2f9d15d3ed47c0", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba75fa8dcc7734ec702e6911ee0bea2377ebd8af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b45d4d1f52d5ef04081823dfc2f9d15d3ed47c03284", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("css", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b45d4d1f52d5ef04081823dfc2f9d15d3ed47c04723", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_MenuPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Modal -->
    <div class=""modal fade"" id=""form-modal"" role=""dialog"" >
        <div class=""modal-dialog"">

            <!-- Modal content-->
            <div class=""modal-content"" style=""background-color:#1b2a47"">
                <div class=""modal-header"">
                    <div style=""display:flex;justify-content:space-between"">
                        <h4 class=""modal-title"" style=""color:black"">Thông báo</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" style=""background-color:#00ffff;width:50px;border-radius:6px"">&times;</button>
                    </div>
                </div>
                <div class=""modal-body"">
                    <p style=""color:#ef592d"">Chào mừng bạn đến trang quản lý Bình Luận</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"" style=""background-color:#4caf50"">Đóng</button>
                </div>
            </");
                WriteLiteral("div>\r\n\r\n        </div>\r\n    </div>\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n        <script>\r\n            $(document).ready(function () {\r\n                $(\'#myModal\').modal(\'show\');\r\n            })\r\n        </script>\r\n    ");
                }
                );
                WriteLiteral("    ");
#nullable restore
#line 40 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
        showModal = (url, title) => {
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (res) {
                    // Hiễn thị form create edit
                    $('#form-modal .modal-body').html(res);
                    //hiện tiêu đề
                    $('#form-modal .modal-title').html(title);
                    //hiện modal
                    $('#form-modal').modal('show');
                }
            })
        }
    </script>
    ");
#nullable restore
#line 57 "D:\clone-TMDT\DoAnAsp\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
