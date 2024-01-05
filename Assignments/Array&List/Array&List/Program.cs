using System;
using System.Collections.Generic;


    internal class Program
    {
        static void Main(string[] args)
        {   //string Array section 
            string[] stringArray = { "yellow", "blue", "red", "black", "green" }; //declare and initialize an array
            Console.WriteLine("Please input a number from 0 to 4 to picking a color from stringArray.");
            int selectIndex1 = Convert.ToInt32(Console.ReadLine());

            if (selectIndex1 >= 0 && selectIndex1 < 5)
            {
                Console.WriteLine("You have picked color of " + stringArray[selectIndex1]);
            }
            else
            {
                Console.WriteLine("please input a whole number from 0 to 4, try again.");
            }

            // int Array section 
            int[] intArray = {10,30,23,8,19,20,21,27,6,11,2}; //declare and initialize an array
            Console.WriteLine("\n" + "Please input a number from 0 to 10 to picking a number from intArray.");
            int selectIndex2 = Convert.ToInt32(Console.ReadLine());
            if (selectIndex2 >= 0 && selectIndex2 < 11)
            {
                Console.WriteLine("You have picked number of " + intArray[selectIndex2]);
            }
            else
            {
                Console.WriteLine("please input a whole number from 0 to 10, try again.");
            }

            //string List section 
            var AnimalList = new List<string> { "dog", "cat", "bird", "snake", "lion"}; //declare and initialize a list
            Console.WriteLine("\n" + "Please input a number from 0 to 4 to picking an animal from LIST.");
            int selectIndex3 = Convert.ToInt32(Console.ReadLine());
            if (selectIndex3 >= 0 && selectIndex3 < 5)
            {
                Console.WriteLine("You have picked a " + AnimalList[selectIndex3]);
            }
            else
            {
                Console.WriteLine("please input a whole number from 0 to 4, try again.");
            }



            Console.Read();
        }
    }
