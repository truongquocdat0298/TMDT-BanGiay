#pragma checksum "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159e8c374d3d13b2451020fba3de4cd7410af4d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shoes_Details), @"mvc.1.0.view", @"/Views/Shoes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159e8c374d3d13b2451020fba3de4cd7410af4d3", @"/Views/Shoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea04604300a41ba8725795b604a394388e8fbe1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("size-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "39", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            WriteLiteral(@"    <div class=""shop-page-wrapper mt-100 mb-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  shop product content  =======-->

                    <div class=""shop-product"">
                        <div class=""row pb-100"">
                            <div class=""col-lg-6 mb-md-70 mb-sm-70"">
                                <!--=======  shop product big image gallery  =======-->

                                <div class=""shop-product__big-image-gallery-wrapper mb-30"">

                                    <!--=======  shop product gallery icons  =======-->

                                    <div class=""single-product__floating-badges single-product__floating-badges--shop-product"">
");
#line 21 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                         if (Model.shoes.IsOnNew)
                                        {

#line default
#line hidden
            WriteLiteral("                                            <span class=\"hot\">hot</span>\r\n");
#line 24 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                        }

#line default
#line hidden
#line 25 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                         if (Model.shoes.IsOnSale)
                                        {

#line default
#line hidden
            WriteLiteral("                                            <span class=\"onsale\">-10%</span>\r\n");
#line 28 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                        }

#line default
#line hidden
            WriteLiteral(@"                                    </div>


                                    <div class=""shop-product-rightside-icons"">
                                        <span class=""wishlist-icon"">
                                            <a href=""#"" data-tippy=""Add to wishlist"" data-tippy-placement=""left"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder""><i class=""ion-android-favorite-outline""></i></a>
                                        </span>
                                        <span class=""enlarge-icon"">
                                            <a class=""btn-zoom-popup"" href=""#"" data-tippy=""Click to enlarge"" data-tippy-placement=""left"" data-tippy-inertia=""true"" data-tippy-animation=""shift-away"" data-tippy-delay=""50"" data-tippy-arrow=""true"" data-tippy-theme=""sharpborder""><i class=""ion-android-expand""></i></a>
                                        </span>
                                    </div>

            WriteLiteral(@"
                                    <!--=======  End of shop product gallery icons  =======-->

                                    <div class=""shop-product__big-image-gallery-slider"">

                                        <!--=======  single image  =======-->

                                        <div class=""single-image"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 2736, "\"", 2772, 1);
#line 48 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
WriteAttributeValue("", 2742, Model.shoes.ImageThumbnailUrl, 2742, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 2791, "\"", 2797, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>

                                        <!--=======  End of single image  =======-->
                                        <!--=======  single image  =======-->

                                        <div class=""single-image"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 3134, "\"", 3161, 1);
#line 55 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
WriteAttributeValue("", 3140, Model.shoes.ImageUrl, 3140, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3180, "\"", 3186, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>

                                        <!--=======  End of single image  =======-->

                                    </div>

                                </div>

                                <!--=======  End of shop product big image gallery  =======-->
                                <!--=======  shop product small image gallery  =======-->

                                <div class=""shop-product__small-image-gallery-wrapper"">

                                    <div class=""shop-product__small-image-gallery-slider"">
                                        <!--=======  single image  =======-->

                                        <div class=""single-image scale-img-thumb"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 4001, "\"", 4037, 1);
#line 73 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
WriteAttributeValue("", 4007, Model.shoes.ImageThumbnailUrl, 4007, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4056, "\"", 4062, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>

                                        <!--=======  End of single image  =======-->
                                        <!--=======  single image  =======-->

                                        <div class=""single-image scale-img-thumb"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 4415, "\"", 4442, 1);
#line 80 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
WriteAttributeValue("", 4421, Model.shoes.ImageUrl, 4421, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4461, "\"", 4467, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>

                                        <!--=======  End of single image  =======-->

                                    </div>

                                </div>

                                <!--=======  End of shop product small image gallery  =======-->
                            </div>

                            <div class=""col-lg-6"">
                                <!--=======  shop product description  =======-->

                                <div class=""shop-product__description"">

                                    <!--=======  shop product rating  =======-->

                                    <div class=""shop-product__rating mb-15"">
                                        <span class=""product-rating"">
                                            <i class=""active ion-android-star""></i>
                                            <i class=""active ion-android-star""></i>
                                            ");
            WriteLiteral(@"<i class=""active ion-android-star""></i>
                                            <i class=""active ion-android-star""></i>
                                            <i class=""ion-android-star-outline""></i>
                                        </span>

                                        <span class=""review-link ml-20"">
                                            <a href=""#"">(3 customer reviews)</a>
                                        </span>
                                    </div>

                                    <!--=======  End of shop product rating  =======-->
                                    <!--=======  shop product title  =======-->

                                    <div class=""shop-product__title mb-15"">
                                        <h2>");
#line 117 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                       Write(Model.shoes.Name);

#line default
#line hidden
            WriteLiteral(@"</h2>
                                    </div>

                                    <!--=======  End of shop product title  =======-->
                                    <!--=======  shop product price  =======-->

                                    <div class=""shop-product__price mb-30"">
");
#line 124 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                         if (Model.shoes.IsOnSale == true)
                                        {


#line default
#line hidden
            WriteLiteral("                                            <span class=\"main-price discounted\">$");
#line 127 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                                                             Write(Model.shoes.Price + (Model.shoes.Price * 10 / 100));

#line default
#line hidden
            WriteLiteral("</span>\r\n                                            <span class=\"discounted-price\">$");
#line 128 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                                                       Write(Model.shoes.Price);

#line default
#line hidden
            WriteLiteral("</span>\r\n");
#line 129 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            WriteLiteral("                                            <span class=\"main-price\">$");
#line 132 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                                                 Write(Model.shoes.Price);

#line default
#line hidden
            WriteLiteral("</span>\r\n");
#line 133 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                        }

#line default
#line hidden
            WriteLiteral(@"                                    </div>

                                    <!--=======  End of shop product price  =======-->
                                    <!--=======  shop product short description  =======-->

                                    <div class=""shop-product__short-desc mb-50"">
                                        ");
#line 140 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                   Write(Model.shoes.Description);

#line default
#line hidden
            WriteLiteral(@"
                                    </div>

                                    <!--=======  End of shop product short description  =======-->
                                    <!--=======  shop product size block  =======-->
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "159e8c374d3d13b2451020fba3de4cd7410af4d318365", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "159e8c374d3d13b2451020fba3de4cd7410af4d318664", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 146 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.shoesId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 146 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
                                                                           WriteLiteral(Model.shoes.ShoesId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"        
                                        <div class=""shop-product__block shop-product__block--size mb-20"">
                                            <div class=""shop-product__block__title"">Size: </div>
                                            <div class=""shop-product__block__value"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "159e8c374d3d13b2451020fba3de4cd7410af4d321369", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 150 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.size);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <!--=======  End of shop product size block  =======-->
                                        <!--=======  shop product quantity block  =======-->

                                        <div class=""shop-product__block shop-product__block--quantity mb-40"">
                                            <div class=""shop-product__block__title"">Quantity: </div>
                                            <div class=""shop-product__block__value"">
                                                <div class=""pro-qty d-inline-block mx-0 pt-0"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "159e8c374d3d13b2451020fba3de4cd7410af4d324398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 161 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.quantity);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>

                                        <!--=======  End of shop product quantity block  =======-->
                                        <!--=======  shop product buttons  =======-->

                                        <div class=""shop-product__buttons mb-40"">
                                            <button type=""submit"" class=""lezada-button lezada-button--medium"" >add to cart</button>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 145 "C:\Users\kysui\source\repos\Shop Shoes\ShoesClient\Views\Shoes\Details.cshtml"
AddHtmlAttributeValue("", 7911, Model.shoes.ShoesId, 7911, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <!--=======  End of shop product buttons  =======-->


                                </div>

                                <!--=======  End of shop product description  =======-->
                            </div>
                        </div>


                    </div>

                    <!--=======  End of shop product content  =======-->
                </div>
            </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591