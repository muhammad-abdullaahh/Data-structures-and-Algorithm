using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int action, count=0;
            Console.Write("Define the maximum size of your inventory : ");
            int size=Convert.ToInt32(Console.ReadLine());
            String[] arr = new string[size];
            do
            {
                Console.WriteLine("\n\nSelect the action you want to perform \n1.Add item\n2.Remove item\n" +
                                  "3.Search item\n4.Display inventory\n5.Exit");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        if (count < size)
                        {
                            Console.Write("Enter item name : ");
                            String itemName=Console.ReadLine();
                            arr[count] = itemName;
                            count++;
                            Console.WriteLine("Item added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Inventory is full");
                        }
                        break;
                    case 2:
                        Console.Write("Enter the name of the item to be removed :");
                        String removeItem = Console.ReadLine();
                        bool itemRemoved = false;
                        for(int i=0; i < size; i++)
                        {
                            if (removeItem == arr[i])
                            {
                                count--;
                                itemRemoved = true;
                            }
                        }
                        if (itemRemoved != true)
                        {
                            Console.WriteLine("Item does not exist in the inventory");
                        }
                        else
                        {
                            Console.WriteLine("Item removed successfully");
                        }
                            break;
                    case 3:
                        Console.Write("Enter the item you want to search :");
                        String searchItem=Console.ReadLine();
                        bool itemSearched = false;
                        for(int i=0;i < size; i++)
                        {
                            if (searchItem == arr[i])
                            {
                                Console.WriteLine("Item found at position {0}", i+1);
                                itemSearched = true;
                            }
                        }
                        if(itemSearched == false)
                        {
                            Console.WriteLine("Item not found in the inventory ");
                        }
                        break;
                    case 4:
                        bool displayInventory = false;
                        if (size != 0)
                        {
                            Console.WriteLine("The items in the inventory are :");
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(arr[i]);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no items in the inventory");
                        }
                        break;
                }
            }
            while (action != 5);
        }
    }
}
