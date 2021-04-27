using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Models
{
    public class Serveur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public virtual ICollection<TableCmd> TableCmds { get; set; }
    }
}
