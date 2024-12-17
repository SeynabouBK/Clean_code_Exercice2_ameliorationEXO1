using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo2_jeu_serpent_exo1_ameliore;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez le nom du premier joueur :");
        string nomJoueur1 = Console.ReadLine() ?? "Joueur 1";

        Console.WriteLine("Entrez le nom du deuxième joueur :");
        string nomJoueur2 = Console.ReadLine() ?? "Joueur 2";

        Jeu jeu = new (nomJoueur1, nomJoueur2);
        jeu.Demarrer();
    }
}
