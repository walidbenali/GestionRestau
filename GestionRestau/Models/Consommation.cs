using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Models
{
    public class Consommation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Quantité { get; set; }
        public bool Paye { get; set; }

        public virtual TableCmd TableCons { get; set; }
        public int TableConsId { get; set; }

        public virtual Produit Produit { get; set; }
        public int ProduitId { get; set; }
    }
}
