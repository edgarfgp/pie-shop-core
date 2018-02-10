using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.IServices
{
    public interface IFeedbackService
    {
        void AddFeedback(Feedback feedback);
    }
}
