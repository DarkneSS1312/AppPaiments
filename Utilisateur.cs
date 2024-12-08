namespace ConsoleAppPaiements
{
    public class Utilisateur
    {
        public required string Nom { get; set; }
        public List<Paiement> Paiements { get; set; } = new List<Paiement>();

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }

        public void AfficherPaiements()
        {
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }

}
