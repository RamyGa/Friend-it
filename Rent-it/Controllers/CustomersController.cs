
using Microsoft.AspNetCore.Mvc;
using Rent_it.Models;
using Rent_it.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;


namespace Rent_it.Controllers
{
    public class CustomersController : Controller

     
    {

        private DataContext _context;

        public CustomersController()
        {
            _context = new DataContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    

        public ViewResult Index()
        {

            var customers = _context.Customers.Include(c => c.MembershipType ).ToList();




            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return NotFound();
            }
            else
            {
                return View(customer);
            }
        }
    }
}
