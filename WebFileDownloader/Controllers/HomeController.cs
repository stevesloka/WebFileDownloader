using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Text;

namespace WebFileDownloader.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string url)
        {
            string fileName = string.Format(@"c:\music\{0}.{1}", Guid.NewGuid().ToString(), "m4a");

            WebClient client = new WebClient();
            client.DownloadFile(url, fileName);

            return View();
        }

    }
}
