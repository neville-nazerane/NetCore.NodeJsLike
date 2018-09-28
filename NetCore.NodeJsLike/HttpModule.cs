using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE1006 // Naming Styles
namespace NetCore.NodeJsLike
{

    public interface IHttpMaker { }

    public class HttpModule
    {
        private readonly JsConsole console;

        internal HttpModule(JsConsole console)
        {
            this.console = console;
        }

        public CreatedServerResponse createServer(Action<NodeRequest, NodeResponse> runner)
            => new CreatedServerResponse(runner);

    }
}
