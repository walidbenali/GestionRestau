﻿using GestionRestau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Repositories.Interfaces
{
    public interface IServeurRepository
    {
        public ICollection<Serveur> GetAll();
        public void Insert(Serveur serveur);
        public Serveur GetById(int Id);
        public void Update(Serveur serveur);
        public void DeleteById(int Id);
        public void Save();
    }
}
