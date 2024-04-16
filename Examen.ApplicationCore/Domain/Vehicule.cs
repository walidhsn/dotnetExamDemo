using System.ComponentModel.DataAnnotations;

namespace Examen.ApplicationCore.Domain
{
    public class Vehicule
    {
        public int vehiculeId { get; set; }
        public double prixJour { get; set; }
        public int kilometrage { get; set; }
        [MaxLength(25,ErrorMessage ="max length 25 char!")]
        public string couleur { get; set; }
        public List<Reservation> reservations { get; set; }
        public Vehicule() {
            this.reservations = new List<Reservation>();
        }
    }
}