using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable IDE1006 // Naming Styles
namespace NodeJsLike
{
    public class JsConsole
    {

        public void log(params object[] vals)
            => Console.WriteLine(string.Join(" ", vals));

    }
}
