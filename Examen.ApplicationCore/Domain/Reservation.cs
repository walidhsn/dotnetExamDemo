using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime dateReservation { get; set; }

        [Range(1, 30)]
        public int dureeJour { get; set; }
        public int vehiculeKey { get; set; }
        public int locataireKey { get; set; }
        public Locataire locataire { get; set; }
        public Vehicule vehicule { get; set; }
    }
}
