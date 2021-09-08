using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;
        //private field of type IRestaurantData. We had to add a reference here. We also had the add the "using" statement
        //to the top of the file.

        public HomeController()
        {
            db = new InMemoryRestaurantData();
            //retrieving an object that implements the IRestaurantData interface.
            //constructs a new instance of this datatype
        }
        public ActionResult Index()
        {
            //what does Index() return? an ActionResult
            var model = db.GetAll();
            //return "Hello World!";
            //This Index() method returns what will appear on Index
            return View(model);
            //when you render a view from a HomeController, the framework will look in the Views/Home folder, 
            //and for the Index.cshtml inside there(a RazorView)
            //we are passing an IEnumerable of Restaurant to that Index.cshtml view
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}