#pragma checksum "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79189eb689ca1224d577707262e4d413a05cfb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\_ViewImports.cshtml"
using ShoesClient;

#line default
#line hidden
#line 2 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\_ViewImports.cshtml"
using ShoesClient.Models;

#line default
#line hidden
#line 3 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\_ViewImports.cshtml"
using ShoesClient.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\_ViewImports.cshtml"
using ShoesClient.Infrastructure;

#line default
#line hidden
#line 5 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 6 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\_ViewImports.cshtml"
using ShoesClient.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79189eb689ca1224d577707262e4d413a05cfb3", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea04604300a41ba8725795b604a394388e8fbe1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lezada-button lezada-button--medium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Charge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""shopping-cart-area mb-130"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 mb-30"">
                <!--=======  cart table  =======-->

                <div class=""cart-table-container"">
                    <table class=""cart-table"">
                        <thead>
                            <tr>
                                <th class=""product-name"" colspan=""2"">Product</th>
                                <th class=""product-price"">Price</th>
                                <th class=""product-quantity"">Quantity</th>
                                <th class=""product-quantity"">Size</th>
                                <th class=""product-subtotal"">Total</th>
                                <th class=""product-remove"">&nbsp;</th>
                            </tr>
                        </thead>

                        <tbody>
");
#line 22 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                             foreach (var line in Model.Lines)
                            {

#line default
#line hidden
            WriteLiteral("                                <tr>\r\n                                    <td class=\"product-thumbnail\">\r\n                                        <a href=\"shop-product-basic.html\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1250, "\"", 1285, 1);
#line 27 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1256, line.Shoes.ImageThumbnailUrl, 1256, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1304, "\"", 1310, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                    </td>\r\n                                    <td class=\"product-name\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79189eb689ca1224d577707262e4d413a05cfb38499", async() => {
#line 31 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                                                                                                     Write(line.Shoes.Name);

#line default
#line hidden
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
#line 31 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                                                                         WriteLiteral(line.Shoes.ShoesId);

#line default
#line hidden
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
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td class=\"product-price\"><span class=\"price\">$");
#line 34 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                                                              Write(line.Shoes.Price);

#line default
#line hidden
            WriteLiteral("</span></td>\r\n\r\n                                    <td class=\"product-quantity\">\r\n\r\n                                        ");
#line 38 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                   Write(line.Quantity);

#line default
#line hidden
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td class=\"product-quantity\">\r\n\r\n                                        ");
#line 43 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                   Write(line.Size);

#line default
#line hidden
            WriteLiteral("\r\n\r\n                                    </td>\r\n\r\n                                    <td class=\"total-price\"><span class=\"price\">$");
#line 47 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                                                             Write(line.Shoes.Price * line.Quantity);

#line default
#line hidden
            WriteLiteral("</span></td>\r\n\r\n                                    <td class=\"product-remove\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79189eb689ca1224d577707262e4d413a05cfb312732", async() => {
                WriteLiteral("\r\n                                            <i class=\"ion-android-close\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartLineID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                                                                                       WriteLiteral(line.CartLineID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartLineID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartLineID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartLineID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#line 55 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
            WriteLiteral(@"

                        </tbody>
                    </table>
                </div>

                <!--=======  End of cart table  =======-->
            </div>
            <div class=""col-lg-12 mb-80"">
                <!--=======  coupon area  =======-->

                <div class=""cart-coupon-area pb-30"">
                    <div class=""row align-items-center"">

                        <div class=""col-lg-12 text-left text-lg-right"">
                            <!--=======  update cart button  =======-->

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79189eb689ca1224d577707262e4d413a05cfb316108", async() => {
                WriteLiteral("Continue Shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <!--=======  End of update cart button  =======-->\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <!--=======  End of coupon area  =======-->\r\n            </div>\r\n");
#line 82 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
             if (Model.Lines.Count() > 0)
            {

#line default
#line hidden
            WriteLiteral(@"                <div class=""col-xl-4 offset-xl-8 col-lg-5 offset-lg-7"">
                    <div class=""cart-calculation-area"">
                        <h2 class=""mb-40"">Cart totals</h2>

                        <table class=""cart-calculation-table mb-30"">
                            <tr>
                                <th>TOTAL</th>
                                <td class=""total"">");
#line 91 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
                                             Write(Model.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </table>\r\n\r\n                        <div class=\"cart-calculation-button text-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79189eb689ca1224d577707262e4d413a05cfb318877", async() => {
                WriteLiteral("proceed to checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#line 100 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
