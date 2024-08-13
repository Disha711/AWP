using System;
using System.Collections;

class Arraylist
{
    public static void Main(string[] args) 
    {
        ArrayList arrayList = new ArrayList();
        bool a = true;

        while (a)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Find");
            Console.WriteLine("3. Check if array contains any elements");
            Console.WriteLine("4. Count");
            Console.WriteLine("5. Reverse");
            Console.WriteLine("6. Sort");
            Console.WriteLine("7. List");
            Console.WriteLine("8. Remove");
            Console.WriteLine("9. Remove item at a specific index");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.Write("Enter the item to add: ");
                    string itemToAdd = Console.ReadLine();
                    arrayList.Add(itemToAdd);
                    Console.WriteLine("Added: {0}", itemToAdd);
                    break;

                case 2:
                    Console.Write("Enter the item to find: ");
                    string itemToFind = Console.ReadLine();
                    if (arrayList.Contains(itemToFind))
                    {
                        Console.WriteLine("{0} found in the list.", itemToFind);
                    }
                    else
                    {
                        Console.WriteLine("{0} not found in the list.", itemToFind);
                    }
                    break;

                case 3:
                    if (arrayList.Count > 0)
                    {
                        Console.WriteLine("The array contains elements.");
                    }
                    else
                    {
                        Console.WriteLine("The array does not contain any elements.");
                    }
                    break;

                case 4:
                    Console.WriteLine("The array contains {0} elements.", arrayList.Count);
                    break;

                case 5:
                    arrayList.Reverse();
                    Console.WriteLine("The array has been reversed.");
                    break;

                case 6:
                    arrayList.Sort();
                    Console.WriteLine("The array has been sorted.");
                    break;

                case 7:
                    Console.WriteLine("Items in the array:");
                    foreach (var item in arrayList)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 8:
                    Console.Write("Enter the item to remove: ");
                    string itemToRemove = Console.ReadLine();
                    if (arrayList.Contains(itemToRemove))
                    {
                        arrayList.Remove(itemToRemove);
                        Console.WriteLine("{0} removed from the list.", itemToRemove);
                    }
                    else
                    {
                        Console.WriteLine("{0} not found in the list.", itemToRemove);
                    }
                    break;

                case 9:
                    Console.Write("Enter the index of the item to remove: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index >= 0 && index < arrayList.Count)
                    {
                        arrayList.RemoveAt(index);
                        Console.WriteLine("Item at index {0} removed.", index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    a = false; // Set 'a' to false to exit the loop
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 0 and 9.");
                    break;
            }
        }
    }
}
