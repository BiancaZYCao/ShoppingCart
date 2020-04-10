#pragma checksum "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b8759894e112657d46aad050fdd38c8b9032e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewProduct), @"mvc.1.0.view", @"/Views/Home/ViewProduct.cshtml")]
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
#line 1 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b8759894e112657d46aad050fdd38c8b9032e0", @"/Views/Home/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reviewForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
                                          
    var selectedProduct = (Product)ViewData["selectedProduct"];
    var recommendProducts = (List<Product>)ViewData["recommendedProducts"];
    var selectedProductDetails = ViewData["selectedProductDetails"];
    var rating = (int)ViewData["Rating"];
    var imageFileName = selectedProduct.Name + ".jpg";
    string finalRating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
  
    if (rating == 0)
    {
        finalRating = "No Rating";
    }
    else
    {
        finalRating = rating.ToString() + "/5";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"ProductDetail-Section row\">\r\n    <div class=\"image-display col-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3b8759894e112657d46aad050fdd38c8b9032e06470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 663, "~/Images/", 663, 9, true);
#nullable restore
#line 24 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
AddHtmlAttributeValue("", 672, imageFileName, 672, 14, false);

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
            WriteLiteral("\r\n    </div>\r\n    <div class=\"ProductDetail-display col-9\">\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n                <p>Name: </p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <p>");
#nullable restore
#line 32 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
              Write(selectedProduct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n                <p>Rating: </p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <p>");
#nullable restore
#line 40 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
              Write(finalRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n                <p>Genre: </p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <p>");
#nullable restore
#line 48 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
              Write(selectedProduct.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n                <p>Description: </p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <p>");
#nullable restore
#line 56 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
              Write(selectedProduct.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n                <p>Price: </p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <p>$");
#nullable restore
#line 64 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
               Write(selectedProduct.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <h3>Recommendations</h3>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 74 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
     foreach (var recommendProduct in recommendProducts)
    {
        imageFileName = recommendProduct.Name + ".jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-auto\">\r\n            <div class=\"row\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3b8759894e112657d46aad050fdd38c8b9032e010971", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2247, "~/Images/", 2247, 9, true);
#nullable restore
#line 79 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
AddHtmlAttributeValue("", 2256, imageFileName, 2256, 14, false);

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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3b8759894e112657d46aad050fdd38c8b9032e012642", async() => {
#nullable restore
#line 83 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
                                                                                                                             Write(recommendProduct.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-selected", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
                                                                                              WriteLiteral(recommendProduct.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selected", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 86 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <h3>Reviews</h3>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3b8759894e112657d46aad050fdd38c8b9032e015917", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <p>Rating: </p>
        <span class=""star-rating"">
            <input type=""radio"" class=""ratingBtn"" name=""rating"" value=""1""><i></i>
            <input type=""radio"" class=""ratingBtn"" name=""rating"" value=""2""><i></i>
            <input type=""radio"" class=""ratingBtn"" name=""rating"" value=""3""><i></i>
            <input type=""radio"" class=""ratingBtn"" name=""rating"" value=""4""><i></i>
            <input type=""radio"" class=""ratingBtn"" name=""rating"" value=""5""><i></i>
        </span>
    </div>
    <div class=""row"">
        <textarea rows=""4"" class=""col-auto"" name=""comment"" form=""reviewForm"" placeholder=""Add your review here..."">
        </textarea>
    </div>
    <div class=""row"" align=""right"">
        <input type=""hidden"" name=""trackProduct""");
                BeginWriteAttribute("value", " value=\"", 3569, "\"", 3598, 1);
#nullable restore
#line 109 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 3577, selectedProduct.Name, 3577, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"button\" id=\"addCommentBtn\" value=\"Submit\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("<div class=\"row\" align=\"center\">\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th class=\"col-auto\">Users</th>\r\n            <th class=\"col-auto\">Ratings</th>\r\n            <th class=\"col-auto\">Comments</th>\r\n        </tr>\r\n");
#nullable restore
#line 123 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
         if (selectedProductDetails != null)
        {
            foreach (var selectedProductDetail in (List<ProductDetail>) selectedProductDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"col-auto\">");
#nullable restore
#line 128 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
                                    Write(selectedProductDetail.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-auto\">");
#nullable restore
#line 129 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
                                    Write(selectedProductDetail.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-auto\">");
#nullable restore
#line 130 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
                                    Write(selectedProductDetail.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 132 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n                <td colspan=\"2\" class=\"col-auto\">No Reviews</td>\r\n            </tr>\r\n");
#nullable restore
#line 139 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\ViewProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    \r\n</div>\r\n\r\n\r\n");
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
