#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a16444fe06198489e0daca1adaafe0aacfecc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Shop.Views_Shop_ShoppingCard), @"mvc.1.0.view", @"/Views/Shop/ShoppingCard.cshtml")]
namespace Ogani.WebUI.Views.Shop
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
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.Application.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Resource;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a16444fe06198489e0daca1adaafe0aacfecc3", @"/Views/Shop/ShoppingCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34838ecca90a5958fb7f48066470e908e62e27b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_ShoppingCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
  
    ViewBag.Title = "Shopping Card";

#line default
#line hidden
#nullable disable
            DefineSection("addcss", async() => {
                WriteLiteral("\n    <style>\n        .shoping-cart-item img {\n            width: 100px;\n            height: 100px;\n            object-fit: cover;\n            object-position: center;\n        }\n    </style>\n");
            }
            );
            WriteLiteral(@"
<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Shopping Cart</h2>
                    <div class=""breadcrumb-option"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a16444fe06198489e0daca1adaafe0aacfecc38260", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <span>Shopping Cart</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""shoping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping-cart-table"">
                    <table>
                        <thead>
                            <tr>
                                <th class=""shoping-product"">Products</th>
                                <th>Price</th>
                                <th>Quantity</th>
                                <th>Total</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 49 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr data-product-id=\"");
#nullable restore
#line 53 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                                    Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                        <td class=\"shoping-cart-item\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8a16444fe06198489e0daca1adaafe0aacfecc311477", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1844, "~/uploads/images/products/", 1844, 26, true);
#nullable restore
#line 55 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
AddHtmlAttributeValue("", 1870, item.ImagePath, 1870, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 55 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
AddHtmlAttributeValue("", 1892, item.Name, 1892, 10, false);

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
            WriteLiteral("\n                                            <h5>");
#nullable restore
#line 56 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                        </td>\n                                        <td class=\"shoping-cart-price\">\n                                            ");
#nullable restore
#line 59 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                       Write(item.Price.ToString("$0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td class=""shoping-cart-quantity"">
                                            <div class=""quantity"">
                                                <div class=""pro-qty"">
                                                    <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 2489, "\"", 2508, 1);
