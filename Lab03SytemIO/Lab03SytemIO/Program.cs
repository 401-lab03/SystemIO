using System;
using System.IO;

namespace Lab03SytemIO
{
    public class Program
    {
        public static string path = "../../../list.txt";

        /// <summary>
        /// The Main methods populates the entire interface menu and calls the other methods when user chooses an option.
        /// </summary>
        public static void Main()
        {

            Console.WriteLine("Welcome to your COVID-19 grocery list!");           
            Console.WriteLine("Press 1 to view your list");
            Console.WriteLine("Press 2 to add an item to your list");
            Console.WriteLine("Press 3 to delete an item"); 
            Console.WriteLine("Press 4 to Exit");

            string userInput = Console.ReadLine();

            string[] lists =
            {
                "water",
                "banana",
                "toilet paper"
            };

            if (!File.Exists(path))
            {
                CreateAFile(lists);
            }

            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("Your List: ");
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
                Console.WriteLine(" ");
                Console.WriteLine("Great! Here's your updated list: ");
                ReadFile();
                Main();
            }
            if (userInput == "3")
            {
                    Console.Clear();
                    Console.WriteLine("What item would you like to delete?");
                    Console.WriteLine(" ");
                    ReadFile();
                    string userDelete = Console.ReadLine();
                    DeleteItem(userDelete);
                    Console.WriteLine(" ");
                    Console.WriteLine("Great! Here's your updated list: ");
                    ReadFile();
                    Main();
            }
            if (userInput == "4")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Environment.Exit(0);
            }
        }
        
        /// <summary>
        /// If the txt is not created, this method create one.
        /// </summary>
        /// <param name="items"> The list items the user enters </param>
        /// <returns> The list of items </returns>
        public static string[] CreateAFile (string[] items)
        {
            string path = "../../../list.txt";
            File.WriteAllLines(path, items);
            return items;

        }

        /// <summary>
        /// This method simply reads the file and displays the list.
        /// </summary>
        static void ReadFile()
        {
            string path = "../../../list.txt";
            string listArray = File.ReadAllText(path);
            Console.WriteLine(listArray);
        }

        /// <summary>
        /// It reads all list items and returns the items.
        /// </summary>
        /// <returns> The user's list items </returns>
        static string [] ReadLines()
        {
            string path = "../../../list.txt";
            string[] myList = File.ReadAllLines(path);
            return myList;
        }

        /// <summary>
        /// This method allows users to add to their list.
        /// </summary>
        /// <param name="addToList"> The items the user wants to add to the list. </param>
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

        /// <summary>
        /// Allows user to delete from the list. 
        /// </summary>
        /// <param name="deleteItem"> The item the user wants to delete from list. </param>
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


    }
}
