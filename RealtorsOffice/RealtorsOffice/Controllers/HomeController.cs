using RealtorsOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealtorsOffice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult City(int cityId)
        //{


        //    return View();
        //}


        //ApplicationDbContext _context;

        //public HomeController()
        //{
        //    _context = new ApplicationDbContext();
        //}

        //public ActionResult Index()
        //{

        //    List<ApartmentsViewModel> listRed = _context.Apartments.Select(t => new ApartmentsViewModel
        //    {
        //        Id = t.Id,
        //        NumberRooms = t.NumberRooms,
        //        Parking = t.Parking,
        //        Picture = t.Picture,
        //        Price = t.Price,
        //        Repair = t.Repair,
        //        Square = t.Square,
        //        StreetName = t.StreetName,
        //        Warming = t.Warming,
        //        City = t.City,
        //        Floor = t.Floor,
        //        CountRooms = t.CountRooms
        //    }).ToList();

        //    return View(listRed);

        //}

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