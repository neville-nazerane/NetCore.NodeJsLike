using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE1006 // Naming Styles
namespace NetCore.NodeJsLike
{
    public class NodeResponse
    {
        private readonly HttpResponse response;

        public NodeResponse(HttpResponse response)
        {
            this.response = response;
        }

        public static implicit operator NodeResponse(HttpResponse response) => new NodeResponse(response);

        public void write(string content)
        {
            var task = response.WriteAsync(content);
            if (!task.IsCompleted) task.RunSynchronously();
        }

        public void writeHead(int status)
            => response.StatusCode = status;

        public void end() { }

    }
}
