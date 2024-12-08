using ConsoleAppPaiements;

static void Main(string[] args)
{
    CarteCredit cc1 = new CarteCredit { NumeroCarte = "1234 5678 9123 4567", Montant = 150.00, DatePaiement = DateTime.Now };
    CarteCredit cc2 = new CarteCredit { NumeroCarte = "9876 5432 1098 7654", Montant = 200.50, DatePaiement = DateTime.Now };
    CarteCredit cc3 = new CarteCredit { NumeroCarte = "5678 9123 4567 1234", Montant = 350.75, DatePaiement = DateTime.Now };

    PayPal pp1 = new PayPal { AdresseEmail = "user1@example.com", Montant = 99.99, DatePaiement = DateTime.Now };
    PayPal pp2 = new PayPal { AdresseEmail = "user2@example.com", Montant = 250.00, DatePaiement = DateTime.Now };

    Utilisateur utilisateur = new Utilisateur { Nom = " Lafhaili Mohammed " };
    utilisateur.AjouterPaiement(cc1);
    utilisateur.AjouterPaiement(cc2);
    utilisateur.AjouterPaiement(cc3);
    utilisateur.AjouterPaiement(pp1);
    utilisateur.AjouterPaiement(pp2);

    utilisateur.AfficherPaiements();
}
