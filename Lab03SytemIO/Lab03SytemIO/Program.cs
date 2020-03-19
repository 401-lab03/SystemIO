using System;
using System.IO;

namespace Lab03SytemIO
{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to your COVID grocery list!");           
            Console.WriteLine("Press 1 to view your list");
            Console.WriteLine("Press 2 to add an item to your list");
            Console.WriteLine("Press 3 to delete an item");

            string userInput = Console.ReadLine();

            string[] lists =
            {
                "water",
                "banana",
                "toilet paper"
            };

            if (userInput == "1")
            {
                ReadLines();
                ReadFile();
                Main();
            }

            if (userInput == "2")
            { 
                Console.Clear();
                Console.WriteLine("What item would you like to add?");
                string userAdd = Console.ReadLine();
                string[] convertToArray = new string[] {userAdd};
                AddToList(convertToArray);
                ReadFile();
                Main();
            }
            if (userInput == "3")
            {
                    Console.Clear();
                    Console.WriteLine("What item would you like to delete?");
                    string userDelete = Console.ReadLine();
                    DeleteItem(userDelete);
                    ReadFile();
                    Main();
            }
        }

        static void CreateAFile (string[] items)
        {
            string path = "../../../list.txt";
            File.WriteAllLines(path, items);
            Console.WriteLine(items);
            //File.WriteAllText(path, "hi");

        }

        static void ReadFile()
        {
            string path = "../../../list.txt";
            string listArray = File.ReadAllText(path);
            Console.WriteLine(listArray);
        }

        static string [] ReadLines()
        {
            string path = "../../../list.txt";
            string[] myList = File.ReadAllLines(path);
            return myList;
        }

        static void AddToList(string [] addToList)
        {
            string path = "../../../list.txt";
            //string[] newItems =
            //{
            //    "coffee",
            //    "potatoes",
            //    "soap"
            //};

            File.AppendAllLines(path, addToList);

        }

        static void DeleteItem(string deleteItem)
        {
            string[] currentList = ReadLines();
            int count = 0;

            for (int i = 0; i < currentList.Length; i++)
            {
                if (currentList[i] == deleteItem)
                {
                    count++;
                }
            }

            string[] newList = new String[currentList.Length - count];
            int fakeCount = 0;

            for (int i = 0; i < currentList.Length; i++)
            {
                if (currentList[i] != deleteItem)
                {
                    newList[fakeCount] = currentList[i];
                    fakeCount++;
                }
            }
            CreateAFile(newList);
        }


        // Create 2 txt files, one to catch errors, the other to view

        // interface

        // test

        //test 1



    }
}
