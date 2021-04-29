﻿using GestionRestau.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.ViewModels
{
    public class TableCmdViewModel
    {

        public int Id { get; set; }
        public int Numero { get; set; }
        public int NbPlace { get; set; }
        public bool Occupation { get; set; }
        public string Emplacement { get; set; }

        public virtual Serveur Serveur { get; set; }
        public int ServeurId { get; set; }

        public virtual ICollection<Consommation> Consommations { get; set; }

        public  List<SelectListItem>  Serveurs { get; set; }
    }
}
