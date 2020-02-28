/*Écrire le même algorithme, mais en utilisant deux variables booléennes pour vérifier l’état de l’eau, 
 * sans comparaisons dans les instructions if*/
using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la Température de l'eau : ");
            int temp = Convert.ToInt32(Console.ReadLine());

            bool etatLiquide = (temp >= 1 && temp <= 100);
            bool etatGlace = (temp <= 0);

            if(etatLiquide)
                Console.WriteLine("L'eau est à {0} °C, elle est donc à l'état 'Liquide'",temp);
            else if(etatGlace)
                Console.WriteLine("L'eau est à {0} °C, elle est donc à l'état de 'Glace'", temp);
            else
                Console.WriteLine("L'eau est à {0} °C, elle est donc à l'état de 'Vapeur'", temp);
        }
    }
}
