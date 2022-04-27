#pragma checksum "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Checkout\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7268d05648ab0a894d446e3e89d69e940dd3d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Success), @"mvc.1.0.view", @"/Views/Checkout/Success.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7268d05648ab0a894d446e3e89d69e940dd3d6f", @"/Views/Checkout/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3392cb3b4c5bb411f4bc452423b365f8a2fe20cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatStore.ModelView.MuaHangSuccessVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Checkout\Success.cshtml"
  
    ViewData["Title"] = "Cảm ơn quý khách";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height bg-image"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading text-white"">Cảm ơn đã lựa chọn sản phẩm</h2>
                        <ul>
                            <li>
                                <a class=""text-white"" href=""/"">Trang chủ <i class=""text-white pe-7s-angle-right""></i></a>
                            </li>
                            <li class=""text-white"">Đặt hàng thành công</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""about-banner different-bg-position section-space-y-axis-100"" data-bg-image=""assets/images/about/banner/1-1-1920x598.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""co");
            WriteLiteral(@"l-xl-6 col-lg-7 align-self-center"">
                    <div class=""about-banner-content"">
                        <div class=""section-title"">
                            <span class=""sub-title"">Thông tin đơn hàng</span>
                            <p>Cảm ơn bạn đã đặt hàng</p>
                            <h2 class=""title font-size-60 mb-6""></h2>
                            <p>Thông tin khách hàng</p>
                            <p>Họ và tên: ");
#nullable restore
#line 35 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Checkout\Success.cshtml"
                                     Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>Số điện thoại:");
#nullable restore
#line 36 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Checkout\Success.cshtml"
                                        Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p>Địa chỉ ");
#nullable restore
#line 37 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Checkout\Success.cshtml"
                                  Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@": </p>
                            <div class=""button-wrap pt-8"">
                                <a class=""btn btn-custom-size lg-size btn-primary btn-dark-hover rounded-0"" href=""shop.html"">Shop Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatStore.ModelView.MuaHangSuccessVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
