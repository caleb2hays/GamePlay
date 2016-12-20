using GamePlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GamePlay.ViewModels;
using System.Data.Entity;


namespace GamePlay.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;
        public GamesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageGames))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        public ViewResult New()
        {
            var categories = _context.Categories.ToList();

            var viewModel = new GameFormViewModel
            {
                Categories = categories
            };

            return View("GameForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(c => c.Id == id);

            if (game == null)
                return HttpNotFound();

            var viewModel = new GameFormViewModel(game)
            {
                Categories = _context.Categories.ToList()
            };

            return View("GameForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(g => g.Category).SingleOrDefault(g => g.Id == id);

            if (game == null)
                return HttpNotFound();

            return View(game);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(GameModel game)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new GameFormViewModel(game)
                {
                    Categories = _context.Categories.ToList()
                };
                return View("GameForm", viewModel);
            }

            if (game.Id == 0)
            {
                game.DateAdded = DateTime.Now;
                _context.Games.Add(game);
            }
            else
            {
                var gameInDb = _context.Games.Single(m => m.Id == game.Id);
                gameInDb.Name = game.Name;
                gameInDb.CategoryId = game.CategoryId;
                gameInDb.NumberInStock = game.NumberInStock;
                gameInDb.ReleaseDate = game.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }


        // GET: Games/Random
        public ActionResult Random()
        {
            var game = new GameModel() { Name = "Infinite Warfare" };
            var customers = new List<CustomerModel>
            {
                new CustomerModel { Name = "Customer 1" },
                new CustomerModel { Name = "Customer 2" }
            };

            var viewModel = new RandomGameViewModel
            {
                Game = game,
                Customers = customers                
            };

            return View(viewModel);
        }       

    }
}