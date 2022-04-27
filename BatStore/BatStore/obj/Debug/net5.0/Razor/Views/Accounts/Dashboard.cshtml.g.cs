#pragma checksum "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac04a1e606034ca05e3bf8e10f403ecfdd5e366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard), @"mvc.1.0.view", @"/Views/Accounts/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac04a1e606034ca05e3bf8e10f403ecfdd5e366", @"/Views/Accounts/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3392cb3b4c5bb411f4bc452423b365f8a2fe20cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatStore.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Order> DanhSachDonHang = ViewBag.DonHang;
    BatStore.ModelView.ChangePasswordViewModel changePassword = new BatStore.ModelView.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Product Related</h2>
                        <ul>
                            <li>
                                <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Tài khoản của tôi</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablist""");
            WriteLiteral(@">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab""
                               href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard""
                               aria-selected=""true"">Thông tin tài khoản</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab""
                               href=""#account-orders"" role=""tab"" aria-controls=""account-orders""
                               aria-selected=""false"">Danh sách đơn đặt hàng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab""
                               href=""#account-details"" role=""tab"" aria-controls=""account-details""
                               aria-selected=""false"">Đổi mật khẩu</a");
            WriteLiteral(@">
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""/logout.html"" role=""tab""
                               aria-selected=""false"">Đăng xuất</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel""
                             aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin chào <i><b>");
#nullable restore
#line 60 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                              Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></i>\r\n                                </p>\r\n                                <p>Số điện thoại: ");
#nullable restore
#line 62 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Địa chỉ: ");
#nullable restore
#line 63 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Số Email: ");
#nullable restore
#line 64 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">Danh sách đơn hàng</h4>
");
#nullable restore
#line 70 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                 if (DanhSachDonHang != null && DanhSachDonHang.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <td>ID</td>
                                                    <td>Ngày</td>
                                                    <td>Ngày vận chuyển</td>
                                                    <td>Trạng thái</td>
                                                    <td>Tổng tiền</td>
                                                    <td></td>
                                                </tr>
");
#nullable restore
#line 83 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                 foreach (var item in DanhSachDonHang)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">");
#nullable restore
#line 86 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                                                                             Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td>");
#nullable restore
#line 87 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 88 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 89 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 90 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                                        <td>\r\n                                                            <a class=\"xemdonhang\" href=\"javascript:void(0)\" data-madonhang=\"");
#nullable restore
#line 92 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                                                                                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem đơn hàng</a>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 95 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                        <div id=""records_table"">

                                        </div>
                                    </div>
");
#nullable restore
#line 102 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có đơn hàng!</p>\r\n");
#nullable restore
#line 106 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel""
                             aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <div class=""row"">
                                    <div class=""col"">
                                        <h4 class=""small-title"">BILLING ADDRESS</h4>
                                        <address>
                                            1234 Heaven Stress, Beverly Hill OldYork UnitedState of Lorem
                                        </address>
                                    </div>
                                    <div class=""col"">
                                        <h4 class=""small-title"">SHIPPING ADDRESS</h4>
                                     ");
            WriteLiteral(@"   <address>
                                            1234 Heaven Stress, Beverly Hill OldYork UnitedState of Lorem
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel""
                             aria-labelledby=""account-details-tab"">
                            ");
#nullable restore
#line 132 "F:\Thuctap\Web_BatStore\BatStore\BatStore\Views\Accounts\Dashboard.cshtml"
                       Write(await Html.PartialAsync("_ChangePasswordPartialView", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(function () {
            $("".xemdonhang"").click(function () {
                var madonhang = $(this).attr(""data-madonhang"")
                $.ajax({
                    url: '/Order/Details',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { id: madonhang },
                    async: true,
                    success: function (results) {
                        $(""#records_table"").html("""");
                        $(""#records_table"").html(results);
                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatStore.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
