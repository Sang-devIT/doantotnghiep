#pragma checksum "C:\Users\ASUS\Desktop\LaptopShop\LaptopShop\Views\Home\product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a162d8127005ac72a32e9a104df177b5bf82024d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a162d8127005ac72a32e9a104df177b5bf82024d", @"/Views/Home/product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7744e0287f69a68d6cc5517a1538b1284205ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"wrap-content\">\r\n\r\n    <div class=\"content-main\">\r\n        <div class=\"title-main\"><span>Sản phẩm</span></div>\r\n");
            WriteLiteral("        <div class=\"product-content  d-flex flex-wrap w-clear\">\r\n");
            WriteLiteral(@"
            <div class=""product-items-detail"">
                <div class=""product-item"">
                    <div class=""product-image"">
                        <a href=""<?=$v[$sluglang]?>"">
                            <img class='lazy' onerror=""this.src='http://localhost:8080/laptopannhien_638622W/thumbs/540x418x1/assets/images/noimage.png';"" data-src='http://localhost:8080/laptopannhien_638622W/thumbs/540x418x1/upload/product/untitled-7-copy-7819.jpg' alt='Lenovo Legion 5 17″ Gen 6 (AMD) (2022)' />
                        </a>
                        <p></p>
                    </div>
                    <div class=""product-desc"">
                        <h3 class=""product-name""><a href=""lenovo-legion-5-17-gen-6-amd-2022"">Lenovo Legion 5 17″ Gen 6 (AMD) (2022)</a></h3>
                        <p class=""product-struct""><span>CPU</span>   AMD Ryzen™ 5 5600H Up To 4.2GHz (6 Cores 19MB Cache)</p>
                        <p class=""product-struct""><span>RAM</span>   DDR4 8GB 3200MHz</p>
           ");
            WriteLiteral(@"             <p class=""product-struct""><span>SSD</span>   256GB PCIe M.2 SSD</p>
                        <p class=""product-struct""><span>VGA</span>   NVIDIA GeForce® GTX 1650 4GB GDDR6</p>
                    </div>
                    <p class=""product-price"">
                        Giá từ:<span class='price-new'>23.500.000<sup>đ</sup></span>
                    </p>
                </div>
            </div>
");
            WriteLiteral("        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591