using System;
using System.Linq;
using NUnit.Framework;

namespace BinaryTree
{
    [TestFixture]
    public class TreeUnitTests
    {   
        /// <summary>
        /// Sorts the integers in order
        /// </summary>
        [Test]
        public void TestSortIntegers()
        {
            //this is making a new class w/Tree<TItem>, but specifically for integers
            Tree<int> tree1 = new Tree<int>(4);
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

            string result = tree1.WalkTree();

            Assert.AreEqual(result, "-12, -8, 0, 4, 5, 5, 8, 8, 10, 11, 14, 15");
        }

        /// <summary>
        /// Walk through the tree and print the integers in-order
        /// </summary>
        [Test]
        public void WalkInOrder()
        {
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Walk through the tree and print the integers in preorder
        /// </summary>
        [Test]
        public void WalkPreOrder()
        {
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Walk through the tree and print the integers in postorder
        /// </summary>
        [Test]
        public void WalkPostOrder()
        {
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Walk through the tree and print in level order
        /// </summary>
        [Test]
        public void WalkLevelOrder()
        {
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Search for a given node
        /// </summary>
        [Test]
        public void NodeSearch()
        {
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Insert a node in the tree
        /// </summary>
        [Test]
        public void NodeInsert()
        {
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Delete a node in the tree
        /// </summary>
        [Test]
        public void NodeDelete()
        { 
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Track a subtree degree
        /// </summary>
        [Test]
        public void SubtreeDegree()
        {
            Assert.AreEqual(true, false);
        }
    }
}
