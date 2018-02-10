using PieShopCore.Data;
using PieShopCore.IRepositories;
using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext context;
        public PieRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return context.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return context.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
