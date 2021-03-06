#pragma checksum "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f2e3b7dbee0436cbbdad18744ab3833450b3721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\_ViewImports.cshtml"
using BatStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\_ViewImports.cshtml"
using BatStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2e3b7dbee0436cbbdad18744ab3833450b3721", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3392cb3b4c5bb411f4bc452423b365f8a2fe20cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatStore.ModelView.HomeView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/shipping/icon/plane.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Shipping Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/shipping/icon/earphones.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/shipping/icon/shield.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Bat Store";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Product> allProduct = ViewBag.AllProducts;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Begin Slider Area -->
<div class=""slider-area"">

    <!-- Main Slider -->
    <div class=""swiper-container main-slider swiper-arrow with-bg_white"">
        <div class=""swiper-wrapper"">
            <div class=""swiper-slide animation-style-01"">
                <div class=""slide-inner bg-height"" data-bg-image=""images/SlideImages/S22_ultra.png"">
                    <div class=""parallax-img-wrap"">
                        
                    </div>
                    <div class=""container"">
                        <div class=""parallax-with-content"">
                            <div class=""slide-content"">
                                <h2 class=""title mb-9""><br> Products.</h2>
                                <div class=""button-wrap"">
                                    <a class=""btn btn-custom-size lg-size btn-primary btn-white-hover rounded-0"" href=""shop.html"">Shop Now</a>
                                </div>
                            </div>
                            
        ");
            WriteLiteral(@"                </div>
                    </div>
                </div>
            </div>
            <div class=""swiper-slide animation-style-01"">
                <div class=""slide-inner bg-height"" data-bg-image=""images/SlideImages/iPhone_11.png"">
                    
                    <div class=""container"">
                        <div class=""parallax-with-content"">
                            <div class=""slide-content"">
                                <h2 class=""title mb-9""><br> Products.</h2>
                                <div class=""button-wrap"">
                                    <a class=""btn btn-custom-size lg-size btn-primary btn-white-hover rounded-0"" href=""shop.html"">Shop Now</a>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Add Pagination -->
        <div class=""swiper-pagination with-b");
            WriteLiteral(@"g d-md-none""></div>

        <!-- Add Arrows -->
        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>
    </div>

</div>
<!-- Slider Area End Here -->
<!-- Begin Banner With Category -->
<div class=""banner-with-category"">
    <div class=""product-category-area section-space-top-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title text-center pb-55"">
                        <span class=""sub-title"" style=""color:#CD5C5C"">Nh???ng s???n ph???m m???i nh???t c???a ch??ng t??i</span>
                        <h2 class=""title mb-0"">S???n ph???m theo h??ng</h2>
                    </div>
                    <div class=""product-category-item"">
                        <ul>
");
#nullable restore
#line 72 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
                             foreach (var item in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"nav-item\" role=\"presentation\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3253, "\"", 3282, 1);
#nullable restore
#line 75 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3260, item.category.CatName, 3260, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f2e3b7dbee0436cbbdad18744ab3833450b37218654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3352, "~/images/categories/", 3352, 20, true);
#nullable restore
#line 76 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3372, item.category.Thumb, 3372, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3399, item.category.Title, 3399, 20, false);

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
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 77 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
                                   Write(item.category.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 80 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</div>
<!-- Banner With Category End Here -->
<!-- Begin Product Area -->
<div class=""product-area product-style-2 section-space-y-axis-100"">
    <div class=""container"">
        <div class=""section-title text-center pb-55"">
            <span class=""sub-title "" style=""color:#CD5C5C"">C??c s???n ph???m ph???c v??? m???i ph??n kh??c</span>
            <h2 class=""title mb-0"">T???t c??? s???n ph???m</h2>
        </div>
        <div class=""tab-content"" id=""myTabcontent"">
            <div class="" tab-pane fade show active"" role=""tabpanel"" aria-labelledby=""all"">

                ");
#nullable restore
#line 100 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("_ListProductPartialView", allProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 102 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" tab-pane fade  \"");
            BeginWriteAttribute("id", " id=\"", 4500, "\"", 4527, 1);
#nullable restore
#line 104 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4505, item.category.CatName, 4505, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\">\r\n\r\n                    ");
#nullable restore
#line 106 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("_ListProductPartialView", item.lsProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 108 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Product Area End Here -->
<!-- Begin Banner Area -->
<!-- Banner Area End Here -->
<!-- Begin Shipping Area -->
<div class=""shipping-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f2e3b7dbee0436cbbdad18744ab3833450b372113823", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Mi???n ph?? v???n chuy???n</h5>
                        <p class=""short-desc mb-0"">Giao h??ng to??n qu???c</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-md-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f2e3b7dbee0436cbbdad18744ab3833450b372115420", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">H??? tr??? tr???c tuy???n</h5>
                        <p class=""short-desc mb-0"">H??? tr??? kh??ch h??ng 24/7</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-lg-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f2e3b7dbee0436cbbdad18744ab3833450b372117018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Thanh to??n ti???n l???i</h5>
                        <p class=""short-desc mb-0"">H??? tr??? kh??ch h??ng thanh to??n khi nh???n h??ng</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shipping Area End Here -->
<!-- Begin Product Area -->
<!-- Product Area End Here -->
<!-- Begin Banner Area -->
<!-- Banner Area End Here -->
<!-- Begin Product Area -->

<!-- Product Area End Here -->
<!-- Begin Brand Area -->

<!-- Brand Area End Here -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatStore.ModelView.HomeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
