using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace NetCore.NodeJsLike
{

#pragma warning disable IDE1006 // Naming Styles
    public class CreatedServerResponse
    {
        private readonly Action<NodeRequest, NodeResponse> runner;

        internal CreatedServerResponse(Action<NodeRequest, NodeResponse> runner)
        {
            this.runner = runner;
        }

        public void listen(int port)
        {
            WebHost.CreateDefaultBuilder()
                .UseUrls($"http://localhost:{port}")
                .Configure(app => 
                    app.Run(context =>
                    {
                        runner(context.Request, context.Response);
                        return Task.CompletedTask;
                    })
                )
                .ConfigureLogging(config => config.SetMinimumLevel(LogLevel.None))
                .Build().Run();
        }

    }
}
