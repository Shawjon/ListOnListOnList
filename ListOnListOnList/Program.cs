using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOnListOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitName = new List<string>(new string[] { "Apple", "Banana","Orange", "Grape" });
            List<string> fruitColor = new List<string>(new string[] { "Red","Yellow" ,"Orange", "Purple" });

            Console.WriteLine("Here is the list");
            getList(fruitName, fruitColor);
            Console.WriteLine("Now we can add a new item");
            addFruit(fruitName, fruitColor);
            Console.WriteLine("Lets sort it by name");
            sortList(ref fruitName, ref fruitColor);
            Console.WriteLine("Lets print the sorted list");
            getList(fruitName, fruitColor);
            Console.WriteLine("Lets sort by color");
            sortList(ref fruitColor, ref fruitName);
            Console.WriteLine("Lets print again");
            getList(fruitName, fruitColor);
            searchList( fruitName,  fruitColor);
        }
        static void addstringItem(List<string> list, string message)
        {
            string a;
            Console.WriteLine(message);
            a = Console.ReadLine();
            while (String.IsNullOrEmpty(a) == true)
            {
                Console.Write("That is not an answer, try again:  ");
                a = Console.ReadLine();
            }
            list.Add(a);

        }
        static void getList(List<string> list1, List<string> list2 )
        {
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"#{i+1}. Fruit name:{list1[i]}. Color: {list2[i]}.");
            }
        }
        static void addFruit(List<string> fruitName, List<string>fruitColor)
        {
            addstringItem(fruitName, "What is the name of the fruit: ");
            addstringItem(fruitColor, "What is the color of the fruit: ");
            
        }
        static void sortList(ref List<string> list2, ref List<string> list1)
        {
            List<string> list2copy = new List<string>(list2);
            List<string> list1copy = new List<string>();

            list2copy.Sort();
            for (int i = 0; i < list2copy.Count; i++)
            {
                list1copy.Add(list1[list2.IndexOf(list2copy[i])]);
            }
            list2 = list2copy;
            list1 = list1copy;

        }
        static void searchList( List<string> list1,  List<string> list2)
        {
            Console.WriteLine("Please enter a name of fruit to see if it is in the list");
            string choice = Console.ReadLine();
            Console.WriteLine($"The word {list1[list1.IndexOf(choice)]} is at {(list1.IndexOf(choice))+1} spot.");
        }
    }
}
