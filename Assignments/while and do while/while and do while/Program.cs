using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_and_do_while
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("boolean comparison using a while statement"); //while statement part
            Console.WriteLine("Choose and type one of the following Pokemon: Bulbasaur, Charmander, Squirtle, Pikachu"); //Give some choices
            string pokemonName = Console.ReadLine(); //input a pokemonName
            bool isChosen = false; //declare a bool and set it false
            while (!isChosen)
            {
                switch (pokemonName)
                {
                    case "Pikachu":
                        Console.WriteLine(pokemonName + " is the best starter.");
                        isChosen = true;
                        break;

                    case "Squirtle":
                        Console.WriteLine(pokemonName + " is a very good starter.");
                        isChosen = true;
                        break;

                    case "Bulbasaur":
                        Console.WriteLine(pokemonName + " is a very good starter.");
                        isChosen = true;
                        break;

                    case "Charmander":
                        Console.WriteLine(pokemonName + " is a very good starter.");
                        isChosen = true;
                        break;

                    default:
                        Console.WriteLine("Your input is incorrect, please try again.");
                        isChosen = true;
                        break;
                }
            }
            Console.Read();



            Console.WriteLine("boolean comparison using a do while statement"); //do_while statement part
            Console.WriteLine("Choose and type one of the following Pokemon: Venusaur, Charizard, Blatoise, Raichu"); //Give some choices
            string pokemonName2 = Console.ReadLine(); //input a pokemonName
            bool isChosen2 = pokemonName2 == "Raichu";

            do
            {
                switch (pokemonName2)
                {
                    case "Raichu":
                        Console.WriteLine(pokemonName2 + " is the best starter.");
                        pokemonName2 = Console.ReadLine();
                        break;

                    case "Venusaur":
                        Console.WriteLine(pokemonName2 + " is a very good starter.");
                        pokemonName2 = Console.ReadLine();
                        break;

                    case "Charizard":
                        Console.WriteLine(pokemonName2 + " is a very good starter.");
                        pokemonName2 = Console.ReadLine();
                        break;

                    case "Blatoise":
                        Console.WriteLine(pokemonName2 + " is a very good starter.");
                        pokemonName2 = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Your input is incorrect, please try again.");
                        pokemonName2 = Console.ReadLine();
                        break;
                }
            }
            while (!isChosen2);

            Console.ReadLine();
        }   
    }
}
