/*Pour l'énoncé aller sur le lien sur suivant : https://github.com/Soro08/NAN320 */
using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le réel a :");
            double a = Convert.ToDouble(Console.ReadLine());

            int n = 1;
            double s = 0;

            while(s <= a)//Détermination de l'entier n
            {
                s += (double)1 / n;
                n += 1;
            }
            Console.WriteLine(n);
        }
    }
}
