using System;
using System.Collections.Generic;
using System.Linq;



internal class Program
{
    static void Main(string[] args)
    {
        //PART ONE ASSIGNMENT
        Console.WriteLine("PART ONE ASSIGNMENT");
        string[] colorArray = { "red", "blue", "yellow", "white", "black" };
        Console.WriteLine("please enter some text:");
        string inputText = Console.ReadLine();

        for (int i = 0; i < colorArray.Length; i++)
        {
            colorArray[i] += inputText; //adds the inputText at the end of each string.
        }

        Console.WriteLine("new colorArray is below: ");
        for (int i = 0; i < colorArray.Length; i++)
        {
            Console.WriteLine(colorArray[i]); //prints off each string in the array one at a time
        }
        Console.ReadLine();


        //PART TWO ASSIGNMENT
        Console.WriteLine("\n" + "PART TWO ASSIGNMENT");
        bool isInfinite = true;
        while (isInfinite)
        {
            isInfinite = false; //if comments out this code, this while loop will be a infinite loop
            Console.WriteLine("This is a infinite while loop.");
        }
        Console.ReadLine();


        //PART THREE ASSIGNMENT
        Console.WriteLine("\n" + "PART THREE ASSIGNMENT");
        Console.WriteLine("A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i); //this will print 0, 1, 2
        }

        Console.WriteLine("A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(i); //this will print 0, 1, 2, 3
        }
        Console.ReadLine();


        //PART FOUR ASSIGNMENT
        Console.WriteLine("\n" + "PART FOUR ASSIGNMENT");
        List<string> animalList = new List<string>() { "dog", "cat", "rat", "tiger", "lion", "deer", "bear" };
        Console.WriteLine("Please enter text to search for in the animalList.");
        string enterText = Console.ReadLine();
        foreach (string animal in animalList)
        {
            if (animal.Contains(enterText))
            {
                Console.WriteLine(enterText + " is in the animalList!");
                break;  //break stops the loop from executing once a match has been found.
            }
            Console.WriteLine(enterText + " is not in the animalList!");
        }
        Console.ReadLine();


        //PART FIVE ASSIGNMENT
        Console.WriteLine("\n" + "PART FIVE ASSIGNMENT");
        List<string> animalList2 = new List<string>() { "dog", "cat", "dog", "tiger", "lion", "deer", "deer" };
        Console.WriteLine("Please enter text to search for in the animalList.");
        string enterText2 = Console.ReadLine();
        foreach (string animal2 in animalList2)
        {
            if (animal2.Contains(enterText2))
            {
                Console.WriteLine(enterText2 + " is in the animalList2!");
            }
            Console.WriteLine(enterText2 + " is not in the animalList2!");
        }
        Console.ReadLine();


        //PART SIX ASSIGNMENT
        Console.WriteLine("\n" + "PART SIX ASSIGNMENT");
        List<string> animalList3 = new List<string>() { "dog", "cat", "dog", "tiger", "lion", "cat", "deer" };
        HashSet<string> uniqueAnimals = new HashSet<string>(); //HashSet stores data that is unordered and unique, but List stores data that is ordered and repeatable.
        foreach (string animal3 in animalList3) //Iterate  animalList 
        {
            if(uniqueAnimals.Add(animal3)) //add all animals into Hashset, because hashset can only store unique data, so all animals in hashset must be new.
            {
                Console.WriteLine(animal3 + " is an unique animal in the animalList.");
            }
            else //then rest animals are deplicate.
            {
                Console.WriteLine(animal3 + " is a duplicate animal in the animalList");
            }            
        }
        Console.ReadLine();  
    }
}

