using System;

namespace Cours2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hasard = new Random();
            var score = new int[]{ 0,0 };
            var options = "Pierre,Feuille,Ciseaux".Split(",");
            string choix;
            int intChoix;
            
            Console.WriteLine("Bonjour et bienvenue dans mon jeu de pierre feuille ciseaux");

            while (score[0] < 3 && score[1] < 3){

                var n = hasard.Next(3);
                Console.WriteLine("\nVeuillez taper : ");

                Console.WriteLine("1.Pierre    2.Feuille    3.Ciseaux");
                
                choix = Console.ReadLine();
                intChoix = int.Parse(choix) - 1;
                
                if((n == 0 && intChoix == 1 ) || (n == 1 && intChoix == 2) || (n == 2 && intChoix == 0)) {
                    Console.WriteLine ($"\nVous : {options[intChoix]} \nAdversaire : {options[n]} \nVous avez gagné\n");
                    score[0]++;}

                else if ((n == 0 && intChoix == 2) || (n == 1 && intChoix == 0) || (n == 2 && intChoix == 1)) {
                    Console.WriteLine ($"\nVous : {options[intChoix]} \nAdversaire : {options[n]} \nVous avez perdu\n");
                    score[1]++;

                } else {
                    Console.WriteLine ($"\nVous : {options[intChoix]} \nAdversaire : {options[n]} \nÉgalité\n");
                }

                Console.WriteLine($"Vous : {score[1]} \nAdversaire : {score[0]}");  

          

            }
            
            
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();

        }
    }
}
