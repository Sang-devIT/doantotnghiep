#pragma checksum "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8576d6de95a36d9613ab820047fe08f2fb387092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_product), @"mvc.1.0.view", @"/Views/Home/product.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\_ViewImports.cshtml"
using LaptopShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\_ViewImports.cshtml"
using LaptopShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\_ViewImports.cshtml"
using LaptopShop.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8576d6de95a36d9613ab820047fe08f2fb387092", @"/Views/Home/product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f66d9f5e6cfba72e344d82a22442955372af3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LaptopShop.Areas.Admin.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product_details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"wrap-content\">\r\n    \r\n    <div class=\"content-main\">\r\n        <div class=\"title-main\"><span>S???n ph???m</span></div>\r\n");
            WriteLiteral("       \r\n");
            WriteLiteral("            \r\n    <div class=\"product-items-detail\">\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-item\">\r\n                <div class=\"product-image\">\r\n                    <a href=\"<?=$v[$sluglang]?>\">\r\n                        <img class=\'lazy\'");
            BeginWriteAttribute("onerror", " onerror=\"", 579, "\"", 614, 5);
            WriteAttributeValue("", 589, "this.src", 589, 8, true);
            WriteAttributeValue(" ", 597, "=", 598, 2, true);
            WriteAttributeValue(" ", 599, "\'", 600, 2, true);
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
WriteAttributeValue("", 601, item.Image, 601, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 612, "\';", 612, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-src=\'");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                                                   Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' alt=\'Lenovo Legion 5 17??? Gen 6 (AMD) (2022)\' />\r\n                    </a>\r\n                    <p></p>\r\n                </div>\r\n                <div class=\"product-desc\">\r\n                    <h3 class=\"product-name\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8576d6de95a36d9613ab820047fe08f2fb3870925724", async() => {
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("</h3>\r\n                    <p class=\"product-struct\"><span>CPU</span>  ");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                           Write(item.Cpu);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <p class=\"product-struct\"><span>RAM</span>  ");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                           Write(item.Ram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"product-struct\"><span>SSD</span>  ");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                           Write(item.Storage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"product-struct\"><span>VGA</span>   ");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                                            Write(item.Graphics);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <p class=\"product-price\">\r\n                    Gi?? t???:<span class=\'price-new\'>");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
                                              Write(item.Price.ToString("#,##0 VN??"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </p>
                <p class=""cart-product d-flex flex-wrap justify-content-between"">
                    <span class=""cart-add addcart transition"">th??m v??o gi??? h??ng</span>
                    <span class=""cart-buy addcart transition"">mua ngay</span>
                </p>
            </div>
");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n           \r\n");
            WriteLiteral("    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LaptopShop.Areas.Admin.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
