using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShopCore.IServices;
using PieShopCore.ViewModels;

namespace PieShopCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieService pieService;
        public HomeController(IPieService pieService)
        {
            this.pieService = pieService;
        }
        public IActionResult Index()
        {
            var pies = pieService.GetAllPies().OrderBy(n => n.Name).ToList();
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome",
                Pies = pies
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = pieService.GetPieById(id);

            if (pie == null)
            {
                return NotFound();
            }
                
            var detailViewModel = new DetailViewModel()
            {
                PieDetail = pie
            };
            return View(detailViewModel);
        }
    }
}