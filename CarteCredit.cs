namespace ConsoleAppPaiements
{
    public class CarteCredit : Paiement
    {
        public required string NumeroCarte { get; set; }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Carte de crédit : {NumeroCarte}, Montant : {Montant}, Date : {DatePaiement}");
        }
    }

}
