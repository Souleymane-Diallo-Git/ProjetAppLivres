using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        // Créez trois instances de la classe Revue
        Revue revue1 = new Revue("Vaccination et pasteurisation", "Louis pasteur",200, 1, 1885);
        Revue revue2 = new Revue("Origine des espèces", "Charles Darwin",300, 2, 1859);
        Revue revue3 = new Revue("Pénicilline", "Alexandre Fleming", 250,3, 1955);

        Roman roman1 = new Roman("L'Enfant noir", "Camara Laye", 192, "Roman autobiographique");
        Roman roman2 = new Roman("Le Cercle des tropiques", "Alioum Fantouré", 208, "Roman politique");
        Roman roman3 = new Roman("Le Terroriste noir", "Tierno Monénembo", 224, "Biographie romancée");

        // Affichez les détails de chaque revue
        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();

        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();
    }
}