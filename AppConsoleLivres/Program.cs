using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        // Créez trois instances de la classe Revue
        Revue revue1 = new Revue("Vaccination et pasteurisation", "Louis pasteur",200, 1, 1885);
        Revue revue2 = new Revue("Origine des espèces", "Charles Darwin",300, 2, 1859);
        Revue revue3 = new Revue("Pénicilline", "Alexandre Fleming", 250,3, 1955);

        // Affichez les détails de chaque revue
        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();
    }
}