using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AspNetCSharpMysqlTemplate.Controllers
{
    public class ChartController : Controller
    {
        private FruitDBContext db = new FruitDBContext();

        // GET: Chart
        public ActionResult Index()
        {
            var fruits = db.topFruits();
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(fruits);
            ViewBag.Title = "Anychart ASP.NET C# template";
            ViewBag.ChartTitle = "Top 5 fruits";
            ViewBag.ChartData = json;
            return View(fruits);
        }
    }
}