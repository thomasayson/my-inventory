using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IndividualActivity_3.Data;
using IndividualActivity_3.Models;

namespace IndividualActivity_3.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ApplicationContextDB _context;
        public SupplierController(ApplicationContextDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Suppliers.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier record)
        {
            var Supplier = new Supplier()
            {
                CompanyName = record.CompanyName,
                Representative = record.Representative,
                Code = record.Code,
                Address = record.Address,
                DateAdded = DateTime.Now,
                Type = record.Type
            };

            _context.Suppliers.Add(Supplier);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            var Supplier = _context.Suppliers.Where(i =>i.SupplierID == id).SingleOrDefault();
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            return View(Supplier);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Supplier record)
        {
            { 
                var Supplier = _context.Suppliers.Where(i => i.SupplierID == id).SingleOrDefault();
                Supplier.CompanyName = record.CompanyName;
                Supplier.Representative = record.Representative;
                Supplier.Code = record.Code;
                Supplier.Address = record.Address;
                Supplier.DateAdded = DateTime.Now;
                Supplier.Type = record.Type;

                _context.Suppliers.Update(Supplier);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var Supplier = _context.Suppliers.Where(i => i.SupplierID == id).SingleOrDefault();
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            _context.Suppliers.Remove(Supplier);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
