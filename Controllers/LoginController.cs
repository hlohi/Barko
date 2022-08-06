using Barko.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barko.Models;

namespace Barko.Controllers
{
    public class LoginController : Controller
    {
        // getting data from database
        private readonly AppDbContext _context;

        // initialise context
        public LoginController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Logins;
            return View(data);
        }

       
    }

   
}
