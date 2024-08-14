namespace Diary_Application_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.forgot_password = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Info = new System.Windows.Forms.ToolStripButton();
            this.new_user = new System.Windows.Forms.ToolStripButton();
            this.close = new System.Windows.Forms.Button();
            this.UserSelect = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diary Application Pro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(257, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // forgot_password
            // 
            this.forgot_password.FlatAppearance.BorderSize = 5;
            this.forgot_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.Location = new System.Drawing.Point(257, 435);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(174, 36);
            this.forgot_password.TabIndex = 5;
            this.forgot_password.Text = "Forgot the Password ?";
            this.forgot_password.UseVisualStyleBackColor = true;
            this.forgot_password.Click += new System.EventHandler(this.forgot_password_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(257, 215);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(174, 27);
            this.userName.TabIndex = 6;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(257, 284);
            this.passWord.Multiline = true;
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(174, 27);
            this.passWord.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info,
            this.new_user});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 75);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Image = global::Diary_Application_Project.Properties.Resources.info1;
            this.Info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(98, 72);
            this.Info.Text = "Information";
            this.Info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Info.ToolTipText = "Information";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // new_user
            // 
            this.new_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_user.Image = global::Diary_Application_Project.Properties.Resources._new_add_plus_user_icon;
            this.new_user.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.new_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(99, 72);
            this.new_user.Text = "Registration";
            this.new_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::Diary_Application_Project.Properties.Resources._34217_close_delete_remove_icon;
            this.close.Location = new System.Drawing.Point(630, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(47, 48);
            this.close.TabIndex = 9;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // UserSelect
            // 
            this.UserSelect.FormattingEnabled = true;
            this.UserSelect.Location = new System.Drawing.Point(449, 218);
            this.UserSelect.Name = "UserSelect";
            this.UserSelect.Size = new System.Drawing.Size(147, 21);
            this.UserSelect.TabIndex = 10;
            this.UserSelect.Text = "Select the User";
            this.UserSelect.SelectedIndexChanged += new System.EventHandler(this.UserSelect_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diary_Application_Project.Properties.Resources.aurora_laranja_canada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 529);
            this.Controls.Add(this.UserSelect);
            this.Controls.Add(this.close);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Diary Pro";
            this.Load += new System.EventHandler(this.Login_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button forgot_password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Info;
        private System.Windows.Forms.ToolStripButton new_user;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox UserSelect;
    }
}