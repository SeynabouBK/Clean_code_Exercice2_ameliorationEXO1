using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2_jeu_serpent_exo1_ameliore
{
    internal class Jeu(string nomJoueur1, string nomJoueur2)
    {
        private readonly Joueur joueur1 = new(nomJoueur1);
        private readonly Joueur joueur2 = new (nomJoueur2);
        private const int CaseVictoire = 50;
        private const int LimiteTours = 100;


        public void Demarrer()
        {
            Console.WriteLine("\n--- Début du jeu du Serpent ---");
            joueur1.AfficherInfos();
            joueur2.AfficherInfos();

            int compteurTours = 0;

            while (true)
            {
                compteurTours++;
                if (TourDeJeu(joueur1) || TourDeJeu(joueur2))
                    break;

                if (compteurTours >= LimiteTours)
                {
                    Console.WriteLine("\nLa partie est terminée après 100 tours sans vainqueur.");
                    break;
                }

                Thread.Sleep(1000);
                Console.WriteLine("\n");
            }
        }


        private static bool TourDeJeu(Joueur joueur)
        {
            int lancer = Joueur.LancerDe();
            Console.WriteLine($"{joueur.NomDuJoueur} lance le dé et obtient {lancer}");
            joueur.Deplacer(lancer);

            if (joueur.Position == CaseVictoire)
            {
                Console.WriteLine($"\n {joueur.NomDuJoueur} a gagné la partie ! ");
                return true;
            }
            return false;
        }
    }
}
