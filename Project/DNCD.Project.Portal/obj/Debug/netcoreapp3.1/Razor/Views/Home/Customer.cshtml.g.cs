#pragma checksum "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\Home\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85acbab3b1aafa2037c0591c691531b20beaa79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer), @"mvc.1.0.view", @"/Views/Home/Customer.cshtml")]
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
#line 1 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\_ViewImports.cshtml"
using DNCD.Project.Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\_ViewImports.cshtml"
using DNCD.Project.Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85acbab3b1aafa2037c0591c691531b20beaa79", @"/Views/Home/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85798d1142f6cbfad0a4ecef376956635209d3c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DNCD.Services.API.Proxy.Domains.CustomerDomain>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Customer Details</h1>\n<table border=\"1\">\n    <tr>\n        <th>ID</th>\n        <th>Name</th>\n        <th>Email</th>\n        <th>Address</th>\n        <th>Phonenumber</th>\n    </tr>\n        <tr>\n            <td>");
#nullable restore
#line 13 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\Home\Customer.cshtml"
           Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 14 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\Home\Customer.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 15 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\Home\Customer.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 16 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\Home\Customer.cshtml"
           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 17 "D:\VSProjects\Dockers\Docker.DotNetCoreDemo-master\Docker.DotNetCoreDemo-master\Project\DNCD.Project.Portal\Views\Home\Customer.cshtml"
           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNCD.Services.API.Proxy.Domains.CustomerDomain> Html { get; private set; }
    }
}
#pragma warning restore 1591
