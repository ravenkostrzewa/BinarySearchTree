using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Node
    {
        public Node leftChild;
        public int data;
        public Node rightChild;
        public string createNode;
        public int nodeData;
        public string createChildren;
        public int level;
        public int leftChildData;
        public int rightChildData;
        public int newNode;
        public string userInput;
        public bool searchAgain;
        public int userSearch;

        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }
    }
}
