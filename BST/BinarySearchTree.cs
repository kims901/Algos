using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.BST
{

    
    public class BinarySearchTree
    {

        public BinarySearchTree()
        {
            Node binarySearchTree = new Node(20);
            binarySearchTree.insert(15);
            binarySearchTree.insert(25);
            binarySearchTree.insert(65);
            binarySearchTree.insert(8);
            binarySearchTree.insert(48);
            binarySearchTree.insert(19);
            binarySearchTree.insert(23);
            binarySearchTree.insert(70);

            var exists = false;
            exists = binarySearchTree.contains(15);
            exists = binarySearchTree.contains(28);
            exists = binarySearchTree.contains(65);


            Console.WriteLine("--------------PreOrderTraversal-----------");
            binarySearchTree.PreOrderTraversal();

            Console.WriteLine("--------------InOrderTraversal-----------");
            binarySearchTree.InOrderTraversal();

            Console.WriteLine("--------------PostOrderTraversal-----------");
            binarySearchTree.PostOrderTraversal();
        }        

    }

    public class Node
    {
        Node left;
        Node right;

        public int data;

        public Node(int pdata)
        {                    
            this.data = pdata;
        }

        public void insert(int value)
        {
            if(value < data)
            {
                if (left == null)
                    left = new Node(value);
                else
                {
                    left.insert(value);
                }
            }
            else if (value > data)
            {
                if(right == null)
                    right = new Node(value);
                else
                {
                    right.insert(value);
                }
            }            
        }

        public bool contains(int value)
        {
            if (value == data) return true;

            if (value < data)
                return left != null && left.contains(value);            
            else if (value > data)
                return right != null && right.contains(value);

            return false;
        }

        
        public void PreOrderTraversal()
        {
            Console.WriteLine(data);

            if (left != null) left.PreOrderTraversal();

            if (right != null) right.PreOrderTraversal();

        }

        public void InOrderTraversal()
        {
            if (left != null) left.InOrderTraversal();
            Console.WriteLine(data);
            if (right != null) right.InOrderTraversal();

        }

        public void PostOrderTraversal()
        {
            if (left != null) left.PostOrderTraversal();
            
            if (right != null) right.PostOrderTraversal();

            Console.WriteLine(data);
        }




    }
}
