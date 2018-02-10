using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieShopCore.IServices;
using PieShopCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShopCore.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        IFeedbackService feedbackService;
        public FeedbackController(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;


        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackService.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");

            }
            else
            {
                return View(feedback);
            }


        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }


    }
}
