using Bikin.DAL;
using Bikin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bikin.Areas.Manage.Controllers
{
    [Area("manage")]
    public class WorkerController : Controller
    {
        private readonly AppDbContext _context;

        public WorkerController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var worker = _context.Workers.ToList();
            return View(worker);
        }
        public IActionResult Create()
        {
            var worker = _context.Workers.ToList();
            return View(worker);
        }
        [HttpPost]
        public IActionResult Create(Worker worker)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (worker.ImageFile != null)
            {
                worker.ImageFile.ContentType
            }
            else
            {
                return View();
            }
           
        }

        
    }
}
