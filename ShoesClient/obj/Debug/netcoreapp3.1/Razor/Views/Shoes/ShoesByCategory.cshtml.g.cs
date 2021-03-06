#pragma checksum "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdaddc0264c930b48c80bec3c96dda023f34da1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shoes_ShoesByCategory), @"mvc.1.0.view", @"/Views/Shoes/ShoesByCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdaddc0264c930b48c80bec3c96dda023f34da1f", @"/Views/Shoes/ShoesByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea04604300a41ba8725795b604a394388e8fbe1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shoes_ShoesByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shoes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image-wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
  
    ViewData["Title"] = "Shoes";

#line default
#line hidden
            WriteLiteral(@"<div class=""shop-page-wrapper"">

    <!--=======  shop page header  =======-->

    <div class=""shop-page-header"">
        <div class=""container wide"">
            <div class=""row align-items-center"">

                <div class=""col-12 col-lg-7 col-md-12 d-none d-md-block"">
                    <!--=======  fitler titles  =======-->
                    <div class=""filter-title filter-title--type-two"">
                        <ul class=""product-filter-menu"">
                            <li class=""active"" data-filter=""*"">All</li>
                            <li data-filter="".new"">new products</li>
                            <li data-filter="".sale"">sale products</li>
                        </ul>
                    </div>
                    <!--=======  End of fitler titles  =======-->
                </div>



            </div>
        </div>
    </div>




    <!--=====  End of shop advance filter area  ======-->
    <!--=============================================
    =    ");
            WriteLiteral(@"        shop page content         =
    =============================================-->

    <div class=""shop-page-content mt-100 mb-100"">
        <div class=""container wide"">
            <div class=""row"">
                <div class=""col-lg-12 order-1 order-lg-2 mb-md-80 mb-sm-80"">

                    <div class=""row product-isotope shop-product-wrap five-column"">
");
#line 45 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                         foreach (var shoes in Model)
                        {

#line default
#line hidden
            WriteLiteral("                            <!--=======  single product  =======-->\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1653, "\"", 1758, 8);
            WriteAttributeValue("", 1661, "col-12", 1661, 6, true);
            WriteAttributeValue(" ", 1667, "col-lg-is-5", 1668, 12, true);
            WriteAttributeValue(" ", 1679, "col-md-6", 1680, 9, true);
            WriteAttributeValue(" ", 1688, "col-sm-6", 1689, 9, true);
            WriteAttributeValue(" ", 1697, "mb-45", 1698, 6, true);
#line 48 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
WriteAttributeValue(" ", 1703, shoes.IsOnNew?"new":"", 1704, 25, false);

#line default
#line hidden
#line 48 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
WriteAttributeValue(" ", 1729, shoes.IsOnSale?"sale":"", 1730, 27, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1757, "", 1758, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""single-product"">
                                    <!--=======  single product image  =======-->

                                    <div class=""single-product__image"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdaddc0264c930b48c80bec3c96dda023f34da1f7817", async() => {
                WriteLiteral("\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 2168, "\"", 2198, 1);
#line 54 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
WriteAttributeValue("", 2174, shoes.ImageThumbnailUrl, 2174, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 2217, "\"", 2223, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 2275, "\"", 2296, 1);
#line 55 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
WriteAttributeValue("", 2281, shoes.ImageUrl, 2281, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 2315, "\"", 2321, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                                                                                            WriteLiteral(shoes.ShoesId);

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
            WriteLiteral("\r\n\r\n                                        <div class=\"single-product__floating-badges\">\r\n");
#line 59 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                             if (shoes.IsOnNew)
                                            {

#line default
#line hidden
            WriteLiteral("                                                <span class=\"hot\">hot</span>\r\n");
#line 62 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                            }

#line default
#line hidden
#line 63 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                             if (shoes.IsOnSale)
                                            {

#line default
#line hidden
            WriteLiteral("                                                <span class=\"onsale\">-10%</span>\r\n");
#line 66 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                            }

#line default
#line hidden
            WriteLiteral(@"                                        </div>

                                        <div class=""single-product__floating-icons"">
                                            <span class=""wishlist""><a href=""#"" data-tippy=""Add to wishlist"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"" data-tippy-placement=""left""><i class=""ion-android-favorite-outline""></i></a></span>

                                            <span class=""compare""><a href=""#"" data-tippy=""Compare"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder"" data-tippy-placement=""left""><i class=""ion-ios-shuffle-strong""></i></a></span>

                                            <span class=""quickview""><a class=""cd-trigger"" href=""#qv-1"" data-tippy=""Quick View"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-t");
            WriteLiteral(@"ippy-theme=""sharpborder"" data-tippy-placement=""left""><i class=""ion-ios-search-strong""></i></a></span>
                                        </div>


                                    </div>

                                    <!--=======  End of single product image  =======-->
                                    <!--=======  single product content  =======-->

                                    <div class=""single-product__content"">
                                        <div class=""title"">
                                            <h3> <a href=""shop-product-basic.html"">");
#line 85 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                                                              Write(shoes.Name);

#line default
#line hidden
            WriteLiteral("</a></h3>\r\n                                            <a href=\"#\">Select options</a>\r\n                                        </div>\r\n                                        <div class=\"price\">\r\n");
#line 89 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                             if (shoes.IsOnSale == true)
                                            {


#line default
#line hidden
            WriteLiteral("                                                <span class=\"main-price discounted\">$");
#line 92 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                                                                 Write(shoes.Price + (shoes.Price * 10 / 100));

#line default
#line hidden
            WriteLiteral("</span>\r\n                                                <span class=\"discounted-price\">$");
#line 93 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                                                           Write(shoes.Price);

#line default
#line hidden
            WriteLiteral("</span>\r\n");
#line 94 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            WriteLiteral("                                                <span class=\"main-price\">$");
#line 97 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                                                     Write(shoes.Price);

#line default
#line hidden
            WriteLiteral("</span>\r\n");
#line 98 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                                            }

#line default
#line hidden
            WriteLiteral(@"                                        </div>
                                    </div>

                                    <!--=======  End of single product content  =======-->
                                </div>

                            </div>
                            <!--=======  End of single product  =======-->
");
#line 107 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\ShoesByCategory.cshtml"
                        }

#line default
#line hidden
            WriteLiteral(@"
                    </div>

                    <div class=""row"">
                        <div class=""col-lg-12 text-center mt-30"">
                            <a class=""lezada-button lezada-button--medium lezada-button--icon--left"" href=""#""><i class=""ion-android-add""></i> MORE</a>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <!--=====  End of shop page content  ======-->
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shoes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
