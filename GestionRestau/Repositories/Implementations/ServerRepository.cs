using GestionRestau.Models;
using GestionRestau.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Repositories.Implementation
{
    public class ServerRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ServerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICollection<Serveur> GetAllServeur()
        {
            var serveurs = _dbContext.Serveurs.ToList();
            return serveurs;
        }
    }
}
