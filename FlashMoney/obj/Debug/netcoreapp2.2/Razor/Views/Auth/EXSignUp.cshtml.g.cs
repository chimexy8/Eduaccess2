#pragma checksum "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d84014aade4b68913e53e1481a1142dca4f786a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_EXSignUp), @"mvc.1.0.view", @"/Views/Auth/EXSignUp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/EXSignUp.cshtml", typeof(AspNetCore.Views_Auth_EXSignUp))]
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
#line 1 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\_ViewImports.cshtml"
using FlashMoney;

#line default
#line hidden
#line 2 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\_ViewImports.cshtml"
using FlashMoney.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d84014aade4b68913e53e1481a1142dca4f786a", @"/Views/Auth/EXSignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26bc9580941072e1fd7ea28b5daa5928d919cacb", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_EXSignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlashMoney.Models.SignUpViewmodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Confirm Password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EXSignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
  
    ViewData["Title"] = "EXSignUp";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 134, true);
            WriteLiteral("\r\n\r\n\r\n<!-- Create Account: Profile -->\r\n<div class=\"form-section create-account-profile active\">\r\n    <div class=\"head sub\">\r\n        ");
            EndContext();
            BeginContext(267, 476, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d84014aade4b68913e53e1481a1142dca4f786a7061", async() => {
                BeginContext(333, 406, true);
                WriteLiteral(@"
            <i class=""icon auto"">
                <svg width=""16"" height=""15"" viewBox=""0 0 16 15"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <path d=""M16 6.61564V8.42502H3.98955L9.49477 13.4055L8.08057 14.6849L0.161133 7.52033L8.08057 0.355713L9.49477 1.63513L3.98955 6.61564H16Z""
                          fill=""#5D2684"" />
                </svg>
            </i>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 56, true);
            WriteLiteral("\r\n        <h4>Choose a Password</h4>\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(799, 11146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d84014aade4b68913e53e1481a1142dca4f786a9202", async() => {
                BeginContext(863, 128, true);
                WriteLiteral("\r\n        <h4 class=\"text-gradient\">Profile</h4>\r\n        <p>Some info about yourself in needed to get you started</p>\r\n        ");
                EndContext();
                BeginContext(991, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d84014aade4b68913e53e1481a1142dca4f786a9717", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 26 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1051, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1061, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a11507", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 27 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1104, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1114, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a13341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1156, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1166, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a15174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 29 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Gender);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1206, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1216, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a17005", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.date);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1254, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1264, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a18834", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 31 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phone);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1303, 147, true);
                WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"input with-icon password-check\">\r\n                    ");
                EndContext();
                BeginContext(1450, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a20816", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 36 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1501, 5195, true);
                WriteLiteral(@"
                    <label>Password</label>
                    <a class=""toggle active"">
                        <i class=""icon sm hide"">
                            <svg width=""15"" height=""15"" viewBox=""0 0 15 15"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <g opacity=""0.5"">
                                    <path d=""M7.39639 5.6343L9.36389 7.60175C9.36577 7.56682 9.37452 7.53425 9.37452 7.49863C9.37452 6.46307 8.53514 5.62365 7.49952 5.62365C7.46389 5.62365 7.43139 5.63239 7.39639 5.6343ZM4.70513 6.12552L5.67201 7.09175C5.64263 7.22307 5.62451 7.35863 5.62451 7.49863C5.62451 8.53425 6.46389 9.37363 7.49952 9.37363C7.64014 9.37363 7.77577 9.35557 7.90639 9.32675L8.87327 10.2931C8.45702 10.4981 7.99452 10.6236 7.49952 10.6236C5.77389 10.6236 4.37451 9.22494 4.37451 7.49863C4.37451 7.00363 4.50013 6.54176 4.70513 6.12552ZM1.24951 2.66929L2.67388 4.09427L2.95827 4.37866C1.92702 5.18615 1.11264 6.25988 0.624512 7.49863C1.70451 10.2418 4.37326 12.1861 7.49952 12.1861C8");
                WriteLiteral(@".46827 12.1861 9.39264 11.9987 10.2395 11.6599L10.5045 11.9243L12.3289 13.7493L13.1245 12.9537L2.04514 1.87427L1.24951 2.66929ZM7.49952 4.37365C9.22514 4.37365 10.6245 5.77304 10.6245 7.49863C10.6245 7.90238 10.542 8.28557 10.4026 8.63988L12.2289 10.4661C13.1714 9.67801 13.917 8.66113 14.3745 7.49863C13.2945 4.75554 10.6264 2.81115 7.49952 2.81115C6.62452 2.81115 5.78763 2.96802 5.00951 3.24741L6.35827 4.59617C6.71264 4.45678 7.09577 4.37365 7.49952 4.37365Z""
                                          fill=""#2F1343"" />
                                </g>
                            </svg>
                        </i>
                        <i class=""icon sm show"">
                            <svg width=""15"" height=""15"" viewBox=""0 0 15 15"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <g opacity=""0.5"">
                                    <path d=""M7.49999 5.62378C6.46437 5.62378 5.625 6.46314 5.625 7.49876C5.625 8.53439 6.46437 9.37376 7.49999 9.37376C8.53562 9.37376 ");
                WriteLiteral(@"9.37499 8.53439 9.37499 7.49876C9.37499 6.46314 8.53562 5.62378 7.49999 5.62378ZM7.49999 10.6238C5.77437 10.6238 4.375 9.22439 4.375 7.49876C4.375 5.77316 5.77437 4.37378 7.49999 4.37378C9.22562 4.37378 10.625 5.77316 10.625 7.49876C10.625 9.22439 9.22562 10.6238 7.49999 10.6238ZM7.49999 2.81128C4.37375 2.81128 1.705 4.75567 0.625 7.49876C1.705 10.2419 4.37375 12.1863 7.49999 12.1863C10.6269 12.1863 13.295 10.2419 14.375 7.49876C13.295 4.75567 10.6269 2.81128 7.49999 2.81128Z""
                                          fill=""#2F1343"" />
                                </g>
                            </svg>
                        </i>
                    </a>

                    <div class=""checker"">
                        <a class=""item checked"">
                            <i class=""icon auto"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g opacity=""0.2"">
                    ");
                WriteLiteral(@"                    <path d=""M15.75 5.24987L6.75 14.2499L2.625 10.1249L3.68566 9.06422L6.75 12.1286L14.6894 4.18921L15.75 5.24987Z""
                                              fill=""white"" />
                                    </g>
                                </svg>
                            </i>
                            <span>Minimum of 8 Characters</span>
                        </a>
                        <a class=""item"">
                            <i class=""icon auto"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g opacity=""0.2"">
                                        <path d=""M15.75 5.24987L6.75 14.2499L2.625 10.1249L3.68566 9.06422L6.75 12.1286L14.6894 4.18921L15.75 5.24987Z""
                                              fill=""white"" />
                                    </g>
                                </svg>
                            </i>
       ");
                WriteLiteral(@"                     <span>At least one Number</span>
                        </a>
                        <a class=""item"">
                            <i class=""icon auto"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g opacity=""0.2"">
                                        <path d=""M15.75 5.24987L6.75 14.2499L2.625 10.1249L3.68566 9.06422L6.75 12.1286L14.6894 4.18921L15.75 5.24987Z""
                                              fill=""white"" />
                                    </g>
                                </svg>
                            </i>
                            <span>
                                At least one Special Character (#*)
                            </span>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-12"">
       ");
                WriteLiteral("         <div class=\"input with-icon password-check\">\r\n                    ");
                EndContext();
                BeginContext(6696, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d84014aade4b68913e53e1481a1142dca4f786a27993", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 101 "C:\Users\23470\Desktop\Work\EducationAccess\FlashMoney\Views\Auth\EXSignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ConfirmPassword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6762, 5176, true);
                WriteLiteral(@"
                    <label>Password</label>
                    <a class=""toggle active"">
                        <i class=""icon sm hide"">
                            <svg width=""15"" height=""15"" viewBox=""0 0 15 15"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <g opacity=""0.5"">
                                    <path d=""M7.39639 5.6343L9.36389 7.60175C9.36577 7.56682 9.37452 7.53425 9.37452 7.49863C9.37452 6.46307 8.53514 5.62365 7.49952 5.62365C7.46389 5.62365 7.43139 5.63239 7.39639 5.6343ZM4.70513 6.12552L5.67201 7.09175C5.64263 7.22307 5.62451 7.35863 5.62451 7.49863C5.62451 8.53425 6.46389 9.37363 7.49952 9.37363C7.64014 9.37363 7.77577 9.35557 7.90639 9.32675L8.87327 10.2931C8.45702 10.4981 7.99452 10.6236 7.49952 10.6236C5.77389 10.6236 4.37451 9.22494 4.37451 7.49863C4.37451 7.00363 4.50013 6.54176 4.70513 6.12552ZM1.24951 2.66929L2.67388 4.09427L2.95827 4.37866C1.92702 5.18615 1.11264 6.25988 0.624512 7.49863C1.70451 10.2418 4.37326 12.1861 7.49952 12.1861C8");
                WriteLiteral(@".46827 12.1861 9.39264 11.9987 10.2395 11.6599L10.5045 11.9243L12.3289 13.7493L13.1245 12.9537L2.04514 1.87427L1.24951 2.66929ZM7.49952 4.37365C9.22514 4.37365 10.6245 5.77304 10.6245 7.49863C10.6245 7.90238 10.542 8.28557 10.4026 8.63988L12.2289 10.4661C13.1714 9.67801 13.917 8.66113 14.3745 7.49863C13.2945 4.75554 10.6264 2.81115 7.49952 2.81115C6.62452 2.81115 5.78763 2.96802 5.00951 3.24741L6.35827 4.59617C6.71264 4.45678 7.09577 4.37365 7.49952 4.37365Z""
                                          fill=""#2F1343"" />
                                </g>
                            </svg>
                        </i>
                        <i class=""icon sm show"">
                            <svg width=""15"" height=""15"" viewBox=""0 0 15 15"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <g opacity=""0.5"">
                                    <path d=""M7.49999 5.62378C6.46437 5.62378 5.625 6.46314 5.625 7.49876C5.625 8.53439 6.46437 9.37376 7.49999 9.37376C8.53562 9.37376 ");
                WriteLiteral(@"9.37499 8.53439 9.37499 7.49876C9.37499 6.46314 8.53562 5.62378 7.49999 5.62378ZM7.49999 10.6238C5.77437 10.6238 4.375 9.22439 4.375 7.49876C4.375 5.77316 5.77437 4.37378 7.49999 4.37378C9.22562 4.37378 10.625 5.77316 10.625 7.49876C10.625 9.22439 9.22562 10.6238 7.49999 10.6238ZM7.49999 2.81128C4.37375 2.81128 1.705 4.75567 0.625 7.49876C1.705 10.2419 4.37375 12.1863 7.49999 12.1863C10.6269 12.1863 13.295 10.2419 14.375 7.49876C13.295 4.75567 10.6269 2.81128 7.49999 2.81128Z""
                                          fill=""#2F1343"" />
                                </g>
                            </svg>
                        </i>
                    </a>

                    <div class=""checker"">
                        <a class=""item checked"">
                            <i class=""icon auto"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g opacity=""0.2"">
                    ");
                WriteLiteral(@"                    <path d=""M15.75 5.24987L6.75 14.2499L2.625 10.1249L3.68566 9.06422L6.75 12.1286L14.6894 4.18921L15.75 5.24987Z""
                                              fill=""white"" />
                                    </g>
                                </svg>
                            </i>
                            <span>Minimum of 8 Characters</span>
                        </a>
                        <a class=""item"">
                            <i class=""icon auto"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g opacity=""0.2"">
                                        <path d=""M15.75 5.24987L6.75 14.2499L2.625 10.1249L3.68566 9.06422L6.75 12.1286L14.6894 4.18921L15.75 5.24987Z""
                                              fill=""white"" />
                                    </g>
                                </svg>
                            </i>
       ");
                WriteLiteral(@"                     <span>At least one Number</span>
                        </a>
                        <a class=""item"">
                            <i class=""icon auto"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g opacity=""0.2"">
                                        <path d=""M15.75 5.24987L6.75 14.2499L2.625 10.1249L3.68566 9.06422L6.75 12.1286L14.6894 4.18921L15.75 5.24987Z""
                                              fill=""white"" />
                                    </g>
                                </svg>
                            </i>
                            <span>
                                At least one Special Character (#*)
                            </span>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""action"">
            <button class=""btn btn-pri");
                WriteLiteral("mary \" type=\"submit\">Next</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11945, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlashMoney.Models.SignUpViewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
