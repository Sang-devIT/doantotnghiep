#pragma checksum "C:\Users\84348\OneDrive\Desktop\bug\doantotnghiep\LaptopShop\Areas\Admin\Views\Shared\_nav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd57850e725a9d9f884b86b2d9dedff51ea4a0fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__nav), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_nav.cshtml")]
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
#line 1 "C:\Users\84348\OneDrive\Desktop\bug\doantotnghiep\LaptopShop\Areas\Admin\Views\_ViewImports.cshtml"
using LaptopShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\84348\OneDrive\Desktop\bug\doantotnghiep\LaptopShop\Areas\Admin\Views\_ViewImports.cshtml"
using LaptopShop.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\84348\OneDrive\Desktop\bug\doantotnghiep\LaptopShop\Areas\Admin\Views\_ViewImports.cshtml"
using LaptopShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd57850e725a9d9f884b86b2d9dedff51ea4a0fc", @"/Areas/Admin/Views/Shared/_nav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57514311bab2c85de99c9cc71262b7d0a7fabf3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__nav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-menu__item active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-menu__item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("treeview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- Navbar-->
<header class=""app-header"">
    <a class=""app-header__logo"" href=""#"">Vali</a>
    <!-- Sidebar toggle button--><a class=""app-sidebar__toggle""
                                    href=""#""
                                    data-toggle=""sidebar""
                                    aria-label=""Hide Sidebar""></a>
    <!-- Navbar Right Menu-->
    <ul class=""app-nav"">
        <li class=""app-search"">
            <input class=""app-search__input"" type=""search"" placeholder=""Search"" />
            <button class=""app-search__button"">
                <i class=""fa fa-search""></i>
            </button>
        </li>
        <!--Notification Menu-->
        <li class=""dropdown"">
            <a class=""app-nav__item""
               href=""#""
               data-toggle=""dropdown""
               aria-label=""Show notifications"">
                <i class=""fa fa-bell-o fa-lg""></i>
            </a>
            <ul class=""app-notification dropdown-menu dropdown-menu-right"">
                ");
            WriteLiteral(@"<li class=""app-notification__title"">
                    You have 4 new notifications.
                </li>
                <div class=""app-notification__content"">
                <li>
                    <a class=""app-notification__item"" href=""javascript:;"">
                        <span class=""app-notification__icon"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fa fa-circle fa-stack-2x text-primary""></i><i class=""fa fa-envelope fa-stack-1x fa-inverse""></i>
                            </span>
                        </span>
                        <div>
                            <p class=""app-notification__message"">
                                Lisa sent you a mail
                            </p>
                            <p class=""app-notification__meta"">2 min ago</p>
                        </div>
                    </a>
                </li>
                <li>
                    <a class=""app-notification__item"" href=");
            WriteLiteral(@"""javascript:;"">
                        <span class=""app-notification__icon"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fa fa-circle fa-stack-2x text-danger""></i><i class=""fa fa-hdd-o fa-stack-1x fa-inverse""></i>
                            </span>
                        </span>
                        <div>
                            <p class=""app-notification__message"">
                                Mail server not working
                            </p>
                            <p class=""app-notification__meta"">5 min ago</p>
                        </div>
                    </a>
                </li>

                <li>
                    <a class=""app-notification__item"" href=""javascript:;"">
                        <span class=""app-notification__icon"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fa fa-circle fa-stack-2x text-success""></i><i class=""fa fa-money fa-");
            WriteLiteral(@"stack-1x fa-inverse""></i>
                            </span>
                        </span>
                        <div>
                            <p class=""app-notification__message"">
                                Transaction complete
                            </p>
                            <p class=""app-notification__meta"">2 days ago</p>
                        </div>
                    </a>
                </li>
                <div class=""app-notification__content"">
                <li>
                    <a class=""app-notification__item"" href=""javascript:;"">
                        <span class=""app-notification__icon"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fa fa-circle fa-stack-2x text-primary""></i><i class=""fa fa-envelope fa-stack-1x fa-inverse""></i>
                            </span>
                        </span>
                        <div>
                            <p class=""app-notification__message""");
            WriteLiteral(@">
                                Lisa sent you a mail
                            </p>
                            <p class=""app-notification__meta"">2 min ago</p>
                        </div>
                    </a>
                </li>
                <li>
                    <a class=""app-notification__item"" href=""javascript:;"">
                        <span class=""app-notification__icon"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fa fa-circle fa-stack-2x text-danger""></i><i class=""fa fa-hdd-o fa-stack-1x fa-inverse""></i>
                            </span>
                        </span>
                        <div>
                            <p class=""app-notification__message"">
                                Mail server not working
                            </p>
                            <p class=""app-notification__meta"">5 min ago</p>
                        </div>
                    </a>
                </li>
  ");
            WriteLiteral(@"              <li>
                    <a class=""app-notification__item"" href=""javascript:;"">
                        <span class=""app-notification__icon"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fa fa-circle fa-stack-2x text-success""></i><i class=""fa fa-money fa-stack-1x fa-inverse""></i>
                            </span>
                        </span>
                        <div>
                            <p class=""app-notification__message"">
                                Transaction complete
                            </p>
                            <p class=""app-notification__meta"">2 days ago</p>
                        </div>
                    </a>
                </li>
                </div>
                </div>
                <li class=""app-notification__footer"">
                    <a href=""#"">See all notifications.</a>
                </li>
            </ul>
        </li>
        <!-- User Menu-->
       ");
            WriteLiteral(@" <li class=""dropdown"">
            <a class=""app-nav__item""
               href=""#""
               data-toggle=""dropdown""
               aria-label=""Open Profile Menu"">
                <i class=""fa fa-user fa-lg""></i>
            </a>
            <ul class=""dropdown-menu settings-menu dropdown-menu-right"">
                <li>
                    <a class=""dropdown-item"" href=""page-user.html""><i class=""fa fa-cog fa-lg""></i> Settings</a>
                </li>
                <li>
                    <a class=""dropdown-item"" href=""page-user.html""><i class=""fa fa-user fa-lg""></i> Profile</a>
                </li>
                <li>
                    <a class=""dropdown-item"" href=""page-login.html""><i class=""fa fa-sign-out fa-lg""></i> Logout</a>
                </li>
            </ul>
        </li>
    </ul>
</header>
<aside class=""app-sidebar"">
    <div class=""app-sidebar__user"">
        <div>
            <p class=""app-sidebar__user-name"">John Doe</p>
            <p class=""app-sidebar");
            WriteLiteral("__user-designation\">Frontend Developer</p>\r\n        </div>\r\n    </div>\r\n    <ul class=\"app-menu\">\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd57850e725a9d9f884b86b2d9dedff51ea4a0fc14308", async() => {
                WriteLiteral("\r\n                <i class=\"app-menu__icon fa fa-dashboard\"></i><span class=\"app-menu__label\">Trang chủ</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n\r\n        <li class=\"treeview\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd57850e725a9d9f884b86b2d9dedff51ea4a0fc16147", async() => {
                WriteLiteral("\r\n                <i class=\"app-menu__icon fa fa-laptop\"></i><span class=\"app-menu__label\">Người dùng</span>");
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        </li>\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd57850e725a9d9f884b86b2d9dedff51ea4a0fc18110", async() => {
                WriteLiteral("\r\n                <i class=\"app-menu__icon fa fa-pie-chart\"></i><span class=\"app-menu__label\">Sản phẩm</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd57850e725a9d9f884b86b2d9dedff51ea4a0fc19929", async() => {
                WriteLiteral("\r\n                <i class=\"app-menu__icon fa fa-pie-chart\"></i><span class=\"app-menu__label\">Hóa đơn</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd57850e725a9d9f884b86b2d9dedff51ea4a0fc21743", async() => {
                WriteLiteral("\r\n                <i class=\"app-menu__icon fa fa-pie-chart\"></i><span class=\"app-menu__label\">Đánh giá</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
            WriteLiteral("    </ul>\r\n</aside>");
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
