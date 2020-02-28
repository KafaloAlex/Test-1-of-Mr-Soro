/*Écrire, avec des comparaisons, un algorithme qui affiche l’état de l’eau (glace, liquide, vapeur) en fonction 
de sa température.*/
using System;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la Température de l'eau :");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp >= 1 && temp <= 100)
                Console.WriteLine("Votre eau est à {0} °C, elle est donc à l'état 'Liquide' ",temp);
            else if(temp <= 0)
                Console.WriteLine("Votre eau est à {0} °C, elle est donc à l'état de 'Glace' ", temp);
            else
                Console.WriteLine("Votre eau est à {0} °C, elle est donc à l'état de 'Vapeur' ", temp);
        }
    }
}
