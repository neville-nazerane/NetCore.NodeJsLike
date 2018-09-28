using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE1006 // Naming Styles
namespace NodeJsLike
{
    public class NodeRequest
    {
        private readonly HttpRequest request;

        internal NodeRequest(HttpRequest request)
        {
            this.request = request;
        }

        public static implicit operator NodeRequest(HttpRequest request) => new NodeRequest(request);

        public string url => $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";

    }
}
