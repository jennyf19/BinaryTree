using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    //implements the generic IComparable<TItem> interface
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        //three public properties to the Tree<TItem> class
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        //add a constructor (same name as method) that takes a single parameter (NodeData) and sets L&R values to null
        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        //method called Insert to insert a TItem value into tree
        public void Insert(TItem newItem)
        {
            //Insert method implements the recursive algorithm for creating an ordered binary tree
            //Construtor creates the initial node
            //Insert method can assume the tree is not empty
            //declare a variable of type TItem called currentNodeValue. Intialize variable to value of NodeData
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            { 
                //Insert the new item into the left subtree
                if(this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                //insert the new item into the riht subtree
                if(this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }
        //method called WalkTree. visit each node in sequence and generate a string to display the data
        public string WalkTree()
        {
            // Create a new list to hold all the values.
            List<string> nodeValues = new List<string>();
            
            // If there are values in the left subtree, get the string representaion.
            if (this.LeftTree != null)
            {
                nodeValues.Add(this.LeftTree.WalkTree());
            }

            // Get the string representation of the current node value.
            nodeValues.Add(this.NodeData.ToString());

            // If there are values in the right subtree, get the string representation.
            if (this.RightTree != null)
            {
                nodeValues.Add(this.RightTree.WalkTree());
            }

            // String.Join() takes a separator and a list of values and creates a
            // new string with the separator in between each value in the list.
            string result = String.Join(", ", nodeValues);

            // Return the full string representation.
            return result;

            ////as each node is visited, the node value is returned to the string
            //string result = "";

            //if (this.LeftTree != null)
            //{
            //    result = this.LeftTree.WalkTree();
            //}

            //result += $"{this.NodeData.ToString()}";
            
            //if (this.RightTree != null)
            //{
            //    result += this.RightTree.WalkTree();
            //}

            //return result;
        }
    }
}

