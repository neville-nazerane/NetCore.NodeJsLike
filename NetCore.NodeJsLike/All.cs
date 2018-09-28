using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE1006 // Naming Styles
namespace NetCore.NodeJsLike
{
    public static class All
    {

        public static IHttpMaker _http_ { get; set; }
        public static HttpModule require(IHttpMaker maker) => new HttpModule(console);

        public static IUrlMaker _url_ { get; set; }
        public static UrlModule require(IUrlMaker maker) => new UrlModule();

        public static JsConsole console = new JsConsole();

    }
}
