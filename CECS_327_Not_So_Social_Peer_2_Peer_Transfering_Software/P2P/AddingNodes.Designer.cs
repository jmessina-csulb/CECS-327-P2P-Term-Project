namespace P2P
{
    partial class addingNodes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addingNodes));
            this.node_label = new System.Windows.Forms.Label();
            this.ip_label = new System.Windows.Forms.Label();
            this.node_textbox = new System.Windows.Forms.TextBox();
            this.ipatext = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // node_label
            // 
            this.node_label.AutoSize = true;
            this.node_label.Location = new System.Drawing.Point(352, 153);
            this.node_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.node_label.Name = "node_label";
            this.node_label.Size = new System.Drawing.Size(249, 20);
            this.node_label.TabIndex = 0;
            this.node_label.Text = "Please enter a name for the node.";
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(352, 62);
            this.ip_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(257, 20);
            this.ip_label.TabIndex = 1;
            this.ip_label.Text = "Enter the Node\'s IP Address Here. ";
            this.ip_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ip_label.Click += new System.EventHandler(this.ip_label_Click);
            // 
            // node_textbox
            // 
            this.node_textbox.Location = new System.Drawing.Point(356, 178);
            this.node_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.node_textbox.Name = "node_textbox";
            this.node_textbox.Size = new System.Drawing.Size(178, 26);
            this.node_textbox.TabIndex = 2;
            // 
            // ipatext
            // 
            this.ipatext.Location = new System.Drawing.Point(356, 87);
            this.ipatext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipatext.Name = "ipatext";
            this.ipatext.Size = new System.Drawing.Size(178, 26);
            this.ipatext.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightPink;
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(231, 251);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(393, 89);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.Anode_Click);
            // 
            // addingNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 387);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ipatext);
            this.Controls.Add(this.node_textbox);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.node_label);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addingNodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding A Node";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label node_label;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.TextBox node_textbox;
        private System.Windows.Forms.TextBox ipatext;
        private System.Windows.Forms.Button saveButton;
    }
}