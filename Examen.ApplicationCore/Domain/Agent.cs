using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateEmbauche { get; set; }
        public List<Locataire> locataires { get; set; }
        public Agent()
        {
            this.locataires = new List<Locataire>();
        }

    }
}
