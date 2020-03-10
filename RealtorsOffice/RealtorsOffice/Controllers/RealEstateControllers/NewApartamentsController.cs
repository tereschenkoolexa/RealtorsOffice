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
    public class NewApartamentsController : Controller
    {

        ApplicationDbContext _context;

        public NewApartamentsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            List<NewApartamentsViewModel> listRed = _context.NewApartments.Select(t => new NewApartamentsViewModel
            {
                Id = t.Id,
                NumberRooms = t.NumberRooms,
                Picture = t.Picture,
                Price = t.Price,
                Square = t.Square,
                Floor = t.Floor,
                CountRooms = t.CountRooms,
                IdBuilding = t.IdBuilding
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
        public ActionResult Create(NewApartamentsCreateViewModel model)
        {
            _context.RealtorNewApartments.Add(new RealtorNewApartment
            {
                IdHouse = model.Id,
                IdRealtor = User.Identity.GetUserId()
            });
            if (ModelState.IsValid)
            {
                _context.NewApartments.Add(new NewApartmentsModel
                {
                    NumberRooms = model.NumberRooms,
                    Picture = model.Picture,
                    Price = model.Price,
                    Square = model.Square,
                    Floor = model.Floor,
                    CountRooms = model.CountRooms,
                    IdBuilding = model.IdBuilding
                });
                _context.SaveChanges();

                return RedirectToAction("Index", "NewApartments");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(int id)
        {
            var temp = _context.NewApartments.FirstOrDefault(t => t.Id == id);
            NewApartamentsEditViewModel model = new NewApartamentsEditViewModel()
            {
                NumberRooms = temp.NumberRooms,
                Picture = temp.Picture,
                Price = temp.Price,
                Square = temp.Square,
                Floor = temp.Floor,
                CountRooms = temp.CountRooms,
                Id = temp.Id,
                IdBuilding = temp.IdBuilding
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Realtor")]
        public ActionResult Edit(NewApartamentsEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.NewApartments.FirstOrDefault(t => t.Id == model.Id);

                temp.NumberRooms = model.NumberRooms;
                temp.Picture = model.Picture;
                temp.Price = model.Price;;
                temp.Square = model.Square;
                temp.Floor = model.Floor;
                temp.CountRooms = model.CountRooms;
                _context.SaveChanges();

                return RedirectToAction("Index", "NewApartments");
            }
            return View(model);
        }

        [Authorize(Roles = "Realtor")]
        public ActionResult Delete(int id)
        {
            _context.NewApartments.Remove(_context.NewApartments.FirstOrDefault(t => t.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index", "NewApartments");
        }

    }
}