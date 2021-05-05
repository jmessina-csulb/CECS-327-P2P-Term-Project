using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P2P
{
    //The Nodes Class is designed to store, and update information about the node.
    class Node
    {
        private string key = null;
        private string value = null;
       
        //Passes key and value onto a node
        public Node(string x, string y)
        {
            key = x;
            value = y;
        }

        //Sets parameters x(key) y(value) to a node.
        public void Set(string x, string y)
        {
            key = x;
            value = y;
        }
        //Returns key of the node.
        public string getKey()
        {
            return key;
        }
        //Returns value of the node.
        public string getValue()
        {
            return value;
        }

    }
}
