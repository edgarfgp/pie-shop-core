using PieShopCore.Data;
using PieShopCore.IRepositories;
using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext context;

        public FeedbackRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void AddFeedback(Feedback feedback)
        {

            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }
    }
}
