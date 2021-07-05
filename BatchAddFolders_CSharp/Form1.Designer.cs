namespace BatchAddFolders_CSharp
{
    partial class Form1
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
            this.VaultsLabel = new System.Windows.Forms.Label();
            this.VaultsComboBox = new System.Windows.Forms.ComboBox();
            this.AddFolders = new System.Windows.Forms.Button();
            this.CreateFolders = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            //VaultsLabel
            //
            this.VaultsLabel.AutoSize = true;
            this.VaultsLabel.Location = new System.Drawing.Point(13, 26);
            this.VaultsLabel.Name = "VaultsLabel";
            this.VaultsLabel.Size = new System.Drawing.Size(94, 13);
            this.VaultsLabel.TabIndex = 0;
            this.VaultsLabel.Text = " Select vault view:";
            //
            //VaultsComboBox
            //
            this.VaultsComboBox.FormattingEnabled = true;
            this.VaultsComboBox.Location = new System.Drawing.Point(16, 42);
            this.VaultsComboBox.Name = "VaultsComboBox";
            this.VaultsComboBox.Size = new System.Drawing.Size(121, 21);
            this.VaultsComboBox.TabIndex = 1;
            //
            //AddFolders
            //
            this.AddFolders.Location = new System.Drawing.Point(16, 112);
            this.AddFolders.Name = "AddFolders";
            this.AddFolders.Size = new System.Drawing.Size(145, 23);
            this.AddFolders.TabIndex = 3;
            this.AddFolders.Text = "Add folder to the batch...";
            this.AddFolders.UseVisualStyleBackColor = true;
            this.AddFolders.Click += new System.EventHandler(AddFolders_Click);
            //
            //CreateFolders
            //
            this.CreateFolders.Location = new System.Drawing.Point(111, 156);
            this.CreateFolders.Name = "CreateFolders";
            this.CreateFolders.Size = new System.Drawing.Size(98, 23);
            this.CreateFolders.TabIndex = 5;
            this.CreateFolders.Text = "Create folders";
            this.CreateFolders.UseVisualStyleBackColor = true;
            this.CreateFolders.Click += new System.EventHandler(CreateFolders_Click);
            //
            //TextBox1
            //
            this.TextBox1.Location = new System.Drawing.Point(16, 88);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(289, 20);
            this.TextBox1.TabIndex = 6;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 72);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(237, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Type name of new folder to add to the vault root:";
            //
            //Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 208);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.CreateFolders);
            this.Controls.Add(this.AddFolders);
            this.Controls.Add(this.VaultsComboBox);
            this.Controls.Add(this.VaultsLabel);
            this.Name = "Form1";
            this.Text = "Add folders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label VaultsLabel;
        internal System.Windows.Forms.ComboBox VaultsComboBox;
        internal System.Windows.Forms.Button AddFolders;
        internal System.Windows.Forms.Button CreateFolders;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
    }
}


