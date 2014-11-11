﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XDav.Config;

namespace XDav.RequestHandler
{
    public class GetRequest :RequestBase
    {
        internal override Func<System.Web.HttpContext, bool> Condition
        {
            get { return r => r.Request.HttpMethod.ToLower() == "get"; }
        }



        protected override void Handle()
        {
            DirectoryInfo _dirInfo = new DirectoryInfo(ConfigManager.DavPath);

        }
    }
}
