#pragma checksum "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e3433b8f9e59645eadfea1c316afcb03e4f845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Details.cshtml")]
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
#line 1 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\_ViewImports.cshtml"
using BatStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\_ViewImports.cshtml"
using BatStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e3433b8f9e59645eadfea1c316afcb03e4f845", @"/Areas/Admin/Views/AdminProducts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3392cb3b4c5bb411f4bc452423b365f8a2fe20cb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminProducts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatStore.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e3433b8f9e59645eadfea1c316afcb03e4f8455662", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e3433b8f9e59645eadfea1c316afcb03e4f8457360", async() => {
                WriteLiteral("Danh s??ch quy???n truy c???p");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            WriteLiteral(@"
            <span class=""breadcrumb-item active"">Th??ng tin s???n ph???m</span>
        </nav>
    </div>
</div>
<div class=""card"">
    <div class=""card-body"">
        <h4 class=""card-title"">Th??ng tin s???n ph???m</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>
                    <tr>
                        <td>ID:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 26 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                                              Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??n s???n ph???m:</td>\r\n                        <td>");
#nullable restore
#line 30 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>M?? t??? ng???n g???n:</td>\r\n                        <td>");
#nullable restore
#line 34 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Gi?? s???n ph???m:</td>\r\n                        <td>");
#nullable restore
#line 38 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Gi???m gi?? (%):</td>\r\n                        <td>");
#nullable restore
#line 42 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ng??y t???o:</td>\r\n                        <td>");
#nullable restore
#line 46 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>L???n c???p nh???t cu???i:</td>\r\n                        <td>");
#nullable restore
#line 50 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.DateModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>B??n ch???y :</td>\r\n                        <td>\r\n");
#nullable restore
#line 55 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                             if (Model.BestSellers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                    <div>C??</div>
                                </div>
");
#nullable restore
#line 61 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-danger badge-dot m-r-10""></div>
                                    <div>Kh??ng</div>
                                </div>
");
#nullable restore
#line 68 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tr???ng th??i :</td>\r\n                        <td>\r\n");
#nullable restore
#line 74 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                             if (Model.Active)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                    <div>C??</div>
                                </div>
");
#nullable restore
#line 80 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-danger badge-dot m-r-10""></div>
                                    <div>Kh??ng</div>
                                </div>
");
#nullable restore
#line 87 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>G???n th??? :</td>\r\n                        <td>");
#nullable restore
#line 92 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>????? m???c :</td>\r\n                        <td>");
#nullable restore
#line 96 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>M?? t???:</td>\r\n                        <td>");
#nullable restore
#line 100 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>???nh: </td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03e3433b8f9e59645eadfea1c316afcb03e4f84516466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4288, "~/images/products/", 4288, 18, true);
#nullable restore
#line 104 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 4306, Model.Thumb, 4306, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 104 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 4325, Model.Title, 4325, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e3433b8f9e59645eadfea1c316afcb03e4f84518585", async() => {
                WriteLiteral("S???a");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Areas\Admin\Views\AdminProducts\Details.cshtml"
                           WriteLiteral(Model.ProductId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e3433b8f9e59645eadfea1c316afcb03e4f84520744", async() => {
                WriteLiteral("Quay l???i danh s??ch");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatStore.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
