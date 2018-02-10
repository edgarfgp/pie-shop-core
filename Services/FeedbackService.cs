using PieShopCore.IRepositories;
using PieShopCore.IServices;
using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.Services
{
    public class FeedbackService : IFeedbackService
    {
        IFeedbackRepository feedbackRepo;
        public FeedbackService(IFeedbackRepository feedbackRepo)
        {
            this.feedbackRepo = feedbackRepo;
        }
        public void AddFeedback(Feedback feedback)
        {
            feedbackRepo.AddFeedback(feedback);
        }
    }
}
