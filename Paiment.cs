using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiments
{
    public abstract class Paiement
    {
        public double Montant { get; set; }
        public DateTime DatePaiement { get; set; }

        public abstract void AfficherDetails();
    }
}
