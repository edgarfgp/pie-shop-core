using PieShopCore.IRepositories;
using PieShopCore.IServices;
using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.Services
{
    public class PieService : IPieService
    {
        IPieRepository pieRepository;
        public PieService(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return pieRepository.GetAllPies();
        }

        public Pie GetPieById(int pieId)
        {
            return pieRepository.GetPieById(pieId);
        }
    }
}
