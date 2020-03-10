using Microsoft.AspNet.Identity;
using RealtorsOffice.Entity.EntityModel;
using RealtorsOffice.Models;
using RealtorsOffice.Models.Communication;
using RealtorsOffice.Models.RealEstateView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealtorsOffice.Controllers.RealEstateControllers
{
    public class HouseController : Controller
    {
        ApplicationDbContext _context;

        public HouseController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {

            List<HouseViewModel> listRed = _context.Houses.Select(t => new HouseViewModel
            {
                Id = t.Id,
                Picture = t.Picture,
                Price = t.Price,
                Square = t.Square
            }).ToList();

            return View(listRed);

        }

        public ActionResult MoreInfo()
        {

            List<HouseViewModel> listRed = _context.Houses.Select(t => new HouseViewModel
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
                Floors = t.Floors,
                CountRooms = t.CountRooms
            }).ToList();

            return View(listRed);

        }

        [Authorize(Roles = "Realtor")]
        public ActionResult List()
        {

            List<HouseViewModel> listRed = _context.Houses.Select(t => new HouseViewModel
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
                Floors = t.Floors,
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
        public ActionResult Create(HouseCreateViewModel model)
        {
            _context.RealtorHouses.Add(new RealtorHouse
            {
                HouseId = model.Id,
                RealtorId = User.Identity.GetUserId()
            });
            if (ModelState.IsValid)
            {
                _context.Houses.Add(new HouseModel
                {
                    Parking = model.Parking,
                    Picture = model.Picture,
                    Price = model.Price,
                    Repair = model.Repair,
                    Square = model.Square,
                    StreetName = model.StreetName,
                    Warming = model.Warming,
                    City = model.City,
                    Floors = model.Floors,
                    CountRooms = model.CountRooms
                });
                _context.SaveChanges();

                return RedirectToAction("Index", "House");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(int id)
        {
            var temp = _context.Houses.FirstOrDefault(t => t.Id == id);
            HouseEditViewModel model = new HouseEditViewModel()
            {

                Parking = temp.Parking,
                Picture = temp.Picture,
                Price = temp.Price,
                Repair = temp.Repair,
                Square = temp.Square,
                StreetName = temp.StreetName,
                Warming = temp.Warming,
                City = temp.City,
                Floors = temp.Floors,
                CountRooms = temp.CountRooms,
                Id = temp.Id
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(HouseEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.Houses.FirstOrDefault(t => t.Id == model.Id);

                temp.Parking = model.Parking;
                temp.Picture = model.Picture;
                temp.Price = model.Price;
                temp.Repair = model.Repair;
                temp.Square = model.Square;
                temp.StreetName = model.StreetName;
                temp.Warming = model.Warming;
                temp.City = model.City;
                temp.Floors = model.Floors;
                temp.CountRooms = model.CountRooms;
                _context.SaveChanges();

                return RedirectToAction("Index", "House");
            }
            return View(model);
        }

        [Authorize(Roles = "Realtor")]
        public ActionResult Delete(int id)
        {
            _context.Houses.Remove(_context.Houses.FirstOrDefault(t => t.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index", "House");
        }

    }
}