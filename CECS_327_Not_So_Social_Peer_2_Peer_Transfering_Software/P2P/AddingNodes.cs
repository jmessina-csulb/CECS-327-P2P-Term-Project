using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    // The addingNodes class allows the user to add a new node.
    public partial class addingNodes : Form
    {
        public DHT HT { get; set; }
        public addingNodes(DHT DH)
        {
            InitializeComponent();
            HT = DH;
        }

        private void Anode_Click(object sender, EventArgs e)
        {
            string key = node_textbox.Text;
            string value = ipatext.Text;
            //If the key already exists, then notify the user.
            if(HT.find_key(key))
            {
                MessageBox.Show("The node exists already! ");
            }
            //If the key does not exist, add the node.
            else
            {
                HT.Add(key, value);
                MessageBox.Show("Successfully added node! ");
                this.Close();
            }
            
        }

        private void ip_label_Click(object sender, EventArgs e)
        {

        }
    }
}
