namespace P2P
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Cleans up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SSF = new System.Windows.Forms.Button();
            this.GSF = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.anode = new System.Windows.Forms.Button();
            this.DN = new System.Windows.Forms.Button();
            this.PAF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SSF
            // 
            this.SSF.BackColor = System.Drawing.Color.LightPink;
            this.SSF.Location = new System.Drawing.Point(120, 165);
            this.SSF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SSF.Name = "SSF";
            this.SSF.Size = new System.Drawing.Size(180, 35);
            this.SSF.TabIndex = 0;
            this.SSF.Text = "Send Some Files";
            this.SSF.UseVisualStyleBackColor = false;
            this.SSF.Click += new System.EventHandler(this.SSF_Click);
            // 
            // GSF
            // 
            this.GSF.BackColor = System.Drawing.Color.LightPink;
            this.GSF.Location = new System.Drawing.Point(463, 165);
            this.GSF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GSF.Name = "GSF";
            this.GSF.Size = new System.Drawing.Size(180, 35);
            this.GSF.TabIndex = 1;
            this.GSF.Text = "Get Some Files";
            this.GSF.UseVisualStyleBackColor = false;
            this.GSF.Click += new System.EventHandler(this.GSF_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Black;
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(116, 14);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(527, 20);
            this.message.TabIndex = 3;
            this.message.Text = "Make sure you add a node and a folder before sending or requesting files.";
            this.message.Click += new System.EventHandler(this.Label2_Click);
            // 
            // anode
            // 
            this.anode.BackColor = System.Drawing.Color.LightPink;
            this.anode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.anode.Location = new System.Drawing.Point(463, 75);
            this.anode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anode.Name = "anode";
            this.anode.Size = new System.Drawing.Size(180, 35);
            this.anode.TabIndex = 4;
            this.anode.Text = "Add Nodes";
            this.anode.UseVisualStyleBackColor = false;
            this.anode.Click += new System.EventHandler(this.Anode_Click);
            // 
            // DN
            // 
            this.DN.BackColor = System.Drawing.Color.LightPink;
            this.DN.Location = new System.Drawing.Point(288, 250);
            this.DN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(180, 35);
            this.DN.TabIndex = 5;
            this.DN.Text = "Delete Nodes";
            this.DN.UseVisualStyleBackColor = false;
            this.DN.Click += new System.EventHandler(this.DN_Click);
            // 
            // PAF
            // 
            this.PAF.BackColor = System.Drawing.Color.LightPink;
            this.PAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAF.Location = new System.Drawing.Point(120, 75);
            this.PAF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PAF.Name = "PAF";
            this.PAF.Size = new System.Drawing.Size(180, 35);
            this.PAF.TabIndex = 6;
            this.PAF.Text = "Pick a Folder";
            this.PAF.UseCompatibleTextRendering = true;
            this.PAF.UseVisualStyleBackColor = false;
            this.PAF.Click += new System.EventHandler(this.PAF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(745, 362);
            this.Controls.Add(this.PAF);
            this.Controls.Add(this.DN);
            this.Controls.Add(this.anode);
            this.Controls.Add(this.message);
            this.Controls.Add(this.GSF);
            this.Controls.Add(this.SSF);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SSF;
        private System.Windows.Forms.Button GSF;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button anode;
        private System.Windows.Forms.Button DN;
        private System.Windows.Forms.Button PAF;
    }
}

