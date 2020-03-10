using Microsoft.AspNet.Identity;
using RealtorsOffice.Entity.EntityModel;
using RealtorsOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealtorsOffice.Controllers.RealEstateControllers
{

    public class ApartmentsController : Controller
    {

        ApplicationDbContext _context;

        public ApartmentsController()
        {
            _context = new ApplicationDbContext();
        }



        public ActionResult MoreInfo(int id)
        {

            ApartmentsModel Apar = _context.Apartments.FirstOrDefault(t => t.Id == id);


            return View(Apar);

        }

        public ActionResult Index()
        {

            List<ApartmentsViewModel> listRed = _context.Apartments.Select(t => new ApartmentsViewModel
            {
                Id = t.Id,
                Picture = t.Picture,
                Price = t.Price,
                Square = t.Square,
                StreetName = t.StreetName,
            }).ToList();

            return View(listRed);

        }

        [Authorize(Roles = "Realtor")]
        public ActionResult List()
        {

            List<ApartmentsViewModel> listRed = _context.Apartments.Select(t => new ApartmentsViewModel
            {
                Id = t.Id,
                Parking = t.Parking,
                Picture = t.Picture,
                Price = t.Price,
                Repair = t.Repair,
                Square = t.Square,
                StreetName = t.StreetName,
                Warming = t.Warming,
                City = t.City,
                Floor = t.Floor,
                CountRooms = t.CountRooms
            }).ToList();

            return View(listRed);

        }

        [HttpGet]
        [Authorize(Roles = "Realtor")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Realtor")]
        public ActionResult Create(ApartmentsCreateViewModel model)
        {
            model.Name = "р-н" + model.DistrictName + "," + model.StreetName;
            if (ModelState.IsValid)
            {

                ApartmentsModel data = new ApartmentsModel
                {
                    DistrictName = model.DistrictName,
                    Name = model.Name,
                    Parking = model.Parking,
                    Picture = model.Picture,
                    Price = model.Price,
                    Repair = model.Repair,
                    Square = model.Square,
                    StreetName = model.StreetName,
                    Warming = model.Warming,
                    City = model.City,
                    Floor = model.Floor,
                    CountRooms = model.CountRooms
                };

                _context.Apartments.Add(data);
                _context.SaveChanges();
                _context.RealtorApartments.Add(new RealtorApartment
                {
                    ApartmentlId = data.Id,
                    RealtorId = User.Identity.GetUserId()
                });
                _context.SaveChanges();
                return RedirectToAction("List", "Apartments");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(int id)
        {
            var temp = _context.Apartments.FirstOrDefault(t => t.Id == id);
            ApartmentsEditViewModel model = new ApartmentsEditViewModel()
            {
                Name = temp.Name,
                Parking = temp.Parking,
                Picture = temp.Picture,
                Price = temp.Price,
                Repair = temp.Repair,
                Square = temp.Square,
                StreetName = temp.StreetName,
                Warming = temp.Warming,
                City = temp.City,
                Floor = temp.Floor,
                CountRooms = temp.CountRooms,
                Id = temp.Id
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(ApartmentsEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.Apartments.FirstOrDefault(t => t.Id == model.Id);

                temp.Name = model.Name;
                temp.Parking = model.Parking;
                temp.Picture = model.Picture;
                temp.Price = model.Price;
                temp.Repair = model.Repair;
                temp.Square = model.Square;
                temp.StreetName = model.StreetName;
                temp.Warming = model.Warming;
                temp.City = model.City;
                temp.Floor = model.Floor;
                temp.CountRooms = model.CountRooms;
                _context.SaveChanges();

                return RedirectToAction("Index", "Apartments");
            }
            return View(model);
        }

        [Authorize(Roles = "Realtor")]
        public ActionResult Delete(int id)
        {
            _context.Apartments.Remove(_context.Apartments.FirstOrDefault(t => t.Id == id));
            _context.SaveChanges();
            return RedirectToAction("List", "Apartments");
        }
    }
}