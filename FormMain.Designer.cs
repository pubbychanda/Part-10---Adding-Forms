namespace Part_10___Adding_Forms
{
    partial class FormMain
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnEditNames = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 12);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(103, 23);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnEditNames
            // 
            this.btnEditNames.Location = new System.Drawing.Point(12, 41);
            this.btnEditNames.Name = "btnEditNames";
            this.btnEditNames.Size = new System.Drawing.Size(103, 23);
            this.btnEditNames.TabIndex = 1;
            this.btnEditNames.Text = "Edit Name";
            this.btnEditNames.UseVisualStyleBackColor = true;
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(12, 70);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveName.TabIndex = 2;
            this.btnRemoveName.Text = "Remove Name";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 201);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(121, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(139, 212);
            this.lstNames.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 235);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnEditNames);
            this.Controls.Add(this.btnAddName);
            this.Name = "FormMain";
            this.Text = "Epic Name List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnEditNames;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lstNames;
    }
}

