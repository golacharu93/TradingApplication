#pragma checksum "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7545df3aee9d26875ae2f2f2a5aa1fbeda89e69d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_UserLogin), @"mvc.1.0.view", @"/Views/Registration/UserLogin.cshtml")]
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
#line 1 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\_ViewImports.cshtml"
using TradingApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\_ViewImports.cshtml"
using TradingApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7545df3aee9d26875ae2f2f2a5aa1fbeda89e69d", @"/Views/Registration/UserLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa157194f687895bedfcf6e4ded61ec113c25d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_UserLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TradingApplication.Models.UserData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7545df3aee9d26875ae2f2f2a5aa1fbeda89e69d4805", async() => {
                WriteLiteral("\r\n        <div class=\"text-center\">\r\n\r\n            <h1 class=\"display-4\">User Login</h1>\r\n\r\n\r\n\r\n            <div>\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7545df3aee9d26875ae2f2f2a5aa1fbeda89e69d5214", async() => {
                    WriteLiteral(@"

                    <table class=""table table-bordered"">
                        <tr>
                            <td></td>
                            <td>Please Enter Your Login Details:</td>
                        </tr>
                        <tr>
                            <td>User Name</td>
                            <td>
                                ");
#nullable restore
#line 28 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                           Write(Html.TextBoxFor(model => model.Email, null, new { @class = "form-control", @id = "EmailValue" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 29 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, null, new { @class = "redcolor" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>Password</td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                           Write(Html.TextBoxFor(model => model.Pwd, null, new { @class = "form-control", @type = "password" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 38 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Pwd, null, new { @class = "redcolor" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>

                        <tr>
                            <td>
                            </td>


                        <tr>
                            <td></td>
                            <td style=""color:red"">
                                <label>");
#nullable restore
#line 50 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                                  Write(Html.DisplayFor(model => model.LoginErrorMessage));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                <label> ");
#nullable restore
#line 51 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                                   Write(Html.DisplayFor(model => model.SendMailSuccess));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n");
#nullable restore
#line 52 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                                 if (Model.success)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <p>Your Mail-Id Is Not verified, please verify it.</p>\r\n");
#nullable restore
#line 55 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                               Write(Html.ActionLink("Resend Mail", "SendMail", "Registration", new { name = Model.Name, Email = Model.Email }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                                                                                                                                               ;
                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                               
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <input class=""btn-dark"" id=""Submit"" type=""submit"" value=""Log-In"" />


                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>  ");
#nullable restore
#line 71 "C:\Users\sushant nimoria\source\repos\TradingApplication\TradingApplication\Views\Registration\UserLogin.cshtml"
                             Write(Html.ActionLink("Register as new User", "UserRegistration", "Registration"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n\r\n                    </table>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n       \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TradingApplication.Models.UserData> Html { get; private set; }
    }
}
#pragma warning restore 1591
