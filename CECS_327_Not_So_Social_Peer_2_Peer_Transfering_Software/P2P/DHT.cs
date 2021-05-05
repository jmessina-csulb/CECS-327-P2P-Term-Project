using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    //The DHT Class is designed to store nodes and their Key/Value pairs.
    public class DHT
    {
        private Node[] HT;
        private int size;
        private int amount;
        private List<string> keys;
        private List<string> values;
        /// <summary>
        /// DHT Constructor
        /// </summary>
        /// <param name="con"></param>
        public DHT(int con)
        {
            amount = con;
            size = 0;
            keys = new List<string>();
            values = new List<string>();
            HT = new Node[con];



            for (int i = 0; i < amount; i++)
                HT[i] = null;
        }

        /// <summary>
        /// The sizes function returns the size of our DHT
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// The isEmpty function returns true if it is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return Size() == 0;
        }

        /// <summary>
        /// get_index function will retrive the index of nodes location
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int get_index(string k)
        {

            BigInteger hashCode = Hashing(k);
            int mod = Math.Abs((int)(hashCode % int.MaxValue));
            int index = (mod % amount);
            return index;
        }

        /// <summary>
        /// Hashing completes a SHA256 Hashing
        /// </summary>
        /// <param name="rawinput"></param>
        /// <returns></returns>
        private BigInteger Hashing(string rawinput)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawinput));

                // Convert byte array to a string   
                StringBuilder byte_builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    byte_builder.Append(bytes[i].ToString("X2"));
                }
                string temp = byte_builder.ToString();

                return BigInteger.Parse(temp, System.Globalization.NumberStyles.HexNumber);
            }
        }

        /// <summary>
        /// The get_values function returns the value of the given key
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public string get_value(string x)
        {
            if (HT[get_index(x)] != null)
            {
                int y = get_index(x);
                return HT[get_index(x)].getValue();
            }
            else
            {
                int y = get_index(x);
                return "";
            }

        }

        /// <summary>
        /// The Add function will add a node into the DHT
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Add(string x, string y)
        {
            if (HT[get_index(x)] == null)
            {
                int i = get_index(x);
                HT[get_index(x)] = new Node(x, y);
                keys.Add(x);
                size++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The remove function will remove the key and value and set it to null
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool Remove(string k)
        {
            if(HT[get_index(k)] == null)
            {
                //Unable to remove if DHT index is null
                return false;
            }

            if (HT[get_index(k)].getKey() == k)
            {
                HT[get_index(k)] = null;
                size--;
                return true;
            }
            else //If the DHT index is not empty and key does not exist
            {
                return false;
            }
        }

        
        /// <summary>
        /// The Find_Key will return true if the key exists, if not it will return false. 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool find_key(string x)
        {
            var y = get_index(x);
            var z = HT[y];
            if (z == null)
                return false;
            else if (HT[get_index(x)].getKey() == x)
                return true;
            else
                return false;
        }

        /// <summary>
        /// The get_keys function will collect all keys in the list
        /// </summary>
        /// <returns></returns>
        public List<string> get_keys()
        {
            return keys;
        }

        /// <summary>
        /// The get_values function will collect all values in the list
        /// </summary>
        /// <returns></returns>
        public List<string> get_values()
        {
            List<string> temp = new List<string>();
            foreach (var i in keys)
                temp.Add(get_value(i));
            return temp;
        }
    }


}
