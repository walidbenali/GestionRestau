using GestionRestau.Models;
using GestionRestau.Models.Context;
using GestionRestau.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Repositories.Implementations
{
    public class ConsommationRepository : IConsommationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ConsommationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICollection<Consommation> GetAll()
        {
            var consommations = _dbContext.Consommations.ToList();
            return consommations;
        }
        public void Insert(Consommation consommation)
        {
            _dbContext.Consommations.Add(consommation);
        }
        public Consommation GetById(int Id)
        {
            return _dbContext.Consommations.Find(Id);
        }
        public void Update(Consommation consommation)
        {
            _dbContext.Entry(consommation).State = EntityState.Modified;
        }
        public void DeleteById(int Id)
        {
            var consommationToDelete = _dbContext.Consommations.Find(Id);
            _dbContext.Consommations.Remove(consommationToDelete);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
