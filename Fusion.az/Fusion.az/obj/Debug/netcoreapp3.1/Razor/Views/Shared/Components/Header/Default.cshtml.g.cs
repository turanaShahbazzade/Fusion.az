#pragma checksum "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02697e637fb8bf286ea72929dfca549618d4495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\_ViewImports.cshtml"
using Fusion.az;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\_ViewImports.cshtml"
using Fusion.az.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\_ViewImports.cshtml"
using Fusion.az.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02697e637fb8bf286ea72929dfca549618d4495", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21e35f525d6e1b694e626cd9493ed766d4f164f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search_form_top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <header id=""header"" class=""header"">
        <div class=""header-top bg-theme-color-2 sm-text-center p-0"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""widget no-border m-0"">
                            <ul class=""list-inline font-13 sm-text-center mt-5"">
                                <li>
                                    <a class=""text-white"" href=""#"">FAQ</a>
                                </li>
                                <li class=""text-white"">|</li>
                                <li>
                                    <a class=""text-white"" href=""#"">Help Desk</a>
                                </li>
                                <li class=""text-white"">|</li>
                                <li>
                                    <a class=""text-white"" href=""#"">Login</a>
                                </li>
                            </ul>
                        </d");
            WriteLiteral(@"iv>
                    </div>
                    <div class=""col-md-8"">
                        <div class=""widget no-border m-0 mr-15 pull-right flip sm-pull-none sm-text-center"">
                            <ul class=""styled-icons icon-circled icon-sm pull-right flip sm-pull-none sm-text-center mt-sm-15"">
                                <li>
                                    <a href=""#""><i class=""fa fa-facebook text-white""></i></a>
                                </li>
                                <li>
                                    <a href=""#""><i class=""fa fa-whatsapp text-white""></i></a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""fa fa-google-plus text-white""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#""><i class=""fa fa-instagr");
            WriteLiteral(@"am text-white""></i></a>
                                </li>

                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""header-middle p-0 bg-lightest xs-text-center"">
            <div class=""container pt-0 pb-0"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-4 col-md-5"">
                        <div class=""widget no-border m-0"">
                            <a class=""menuzord-brand pull-left flip xs-pull-center mb-15""
                               href=""javascript:void(0)"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c02697e637fb8bf286ea72929dfca549618d44959046", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2746, "~/assets/images/", 2746, 16, true);
#nullable restore
#line 54 "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 2762, Model.Logo, 2762, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-sm-4 col-md-4"">
                        <div class=""widget no-border pull-right sm-pull-none sm-text-center mt-10 mb-10 m-0"">
                            <ul class=""list-inline"">
                                <li>
                                    <i class=""fa fa-phone-square text-theme-colored font-36 mt-5 sm-display-block""></i>
                                </li>
                                <li>
                                    <a href=""#"" class=""font-12 text-gray text-uppercase"">Call us today!</a>
                                    <h5 class=""font-14 m-0"">");
#nullable restore
#line 66 "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\Shared\Components\Header\Default.cshtml"
                                                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-sm-4 col-md-3"">
                        <div class=""widget no-border pull-right sm-pull-none sm-text-center mt-10 mb-10 m-0"">
                            <ul class=""list-inline"">
                                <li>
                                    <i class=""fa fa-clock-o text-theme-colored font-36 mt-5 sm-display-block""></i>
                                </li>
                                <li>
                                    <a href=""#"" class=""font-12 text-gray text-uppercase"">We are open!</a>
                                    <h5 class=""font-13 text-black m-0"">Mon-Fri ");
#nullable restore
#line 79 "C:\Users\admin\Desktop\CodeAcademy\MyFrontEndProjects\Fusion.az\Fusion.az\Fusion.az\Views\Shared\Components\Header\Default.cshtml"
                                                                          Write(Model.OpenMonFri);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""header-nav"">
            <div class=""header-nav-wrapper bg-theme-colored border-bottom-theme-color-2-1px"">
                <div class=""container"">
                    <nav id=""menuzord""
                         class=""menuzord bg-theme-colored pull-left flip menuzord-responsive"">
                        <ul class=""menuzord-menu"">
                            <li class=""active"">
                                <a href=""#home"">Home</a>
                                
                            </li>

                            <li>
                                <a href=""#"">Trial</a> 
                            </li>
                            <li>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c02697e637fb8bf286ea72929dfca549618d449513814", async() => {
                WriteLiteral("Courses");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>
                            <li>
                                <a href=""#home"">Teachers</a>
                            </li>
                            <li>
                                <a href=""#"">Blog</a>
                               
                            </li><li>
                                <a href=""#"">Contact</a>
                            </li>

                        </ul>
                        <ul class=""pull-right flip hidden-sm hidden-xs"">
                            <li>
                                <!-- Modal: Book Now Starts -->
                                <a class=""btn btn-colored btn-flat bg-theme-color-2 text-white font-14 bs-modal-ajax-load mt-0 p-25 pr-15 pl-15""
                                   data-toggle=""modal""
                                   data-target=""#BSParentModal""
                                   href=""#"">Login</a>
                                <!-- Modal: Book Now End -->
              ");
            WriteLiteral("              </li>\r\n                        </ul>\r\n                        <div id=\"top-search-bar\" class=\"collapse\">\r\n                            <div class=\"container\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c02697e637fb8bf286ea72929dfca549618d449516464", async() => {
                WriteLiteral(@"
                                    <input type=""text""
                                           placeholder=""Type text and press Enter...""
                                           name=""s""
                                           class=""form-control""
                                           autocomplete=""off"" />
                                    <span class=""search-close"">
                                        <i class=""fa fa-search""></i>
                                    </span>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
