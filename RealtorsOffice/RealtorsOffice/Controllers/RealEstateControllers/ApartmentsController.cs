﻿using RealtorsOffice.Entity.EntityModel;
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


        public ApartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {

            List<ApartmentsViewModel> listRed = _context.Apartments.Select(t => new ApartmentsViewModel
            {
                NumberRooms = t.NumberRooms,
                Parking = t.Parking,
                Picture = t.Picture,
                Price = t.Price,
                Repair = t.Repair,
                Square = t.Square,
                StreetName = t.StreetName,
                Warming = t.Warming
            }).ToList();

            return View(listRed);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ApartmentsCreateViewModel model)
        {

            if (ModelState.IsValid)
            {
                _context.Apartments.Add(new ApartmentsModel
                {
                    NumberRooms = model.NumberRooms,
                    Parking = model.Parking,
                    Picture = model.Picture,
                    Price = model.Price,
                    Repair = model.Repair,
                    Square = model.Square,
                    StreetName = model.StreetName,
                    Warming = model.Warming

                });
                _context.SaveChanges();

                return RedirectToAction("Index", "Apartments");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var temp = _context.Apartments.FirstOrDefault(t => t.Id == id);
            ApartmentsEditViewModel model = new ApartmentsEditViewModel()
            {
                NumberRooms = temp.NumberRooms,
                Parking = temp.Parking,
                Picture = temp.Picture,
                Price = temp.Price,
                Repair = temp.Repair,
                Square = temp.Square,
                StreetName = temp.StreetName,
                Warming = temp.Warming,
                Id = temp.Id
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ApartmentsEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.Apartments.FirstOrDefault(t => t.Id == model.Id);

                temp.NumberRooms = model.NumberRooms;
                temp.Parking = model.Parking;
                temp.Picture = model.Picture;
                temp.Price = model.Price;
                temp.Repair = model.Repair;
                temp.Square = model.Square;
                temp.StreetName = model.StreetName;
                temp.Warming = model.Warming;
              
                _context.SaveChanges();

                return RedirectToAction("Index", "Apartments");
            }
            return View(model);
        }


        public ActionResult Delete(int id)
        {
            _context.Apartments.Remove(_context.Apartments.FirstOrDefault(t => t.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index", "Apartments");
        }
    }
}