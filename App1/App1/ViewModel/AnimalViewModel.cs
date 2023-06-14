using App1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App1.ViewModel
{
    public class AnimalViewModel
    {
        private Services.DatabaseContext getContext()
        {
            return new Services.DatabaseContext();
        }

        public async Task<List<AnimalModel>> GetAllAnimals()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Employees.ToListAsync();
            return res;

        }
        public async Task<int> UpdateAnimal(AnimalModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employees.Update(obj);
            int c = await _dbContext.SaveChangesAsync();
            return c;
        }

        public int InsertAnimal(AnimalModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employees.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public int DeleteAnimal(AnimalModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employees.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }
    }
}
