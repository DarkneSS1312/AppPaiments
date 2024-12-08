namespace ConsoleAppPaiements
{
    public abstract class Paiement
    {
        public double Montant { get; set; }
        public DateTime DatePaiement { get; set; }

        public abstract void AfficherDetails();
    }
}
