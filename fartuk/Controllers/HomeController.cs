using System.IO;
using System.Web.Mvc;

namespace fartuk.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCatalog()
        {
            var fileStream = new FileStream(Server.MapPath("~/Files/catalog_f.pdf"), FileMode.Open, FileAccess.Read);

            Response.AppendHeader("Content-Disposition", "inline");
            return File(fileStream, "application/pdf");
        }
    }
}
