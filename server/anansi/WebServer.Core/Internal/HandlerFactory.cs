using System;
using System.Collections.Generic;
namespace WebServer.Core
{
    public class HandlerFactory : IHandlerFactory
    {
        public IHttpHandler Create(IHttpRequest httpRequest)
        {
           PathSettings setting = new PathSettings();
            
           if (httpRequest.Url.Contains(setting.AppPath)) 
                return new TravelAppHandler(setting);
            else
                return new StaticFileHandler();
        }
    }    
}


