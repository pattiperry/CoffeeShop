using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Repositories
{
    public interface IBeanVarietyRepository
    {
        List<BeanVariety> GetAll();

        public BeanVariety Get(int id);

        public void Add(BeanVariety variety);

        public void Update(BeanVariety variety);

        public void Delete(int id);
    }
}
