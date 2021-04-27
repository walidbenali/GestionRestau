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
    public class ProduitRepository : IProduitRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProduitRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICollection<Produit> GetAll()
        {
            var produits = _dbContext.Produits.ToList();
            return produits;
        }
        public void Insert(Produit produit)
        {
            _dbContext.Produits.Add(produit);
        }
        public Produit GetById(int Id)
        {
            return _dbContext.Produits.Find(Id);
        }
        public void Update(Produit produit)
        {
            _dbContext.Entry(produit).State = EntityState.Modified;
        }
        public void DeleteById(int Id)
        {
            var produitToDelete = _dbContext.Produits.Find(Id);
            _dbContext.Produits.Remove(produitToDelete);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