#nullable restore
#line 64 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
WriteAttributeValue("", 2497, item.Count, 2497, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                </div>
                                            </div>
                                        </td>
                                        <td class=""shoping-cart-total"">
                                            ");
#nullable restore
#line 69 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                       Write(item.Amount.ToString("$0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td class=""shoping-cart-item-close"">
                                            <span class=""icon_close""></span>
                                        </td>
                                    </tr>
");
#nullable restore
#line 75 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Shop/ShoppingCard.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-lg-12\">\n                <div class=\"shoping-cart-btns\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a16444fe06198489e0daca1adaafe0aacfecc316601", async() => {
                WriteLiteral("CONTINUE SHOPPING");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a href=""#"" class=""primary-btn cart-btn cart-btn-right"">
                        <span class=""icon_loading""></span>
                        Upadate Cart
                    </a>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping-continue"">
                    <div class=""shoping-discount"">
                        <h5>Discount Codes</h5>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a16444fe06198489e0daca1adaafe0aacfecc318493", async() => {
                WriteLiteral("\n                            <input type=\"text\" placeholder=\"Enter your coupon code\">\n                            <button type=\"submit\" class=\"site-btn\">APPLY COUPON</button>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            <div class=""col-lg-6"">
                <div class=""shoping-checkout"">
                    <h5>Cart Total</h5>
                    <ul>
                        <li>Subtotal <span id=""subtotal""></span></li>
                        <li>Total <span id=""total""></span></li>
                    </ul>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a16444fe06198489e0daca1adaafe0aacfecc320399", async() => {
                WriteLiteral("PROCEED TO CHECKOUT");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"

    <script class=""removeable"">

        //function qtyChanged2(value, tr) {
        //    let priceStr = $(tr).find("".shoping-cart-price"").text().trim();
        //    let price = priceStr.substring(1);
        //    let symb = priceStr.substring(0, 1);
        //    let total = (price * value).toFixed(2);
        //    $(tr).find("".shoping-cart-total"").text(`${symb}${total}`);

        //    // yuxaridaki sekilde tehlukelidir, cunki, yoxlanis olmur.
        //}

        function qtyChanged(value, tr, operation) {
            // asagidaki sekilde tehlukesizdir:

            let priceStr = $(tr).find(""td.shoping-cart-price"").text().trim();
            let groups = /^(\$)(\d+(\.|,)\d{1,2})$/.exec(priceStr);
            if (groups != null) {
                let symb = groups[1];
                let price = groups[2].replace("","",""."");
                let amount = (price * value).toFixed(2);

                $(tr).find(""td.shoping-cart-total"").text(`${symb}${amount}`);

                computeTotalSum();

     ");
                WriteLiteral(@"           // start: basket change data

                let arr = [];
                var storedJson = $.cookie('basket');

                if (storedJson != undefined && typeof storedJson == 'string') {
                    arr = JSON.parse(storedJson);
                }

                let productId = $(tr).data('product-id');

                var found = arr.filter(item => {
                    return item.productId == productId;
                })[0];

                if (found == undefined) {
                    found = {
                        productId: productId,
                        count: 1
                    };
                    arr.push(found);
                } else {
                    if (operation) {
                        found.count++;
                    } else {
                        if (found.count > 1) {
                            found.count--;
                        } else {
                            found.count = 1;
                        }
                    }
     ");
                WriteLiteral(@"           }

                var jsonStrinfy = JSON.stringify(arr);

                $.cookie('basket', jsonStrinfy, { expires: 60, path: '/' });

                showBasketCount();

                // end: basket change data
            }
        }

        function computeTotalSum() {

            let prices = $(""td.shoping-cart-total"").map((i, p) => {
                let groups = /^(\$)(\d+(\.|,)\d{1,2})$/.exec($(p).text().trim());
                if (groups == null) return 0;
                let price = groups[2].replace("","", ""."");
                return parseFloat(price);
            });

            let sum = 0;
            if (prices.length != 0) {
                sum = prices.toArray().reduce(function (a, b) {
                    return a + b;
                });
            }

            $(""#subtotal"").text(`$${sum.toFixed(2)}`);
            $(""#total"").text(`$${sum.toFixed(2)}`);
        }

        //function computeTotalSum2() {
        //    let prices = $(""td.shoping-cart-price"")
        //    ");
                WriteLiteral(@"    .toArray()
        //        .map((p) => {
        //            let input = $(p).closest(""tr"").find('.pro-qty input[type=""text""]').val();
        //            let groups = /^(\$)(\d+\.\d{1,2})$/.exec(p.innerText);
        //            if (groups == null) return 0;
        //            let price = groups[2];

        //            return parseFloat(price) * parseFloat(input);
        //        });

        //    if (prices.length == 0) {
        //        $(""#subtotal"").text(`$0.00`);
        //        return;
        //    }
        //    let sum = 0;
        //    if (prices.length != 0) {
        //        sum = prices.reduce(function (a, b) {
        //            return a + b;
        //        });
        //    }

        //    $(""#subtotal"").text(`$${sum.toFixed(2)}`);
        //}

        if ($(""td.shoping-cart-total"").length != 0) {
            computeTotalSum();
        }

        $("".shoping-cart-item-close"").on(""click"", function (e) {
            e.preventDefault();

            let product");
                WriteLiteral(@"Id = $(e.currentTarget).closest(""tr"").data('product-id');
            $(e.currentTarget).closest(""tr"").remove();

            computeTotalSum();


            // start: basket remove item

            let arr = [];
            var storedJson = $.cookie('basket');

            if (storedJson != undefined && typeof storedJson == 'string') {
                arr = JSON.parse(storedJson);
            }

            arr = arr.filter(item => item.productId != productId)
            var jsonStrinfy = JSON.stringify(arr);

            $.cookie('basket', jsonStrinfy, { expires: 60, path: '/' });

            showBasketCount();
            // end : basket remove item
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
