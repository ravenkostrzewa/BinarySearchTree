using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class BinarySearchTree
    {
        public string createNode;
        public int nodeData;
        public string createChildren;
        public int level;
        public int leftChildData;
        public int rightChildData;
        //public int newNode;
        public string userInput;
        public bool searchAgain;
        public int userSearch;

        public void CreateRoot()
        {
            for (level = 0; level > 0; level++)
            {
                level = 0;
                Console.WriteLine("Level: 0   Enter the data for the root: ");
                nodeData = int.Parse(Console.ReadLine());
                Console.WriteLine("Level: " + level + " Node Data: " + nodeData);
                AddChildren();
            }
        }

        public void AddNode()
        {
            Console.WriteLine("Would you like to create a node? Enter yes or no");
            createNode = Console.ReadLine();
            if (createNode == "yes")
            {
                for (level = 1; level >= 0; level++)
                {
                    Console.WriteLine("Enter the node data: ");
                    nodeData = int.Parse(Console.ReadLine());
                    Console.WriteLine("Level: " + level + " Node Data: " + nodeData);
                }
            }
        }

        public void AddChildren()
        {
            for (level = 0; level > 0; level++)
            {
                Console.WriteLine("Would you like to create two children? Enter yes or no");
                createChildren = Console.ReadLine();
                if (createChildren == "yes")
                {
                    Console.WriteLine("Enter the data for the left child: ");
                    leftChildData = int.Parse(Console.ReadLine());
                    if (leftChildData < nodeData)
                    {
                        nodeData = leftChildData;
                        Console.WriteLine("Level: " + level + " Node Data: " + nodeData);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is an invalid entry. The left node data must be less than that of the node above it.");
                        AddChildren();
                    }
                    Console.WriteLine("Enter the data for the right child: ");
                    rightChildData = int.Parse(Console.ReadLine());
                    Console.WriteLine("Level: " + level + " Node Data: " + nodeData);
                    if (rightChildData > nodeData)
                    {
                        nodeData = rightChildData;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is an invalid entry. The right node data must be greater than that of the node above it");
                        AddChildren();
                    }
                }
                else if (createChildren == "no")
                {
                    AddNode();
                }
                else if (createNode != "yes" && createNode != "no")
                {
                    Console.WriteLine("Sorry, that is an invalid answer.");
                    AddNode();
                }
                else if (createNode == "no")
                {
                    ExitSearchTree();
                }
            }
        }

        public void SearchForNode()
        {
            Console.WriteLine("What data are you searching for?");
            userSearch = int.Parse(Console.ReadLine());
            for (level = 0; level > 0; level++)
            {
                if (userSearch == nodeData)
                {
                    Console.WriteLine("Level: " + level + " Data: " + nodeData);
                    Console.WriteLine("Would you like to search again? Enter yes or no");
                    userInput = Console.ReadLine();
                    if (userInput == "yes")
                    {
                        searchAgain = true;
                        SearchForNode();
                    }
                    else if (userInput == "no")
                    {
                        searchAgain = false;
                        ExitSearchTree();
                    }
                }
                else if (userSearch != nodeData)
                {
                    Console.WriteLine("Sorry, " + userSearch + " is not located in the binary search tree.");
                    SearchForNode();
                }
            }
        }

        public void ExitSearchTree()
        {
            Console.WriteLine("You have exited the binary search tree. Goodbye.");
        }
    }
}

