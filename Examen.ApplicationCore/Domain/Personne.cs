using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Personne : Locataire
    {
        public string nom { get; set; }
        public string prenom { get; set; }
    }
}
