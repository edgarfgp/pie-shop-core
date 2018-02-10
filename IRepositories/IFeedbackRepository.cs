using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.IRepositories
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
