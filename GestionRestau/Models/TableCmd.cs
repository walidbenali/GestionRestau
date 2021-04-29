using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Models
{
    public class TableCmd
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        [DisplayName("Nombre de places")]
        public int NbPlace { get; set; }
        public bool Occupation { get; set; }
        public string Emplacement { get; set; }

        public virtual Serveur Serveur { get; set; }
        public int ServeurId { get; set; }

        public virtual ICollection<Consommation> Consommations { get; set; }
    }
}
