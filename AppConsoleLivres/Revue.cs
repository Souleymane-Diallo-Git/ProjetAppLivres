using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }

        public Revue(string titre, string auteur, int nbrPages, int numero, int annee) : base(titre, auteur, nbrPages) 
        {
            Numero = numero;
            Annee = annee;
        }


        // Le mot clé "override" indique que l'on remplace la définition de la méthode.
        // Héritée de la classe parente par une nouvelle version dans  la classe dérivée.
        public override void AfficherDetails()
        {
            Console.WriteLine($"La Revue : le titre est {Titre}, L'auteur est {Auteur}, Le nombre de pages est {NombrePages}, Le numero est {Numero} et l'année est {Annee}");
        }
    }
}
