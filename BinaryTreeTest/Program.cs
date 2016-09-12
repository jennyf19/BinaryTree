using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new binary tree for holding ints
            //constructor creates an initial node containing the value 10
            //the insert statements add nodes to the tree
            
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);
            tree1.Insert(8);
            tree1.Insert(8);

            //WalkTree method generates a string representing the contents of the tree, which appear
            //in ascending order
            string sortedData = tree1.WalkTree();
            Console.WriteLine($"Sorted data is: {sortedData}");
            Console.ReadLine();
        }
    }
}
