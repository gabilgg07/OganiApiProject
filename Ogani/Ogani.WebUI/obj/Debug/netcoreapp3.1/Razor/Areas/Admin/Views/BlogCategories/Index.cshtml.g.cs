#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dccb4971d9d7f8614ccecc123fbf208f92217f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.BlogCategories.Areas_Admin_Views_BlogCategories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogCategories/Index.cshtml")]
namespace Ogani.WebUI.Views.BlogCategories
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
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.Entity.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Areas.Admin.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Resource;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dccb4971d9d7f8614ccecc123fbf208f92217f6", @"/Areas/Admin/Views/BlogCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c16ec933f450aeafb6cbc4b9c34753067bce6f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BlogCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogCategory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-cons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-cons min-w-0 mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-cons min-w-0 mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowToastr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendMsg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
  
    ViewData["Title"] = "Blog-Categories Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 115, "\"", 141, 1);
#nullable restore
#line 7 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
WriteAttributeValue("", 123, ViewBag.ToastrMsg, 123, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"hasMessage\" />\r\n\r\n<ul class=\"breadcrumb\">\r\n    <li>\r\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f69886", async() => {
                WriteLiteral("Admin");
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
            WriteLiteral("</p>\r\n    </li>\r\n    <li><a class=\"active\">Blog Categories</a> </li>\r\n</ul>\r\n<div class=\"page-title\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f611345", async() => {
                WriteLiteral("\r\n        <i class=\"far fa-arrow-alt-circle-left\"></i>\r\n    ");
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
    <h3>Admin</h3>
</div>


<div class=""row-fluid"">
    <div class=""span12 w-60"">
        <div class=""grid simple "">
            <div class=""grid-body "" id=""formData"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 31 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"text-center w-25\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f613543", async() => {
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 39 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"vertical-middle\">\r\n                                    ");
#nullable restore
#line 43 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center vertical-middle\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f615846", async() => {
                WriteLiteral("<i class=\"fa fa-pencil\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f618173", async() => {
                WriteLiteral("<i class=\"fa fa-info-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1943, "\"", 1986, 5);
            WriteAttributeValue("", 1953, "removeItem(", 1953, 11, true);
#nullable restore
#line 48 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
WriteAttributeValue("", 1964, item.Id, 1964, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1972, ",\'", 1972, 2, true);
#nullable restore
#line 48 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
WriteAttributeValue("", 1974, item.Name, 1974, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1984, "\')", 1984, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-cons min-w-0 mb-0\"><i class=\"fa fa-trash-o\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 51 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                ");
#nullable restore
#line 54 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div style=\"visibility:hidden;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f622239", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"toastrMsg\" id=\"toastrMsg\"");
                BeginWriteAttribute("value", " value=\"", 2480, "\"", 2488, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb4971d9d7f8614ccecc123fbf208f92217f624352", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script class=""removeable"">
        $(document).ready(function () {
            if ($('#hasMessage').val().trim()) {
                toastr.success(`${$('#hasMessage').val()}`, ""Ugur"");
            }
        });

        function removeItem(_id, name) {

            let frmData = $('#formData').getFormData({
                id: _id
                });

            swal({
                title: ""Diqqet!"",
                text: `Eminsiniz ki, ""${name}"" sistemden silinsin?`,
                icon: ""warning"",
                buttons: [""Xeyr"", ""Beli""],
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {
                        $.ajax({
                            url: '");
#nullable restore
#line 93 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/BlogCategories/Index.cshtml"
                             Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                            type: 'POST',
                            data: frmData,
                            success: function (response) {
                                if (response.error) {
                                    toastr.error(response.message, ""Xeta"");
                                    return;
                                }
                                $('#toastrMsg').val(response.message);
                                $('#sendMsg').submit();

                            },
                            error: function (response) {
                                toastr.error(""Gozlenilmez xeta bas verdi"", ""Ugursuz oldu"");
                            },
                        });
                    }
                });
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
