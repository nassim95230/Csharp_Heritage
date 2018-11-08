using System;

namespace TpHeritage2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Lex", "Amazonie", "Grogne", false, 4);
            Chat chat = new Chat("Blanche", "nature", "miaule", true, 4);
            Baleine baleine = new Baleine("Dofy", "Ocean", "siffle", true, 2800, 800);

            Mammifere guepard = new Lion("Lex", "Amazonie", "Grogne", false, 4);

            Mammifere[] Tab = new Mammifere[4];

            Tab[0] = new Lion("Lex", "Amazonie", "Grogne", false, 4);

            Console.WriteLine("Choisissez votre animal de compagnie en fonction de sa dangerosité !");

            int choix = 1;

            Console.WriteLine("Faites un choix parmis ces trois mammifères, lis bien sa description avant de décider !");
            Console.WriteLine("1. Le Chat est un mammifère de type félin et domestique");
            Console.WriteLine("2. La Baleine est un mammifère de type cétace et non domestique (vu sa taille c'normal !)");
            Console.WriteLine("3. Le Lion est un mamifère de type félin il est domestique mais reste un animal très dangereux lorsque tu le provoque !");

            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.WriteLine("Super ta choisi un chat !");
                    break;
                case 2:
                    Console.WriteLine("Super ta choisi une baleine !");
                    break;
                case 3:
                    Console.WriteLine("Ah.. un lion.. j'espère qu'il ne te tuera pas dès que tu sera a sa portée de vue !");
                    break;
                default:
                    Console.WriteLine("Il faut faire un choix !");
                    break;
            }
            Console.ReadKey();
        }
    }
}
