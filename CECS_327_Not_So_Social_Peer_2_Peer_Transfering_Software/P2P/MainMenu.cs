using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    public partial class MainForm : Form
    {
        DHT HashTable;

        string folName;
        public MainForm()
        {
            InitializeComponent();
            //The DHT has a size of 10
            HashTable = new DHT(10);
            folName = "";

        }

        /// <summary>
        /// Send some files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SSF_Click(object sender, EventArgs e)
        {
            //If user does not add a node before trying to send files, Display this message.
            if (HashTable.isEmpty())
            {
                MessageBox.Show("Please add a Node first!");
            }
            else
            {
                //If user does not add a folder location, display this error message.
                if (folName.Equals(""))
                {
                    MessageBox.Show("Please select a folder first!");
                }
                else
                {
                    //If all is well send the information
                    var x = new SendingFiles(HashTable, folName);
                    this.Hide();
                    x.ShowDialog();
                    this.Show();
                }
            }

        }
        /// <summary>
        /// Receive some files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GSF_Click(object sender, EventArgs e)
        {
            if (HashTable.isEmpty())
            {
                MessageBox.Show("Please add a Node first!");
            }
            else
            {
                if (folName.Equals(""))
                {
                    MessageBox.Show("SPlease select a folder first!");
                }
                else
                {
                    var x = new Receive_end(HashTable, folName);
                    this.Hide();
                    x.ShowDialog();
                    this.Show();
                }
            }
        }

        /// <summary>
        /// Adding Nodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Anode_Click(object sender, EventArgs e)
        {
            var x = new addingNodes(HashTable);
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Removing Nodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DN_Click(object sender, EventArgs e)
        {
            if (HashTable.isEmpty())
            {
                MessageBox.Show("Nothing to Delete");
            }
            else
            {
                var x = new removingNodes(HashTable);
                this.Hide();
                x.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Pick a Folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PAF_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    folName = fbd.SelectedPath;
                    PAF.Text = fbd.SelectedPath;
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
