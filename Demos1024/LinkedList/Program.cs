﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new LinkedListNode of type String and display its
            // properties
            LinkedListNode < String > lln = new LinkedListNode<string>("orange");
            Console.WriteLine("Display properties");
            DisplayProperties(lln);
            Console.WriteLine();

            // create linked list
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);

            // add
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("\nafter adding other nodes");
            DisplayProperties(lln);

            Console.WriteLine("Traversal");
            LinkedListNode<string> node = ll.First;  // setting node variable to first node in the list
            while (node != null)
            {
                Console.WriteLine("     {0}", node.Value);
                node = node.Next;  // setting node to next node in the list
            }
            Console.WriteLine();
        }

        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            {
                if (lln.List == null)
                    Console.WriteLine("     Node is not linked");
                else
                    Console.WriteLine("     Node belongs to a linked list with {0} elements", lln.List.Count);

                if (lln.Previous == null)
                    Console.WriteLine("     Previous node is null");
                else
                    Console.WriteLine("     Value of previous node: {0}", lln.Previous.Value);

                if (lln.Next == null)
                    Console.WriteLine("     Next node is null");
                else
                    Console.WriteLine("     Value of next node: {0}", lln.Next.Value);
            }
        }
    }
}
