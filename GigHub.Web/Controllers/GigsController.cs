using GigHub.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub.Web.ViewModels;

namespace GigHub.Web.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel 
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
	}
}