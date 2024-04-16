using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Locataire
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "L'adresse est obligatoire.")]
        public string adresse { get; set; }
        public string telephone { get; set; }
        public int pointBonus { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateAdhesion { get; set; }
        public Agent agent { get; set; }
        public List<Reservation> reservations { get; set; }

        public Locataire()
        {
            this.reservations = new List<Reservation>();
        }
    }
}
