#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f07dacb82bf461476ab021c0c35131f97928ed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Ogani.WebUI.Views.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f07dacb82bf461476ab021c0c35131f97928ed1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34838ecca90a5958fb7f48066470e908e62e27b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Home Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""categories"">
    <div class=""container"">
        <div class=""row"">
            <div class=""categories-slider owl-carousel"">
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-1.jpg"">
                        <h5><a href=""#"">Fresh Fruit</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-2.jpg"">
                        <h5><a href=""#"">Dried Fruit</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-3.jpg"">
                        <h5><a href=""#"">Vegetables</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories");
            WriteLiteral(@"/cat-4.jpg"">
                        <h5><a href=""#"">drink fruits</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-5.jpg"">
                        <h5><a href=""#"">drink fruits</a></h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""featured spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <h2>");
#nullable restore
#line 46 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
                   Write(LayoutResource.FeaturedProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
                <div class=""featured-controls"">
                    <ul>
                        <li class=""active"" data-filter=""*"">All</li>
                        <li data-filter="".oranges"">Oranges</li>
                        <li data-filter="".fresh-meat"">Fresh Meat</li>
                        <li data-filter="".vegetables"">Vegetables</li>
                        <li data-filter="".fastfood"">Fastfood</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row featured-filter"">
            <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fresh-meat"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-1.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
        ");
            WriteLiteral(@"                    <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fastfood"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-2.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
     ");
            WriteLiteral(@"                   <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fresh-meat"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-3.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class");
            WriteLiteral(@"=""col-lg-3 col-md-4 col-sm-6 mix fastfood oranges"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-4.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-");
            WriteLiteral(@"5.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fastfood"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-6.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i cl");
            WriteLiteral(@"ass=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-7.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
              ");
            WriteLiteral(@"      <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood vegetables"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-8.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>");
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>


<div class=""banner"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""banner-pic"">
                    <img src=""assets/img/banner/banner-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9179, "\"", 9185, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n            </div>\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\n                <div class=\"banner-pic\">\n                    <img src=\"assets/img/banner/banner-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9385, "\"", 9391, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
</div>


<section class=""latest-product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product-text"">
                    ");
#nullable restore
#line 208 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
               Write(await Component.InvokeAsync("SpecialProducts", new
               {
                   caption = LayoutResource.LatestProducts,
                   reportType = ProductReportType.Latest
               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-lg-4 col-md-6\">\n                <div class=\"latest-product-text\">\n                    ");
#nullable restore
#line 217 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
               Write(await Component.InvokeAsync("SpecialProducts", new
               {
                   caption = LayoutResource.TopRatedProducts,
                   reportType = ProductReportType.Review
               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-lg-4 col-md-6\">\n                <div class=\"latest-product-text\">\n                    ");
#nullable restore
#line 226 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
               Write(await Component.InvokeAsync("SpecialProducts", new
               {
                   caption = LayoutResource.ReviewProducts,
                   reportType = ProductReportType.TopRated
               }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""from-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title from-blog-title"">
                    <h2>");
#nullable restore
#line 243 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
                   Write(LayoutResource.FromTheBlog);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11211, "\"", 11217, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11976, "\"", 11982, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12743, "\"", 12749, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
