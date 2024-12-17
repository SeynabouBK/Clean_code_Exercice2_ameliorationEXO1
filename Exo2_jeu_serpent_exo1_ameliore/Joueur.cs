using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2_jeu_serpent_exo1_ameliore
{
    internal class Joueur(String NomJoueur)
    {
        public String NomDuJoueur { get; private set; } = NomJoueur;
        public int Position { get; private set; } = 0;


        public void AfficherInfos()
        {
            Console.WriteLine($"Joueur: {NomDuJoueur}, Position: {Position}");
        }

        public static int LancerDe()
        {
            Random random = new();
            int ValeurDe = random.Next(1, 7);
            return ValeurDe;
        }

        public void Deplacer(int ValeurDe1)
        {
            Position += ValeurDe1;

            if (Position > 50)
            {
                Console.WriteLine($"{NomDuJoueur} se deplace à la position {Position} ! ");
                Console.Write($"{NomDuJoueur} depasse donc la case 50 et revient à la case 25 ! ");
                Position = 25;
            }
            Console.WriteLine($"{NomDuJoueur} se deplace à la position {Position} ! ");

        }
    }

}
