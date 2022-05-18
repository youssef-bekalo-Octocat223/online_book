#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBook.Data;
using OnlineBook.Models;

namespace OnlineBook.Controllers
{
    public class booksController : Controller
    {
        private readonly OnlineBookContext _context;

        public booksController(OnlineBookContext context)
        {
            _context = context;
        }

        // GET: books
        public async Task<IActionResult> Index()
        {
            return View(await _context.book.ToListAsync());
        }

        public async Task<IActionResult> catalogue()

        {

            return View(await _context.book.ToListAsync());

        }
    }
}
