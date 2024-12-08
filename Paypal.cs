namespace ConsoleAppPaiements
{
    public class PayPal : Paiement
    {
        public required string AdresseEmail { get; set; }

        public override void AfficherDetails()
        {
            Console.WriteLine($"PayPal : {AdresseEmail}, Montant : {Montant}, Date : {DatePaiement}");
        }
    }

}
