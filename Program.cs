using System;

namespace Cours3
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur joueur1 = new Joueur("joueur", false);

            //////////////////////////////// Passez le paramètre en true pour être en mode ia et false pour être en mode manuel //////////////////////////////// 

            Joueur joueur2 = new Joueur("IA", true);

            var hasard = new Random();
            var score = new int[]{ 0,0 };
            Console.WriteLine("Bonjour et bienvenue dans mon jeu de pierre feuille ciseaux");

            game(joueur1, joueur2);




            static void game (Joueur joueur1, Joueur joueur2) {
            while (joueur1.Score < 3 && joueur2.Score < 3){
    
                Console.WriteLine($"Vous : {joueur1.Score} \nAdversaire : {joueur2.Score}"); 
                
                choix(joueur1);
                choix(joueur2);
                duel(joueur1, joueur2);
          
            }
                Console.WriteLine($"Vous : {joueur1.Score} Adversaire : {joueur2.Score}");
            }
                static void choix(Joueur joueur) {
                    string choix;
                    var hasard = new Random();
                    if (joueur.IA == true) {
                        joueur.Choix = hasard.Next(3);
                        
                    } else {
                        Console.WriteLine("1.Pierre 2.Feuille 3.ciseaux");
                        choix = Console.ReadLine();
                        joueur.Choix = int.Parse(choix) - 1;
                    }
                }



            
                static void duel(Joueur joueur1, Joueur joueur2) {

                    var options = "Pierre,Feuille,Ciseaux".Split(",");
                
                        if((joueur2.Choix == 0 && joueur1.Choix == 1 ) || (joueur2.Choix == 1 && joueur1.Choix == 2) || (joueur2.Choix == 2 && joueur1.Choix == 0)) {
                            Console.WriteLine ($"\nVous : {options[joueur1.Choix]} \nAdversaire : {options[joueur2.Choix]} \nVous avez gagné\n");
                            joueur1.Score++;}

                        else if ((joueur2.Choix == 0 && joueur1.Choix == 2) || (joueur2.Choix == 1 && joueur1.Choix == 0) || (joueur2.Choix == 2 && joueur1.Choix == 1)) {
                            Console.WriteLine ($"\nVous : {options[joueur1.Choix]} \nAdversaire : {options[joueur2.Choix]} \nVous avez perdu\n");
                            joueur2.Score++;

                        } else {
                            Console.WriteLine ($"\nVous : {options[joueur1.Choix]} \nAdversaire : {options[joueur2.Choix]} \nÉgalité\n");
                        }

                }




        }

    }

}
