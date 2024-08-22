using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList and add elements to it
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add("Three");
            list.Add(4.5);

            // Print the elements in the ArrayList
            Console.WriteLine("ArrayList elements:");
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }

            // Accessing an element by index
            Console.WriteLine($"\nElement at index 2: {list[2]}");

            // Modify an element in the ArrayList
            list[2] = "Updated Value";
            Console.WriteLine($"\nModified element at index 2: {list[2]}");

            // Remove an element from the ArrayList
            list.Remove(4.5);
            Console.WriteLine("\nArrayList after removing an element:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Insert an element at a specific index
            list.Insert(2, "New Element");
            Console.WriteLine("\nArrayList after inserting an element:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Get the count of elements in the ArrayList
            Console.WriteLine($"\nNumber of elements in the ArrayList: {list.Count}");
            Console.ReadLine();
        }
    }
}
