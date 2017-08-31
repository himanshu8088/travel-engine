using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace WebServer.Core
{
    public class AppPathResolver
    {
        public string ResolvePhysicalPath(PathSettings setting ,IHttpRequest request)
        {       
            return Path.Combine(setting.BaseDirectory,setting.AppPath,setting.WebPath, "index.html");
        }

       
    }
}
