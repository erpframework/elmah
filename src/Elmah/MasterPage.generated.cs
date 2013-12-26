﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elmah
{
    
    #line 2 "..\..\MasterPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\MasterPage.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class MasterPage : WebTemplateBase
    {
#line hidden

        #line 6 "..\..\MasterPage.cshtml"

    public string Title { get; set; }
    public object Footnote { get; set; }
    public IEnumerable<SpeedBar.FormattedItem> SpeedBarItems { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





WriteLiteral("\r\n");


            
            #line 11 "..\..\MasterPage.cshtml"
  
    var basePageName = Request.ServerVariables["URL"];
    
    var now = DateTime.Now;
    var tz = TimeZone.CurrentTimeZone;
    
    var speedBarItems = (SpeedBarItems ?? Enumerable.Empty<SpeedBar.FormattedItem>()).ToArray();


            
            #line default
            #line hidden
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    <head>\r\n");


            
            #line 22 "..\..\MasterPage.cshtml"
         if (!string.IsNullOrEmpty(Title))
        {

            
            #line default
            #line hidden
WriteLiteral("            <title>");


            
            #line 24 "..\..\MasterPage.cshtml"
              Write(Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");


            
            #line 25 "..\..\MasterPage.cshtml"
        }
        
            
            #line default
            #line hidden

            
            #line 26 "..\..\MasterPage.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral(@"        <!-- Le HTML5 shim, for IE6-8 support of HTML elements -->
        <!--[if lt IE 9]>
          <script src=""http://html5shim.googlecode.com/svn/trunk/html5.js""></script>
        <![endif]-->
        <link rel=""stylesheet"" type=""text/css"" href=""");


            
            #line 31 "..\..\MasterPage.cshtml"
                                                Write(basePageName);

            
            #line default
            #line hidden
WriteLiteral("/stylesheet?h=");


            
            #line 31 "..\..\MasterPage.cshtml"
                                                                           Write(Uri.EscapeDataString(StyleSheetHelper.StyleSheetHash));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n        <style type=\"text/css\">\r\n          body {\r\n            padding-top:" +
" 60px;\r\n          }\r\n        </style>\r\n    </head>\r\n    <body>\r\n");


            
            #line 39 "..\..\MasterPage.cshtml"
         if (speedBarItems.Any())
        {

            
            #line default
            #line hidden
WriteLiteral(@"            <div id=""topnavbar"" class=""navbar navbar-fixed-top"">
                <div class=""navbar-inner"">
                    <div class=""container"">
                        <a class=""brand"" href=""http://elmah.googlecode.com/"">ELMAH</a>
                        ");


            
            #line 45 "..\..\MasterPage.cshtml"
                   Write(SpeedBar.Render(speedBarItems));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");


            
            #line 49 "..\..\MasterPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"container-fluid\">\r\n            \r\n            ");


            
            #line 52 "..\..\MasterPage.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            \r\n            <footer id=\"Footer\">\r\n                ");


            
            #line 55 "..\..\MasterPage.cshtml"
            Write(RenderPartial<PoweredBy>());

            
            #line default
            #line hidden
WriteLiteral("\r\n                Server date is ");


            
            #line 56 "..\..\MasterPage.cshtml"
                          Write(now.ToString("D", CultureInfo.InvariantCulture));

            
            #line default
            #line hidden
WriteLiteral(".\r\n                Server time is ");


            
            #line 57 "..\..\MasterPage.cshtml"
                          Write(now.ToString("T", CultureInfo.InvariantCulture));

            
            #line default
            #line hidden
WriteLiteral(".\r\n                All dates and times displayed are in the\r\n                ");


            
            #line 59 "..\..\MasterPage.cshtml"
            Write(tz.IsDaylightSavingTime(now) ? tz.DaylightName : tz.StandardName);

            
            #line default
            #line hidden
WriteLiteral(" zone.\r\n                ");


            
            #line 60 "..\..\MasterPage.cshtml"
           Write(Footnote);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </footer>\r\n        </div>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
