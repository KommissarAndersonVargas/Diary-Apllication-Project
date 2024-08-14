namespace Diary_Application_Project
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.psswConfirmBox = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.version_number = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password confirm: ";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(203, 219);
            this.userNameBox.Multiline = true;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(171, 30);
            this.userNameBox.TabIndex = 3;
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(203, 295);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(170, 28);
            this.passwordBox.TabIndex = 4;
            // 
            // psswConfirmBox
            // 
            this.psswConfirmBox.Location = new System.Drawing.Point(203, 381);
            this.psswConfirmBox.Multiline = true;
            this.psswConfirmBox.Name = "psswConfirmBox";
            this.psswConfirmBox.PasswordChar = '*';
            this.psswConfirmBox.Size = new System.Drawing.Size(170, 30);
            this.psswConfirmBox.TabIndex = 5;
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.PowderBlue;
            this.SaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("SaveChanges.Image")));
            this.SaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveChanges.Location = new System.Drawing.Point(217, 434);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(146, 42);
            this.SaveChanges.TabIndex = 6;
            this.SaveChanges.Text = "Save Data";
            this.SaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.version_number);
            this.panel1.Controls.Add(this.version);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 57);
            this.panel1.TabIndex = 8;
            // 
            // version_number
            // 
            this.version_number.AutoSize = true;
            this.version_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_number.Location = new System.Drawing.Point(73, 26);
            this.version_number.Name = "version_number";
            this.version_number.Size = new System.Drawing.Size(11, 13);
            this.version_number.TabIndex = 1;
            this.version_number.Text = "-";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(12, 26);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(57, 13);
            this.version.TabIndex = 0;
            this.version.Text = "Version: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diary_Application_Project.Properties.Resources._49576_new_add_plus_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(203, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::Diary_Application_Project.Properties.Resources._34217_close_delete_remove_icon;
            this.close.Location = new System.Drawing.Point(517, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(54, 49);
            this.close.TabIndex = 10;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(583, 581);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.psswConfirmBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox psswConfirmBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label version_number;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close;
    }
}