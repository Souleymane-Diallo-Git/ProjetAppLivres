using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        // Créez trois instances de la classe Revue
        Console.WriteLine($"Étape 3. Voir ci-dessous concernant les instances de la classe Revue.\n");
        Revue revue1 = new Revue("Vaccination et pasteurisation", "Louis pasteur",200, 1, 1885);
        Revue revue2 = new Revue("Origine des espèces", "Charles Darwin",300, 2, 1859);
        Revue revue3 = new Revue("Pénicilline", "Alexandre Fleming", 250,3, 1955);

        Roman roman1 = new Roman("L'Enfant noir", "Camara Laye", 192, "Roman autobiographique.");
        Roman roman2 = new Roman("Le Cercle des tropiques", "Alioum Fantouré", 208, "Roman politique.");
        Roman roman3 = new Roman("Le Terroriste noir", "Thierno Monénembo", 224, "Biographie romancée. \n\n\n\n");

        // Affichez les détails de chaque revue
        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();


        Console.WriteLine($"\n\n\nÉtape 4. Voir ci-dessous concernant les instances de la classe Roman.\n");
        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();


        Console.WriteLine($"Étape 5. Voir ci-dessous la liste de l'affichage des objets créés de la classe Revue et Roman dans une même liste.\n");


        // Pour cela il faut utiliser la classe mère Livre pour pouvoir créer une liste de toutes les instances de chaque classe fille.

        List<Livre> listeLivres = new List<Livre>();

        // Ajoutons les objets dans la liste listeLivres créé.
        listeLivres.Add(revue1);
        listeLivres.Add(revue2);
        listeLivres.Add(revue3);
        listeLivres.Add(roman1);
        listeLivres.Add(roman2);
        listeLivres.Add(roman3);

        // Parcourez toute la liste pour pouvoir afficher les détails de chaque élément ou instance.
        foreach (Livre livre in listeLivres)
        {
            livre.AfficherDetails();
        }
    }
}