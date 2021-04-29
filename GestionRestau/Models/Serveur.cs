using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Models
{
    [Index(nameof(Nom), IsUnique = true)]
    public class Serveur
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du serveur est obligatoire")]
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        [StringLength(50, MinimumLength = 10,
ErrorMessage = "L'adresse doit impérativement avoir plus de 10 char")]
        [DataType(DataType.Text)]
        public string Adresse { get; set; }
        public virtual ICollection<TableCmd> TableCmds { get; set; }
    }
}
