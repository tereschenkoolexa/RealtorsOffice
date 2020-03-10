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
    public class NewBuildingController : Controller
    {


        ApplicationDbContext _context;

        public NewBuildingController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            List<NewBuildingViewModel> listRed = _context.NewBuildings.Select(t => new NewBuildingViewModel
            {
                Id = t.Id,
                Parking = t.Parking,
                Picture = t.Picture,
                StreetName = t.StreetName,
                Warming = t.Warming,
                City = t.City,
                ConstructionStatus = t.ConstructionStatus,
                DateOfConstructed = t.DateOfConstructed,
                Floors = t.Floors
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
        public ActionResult Create(NewBuildingCreateViewModel model)
        {

            if (ModelState.IsValid)
            {
                _context.RealtorNewBuildings.Add(new RealtorNewBuilding
                {
                    IdNewBuilding = model.Id,
                    IdRealtor = User.Identity.GetUserId()
                });
                _context.NewBuildings.Add(new NewBuildingModel
                {
                    Parking = model.Parking,
                    Picture = model.Picture,
                    StreetName = model.StreetName,
                    Warming = model.Warming,
                    City = model.City,
                    ConstructionStatus = model.ConstructionStatus,
                    DateOfConstructed = model.DateOfConstructed,
                    Floors = model.Floors
                });
                _context.SaveChanges();

                return RedirectToAction("Index", "NewBuilding");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(int id)
        {
            var temp = _context.NewBuildings.FirstOrDefault(t => t.Id == id);
            NewBuildingEditViewModel model = new NewBuildingEditViewModel()
            {
                Parking = temp.Parking,
                Picture = temp.Picture,
                StreetName = temp.StreetName,
                Warming = temp.Warming,
                City = temp.City,
                ConstructionStatus = temp.ConstructionStatus,
                DateOfConstructed = temp.DateOfConstructed,
                Floors = temp.Floors
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(NewBuildingEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.NewBuildings.FirstOrDefault(t => t.Id == model.Id);

                temp.Parking = model.Parking;
                temp.Picture = model.Picture;
                temp.StreetName = model.StreetName;
                temp.Warming = model.Warming;
                temp.City = model.City;
                temp.ConstructionStatus = model.ConstructionStatus;
                temp.DateOfConstructed = model.DateOfConstructed;
                temp.Floors = model.Floors;
                _context.SaveChanges();

                return RedirectToAction("Index", "NewBuilding");
            }
            return View(model);
        }

        [Authorize(Roles = "Realtor")]
        public ActionResult Delete(int id)
        {
            _context.NewBuildings.Remove(_context.NewBuildings.FirstOrDefault(t => t.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index", "NewBuilding");
        }

    }
}