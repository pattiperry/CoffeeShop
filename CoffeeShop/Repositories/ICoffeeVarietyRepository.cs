using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Repositories
{
    public interface ICoffeeVarietyRepository
    {
        List<CoffeeVariety> GetAll();
        public CoffeeVariety Get(int id);
        public void Add(CoffeeVariety variety);
        public void Update(CoffeeVariety variety);

        public void Delete(int id);
    }
}
