#pragma checksum "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58b25f700f18feaeeab59efafb9231a95d13463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_UserModels_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/UserModels/Delete.cshtml")]
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
#line 1 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnAsp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnAsp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58b25f700f18feaeeab59efafb9231a95d13463", @"/Areas/Admin/Views/UserModels/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba75fa8dcc7734ec702e6911ee0bea2377ebd8af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_UserModels_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnAsp.Areas.Admin.Models.UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: solid 1px white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white; padding-left:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""color: white; padding-left:20px;"">Delete</h1>

<h3 style=""color: white; padding-left:20px;"">Are you sure you want to delete this?</h3>
<div>
    <h4 style=""color: white; padding-left:20px;"">UserModel</h4>
    <hr />
    <dl class=""row"" style=""color: white; padding-left:20px;"">
        <dt class = ""col-sm-2"" style=""border: solid 1px white;"">
            ");
#nullable restore
#line 15 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HotenUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 18 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HotenUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 21 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 24 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 27 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SdtUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 30 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SdtUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 33 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiachiUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 36 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiachiUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 39 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UsernameUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 42 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UsernameUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 45 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 48 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PasswordUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 51 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangthaiUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"border: solid 1px white;\">\r\n            ");
#nullable restore
#line 54 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrangthaiUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58b25f700f18feaeeab59efafb9231a95d1346311283", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e58b25f700f18feaeeab59efafb9231a95d1346311550", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 59 "D:\DEMO_ASP_NET_HK5\ASP\clone-TMDT\DoAnAsp\Areas\Admin\Views\UserModels\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdUser);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" style=\"border: solid 1px white;\"/> \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58b25f700f18feaeeab59efafb9231a95d1346313467", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnAsp.Areas.Admin.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
