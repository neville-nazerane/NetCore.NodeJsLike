using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE1006 // Naming Styles
namespace NodeJsLike
{

    public interface IUrlMaker { }

    public class UrlModule
    {

        internal UrlModule()
        {

        }

        public UrlResult parse(string address, bool val) => new UrlResult(address);
    }

    public class UrlResult
    {
        private readonly Uri address;

        public string host => address.Authority;

        public string pathname => address.AbsolutePath;

        public string search => address.Query;

        internal UrlResult(string address)
        {
            this.address = new Uri(address);
        }


    }

}
