/*Ce programme permet de décider si oui ou non un conducteur doît être pris en charge par une assurance automobile
 * en fonction des critères suivants : Son âge, Le nombre d'accident qu'il a commit, La durée de son permis de Conduire.
 En fonction de cela différents tarifs identifiables par des couleurs lui seront attribués */
using System;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Quel âge avez-vous ?");
                uint driverAge = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Depuis combien de temps avez-vous votre permis de conduire ?");
                uint licenseTerm = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Combien d'accidents avez-vous eu ?");
                uint nbreAccident = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();

                bool tarifVert = false;
                bool tarifRouge = false;
                bool tarifOrange = false;
                bool tarifBleu = false;

                if ( driverAge < 25 && licenseTerm < 2 )
                {
                    if (nbreAccident == 0)
                    {
                        tarifRouge = true;
                        Console.WriteLine("Vous bénéficiez du tarif Rouge");
                    } 
                    else
                        Console.WriteLine("Désolé, vous ne pouvez pas être assuré");
                }

                if((driverAge < 25 && licenseTerm > 2) || (driverAge > 25 && licenseTerm < 2))
                {
                    if (nbreAccident == 0)
                    {
                        tarifOrange = true;
                        Console.WriteLine("Vous bénéficiez du tarif Orange");
                    }   
                    else if(nbreAccident == 1)
                    {
                        tarifRouge = true;
                        Console.WriteLine("Vous bénéficiez du tarif Rouge");
                    }   
                    else
                        Console.WriteLine("Désolé, vous ne pouvez pas être assuré");
                }

                if(driverAge > 25 && licenseTerm > 2 )
                {
                    if (nbreAccident == 0)
                    {
                        tarifVert = true;
                        Console.WriteLine("Vous bénéficiez du tarif Vert");
                    }
                    else if (nbreAccident == 1)
                    {
                        tarifOrange = true;
                        Console.WriteLine("Vous bénéficiez du tarif Orange");
                    }
                    else if (nbreAccident == 2)
                    {
                        tarifRouge = true;
                        Console.WriteLine("Vous bénéficiez du tarif Rouge");
                    }   
                    else
                        Console.WriteLine("Désolé, vous ne pouvez pas être assuré");
                }

                Console.WriteLine("Depuis combien de temps êtes-vous avec nous ?");
                uint fidelity = Convert.ToUInt32(Console.ReadLine());

                if (fidelity > 5 && tarifVert == true)
                    Console.WriteLine("Merci pour votre fidélité, Vous bénéficiez désormais du tarif Bleu:-)");
                else if (fidelity > 5 && tarifOrange == true)
                    Console.WriteLine("Merci pour votre fidélité, Vous bénéficiez désormais du tarif Vert:-)");
                else if(fidelity > 5 && tarifRouge == true)
                    Console.WriteLine("Merci pour votre fidélité, Vous bénéficiez désormais du tarif Orange:-)");
            }
            catch(Exception)
            {
                Console.WriteLine("Entrez des valeurs entières svp!!!\n Et surtout pas de nombres négatives");
            }
        }
    }
}
