/*Pour l'énoncé, veuillez vous rendre sur https://github.com/Soro08/NAN320 */
using System;

namespace exo3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un entier :");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            double add = Fonction(x + 1);
            double sub = Fonction(x);
            
            while(add >= sub)
            {
                n++;
                Console.WriteLine(n);
            }
        }
  
        static double Fonction(int y)
        {
            double p = Math.Pow(0.9, y);
            double P = p - (1 / y);
            return P;
        }
    }
}
