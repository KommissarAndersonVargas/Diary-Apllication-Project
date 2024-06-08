namespace Diary_Application_Project
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_button = new System.Windows.Forms.Button();
            this.serach_on_google = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.calendar_label = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer_label = new System.Windows.Forms.Label();
            this.BackToPc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.versionrelease_label = new System.Windows.Forms.Label();
            this.labelversion = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.AddMemo = new System.Windows.Forms.ToolStripButton();
            this.SerachMemo = new System.Windows.Forms.ToolStripButton();
            this.Settings = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loockScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.serach_on_google);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.calendar_label);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.timer_label);
            this.panel1.Controls.Add(this.BackToPc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 657);
            this.panel1.TabIndex = 0;
            // 
            // clear_button
            // 
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(233, 302);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(45, 26);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // serach_on_google
            // 
            this.serach_on_google.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serach_on_google.Location = new System.Drawing.Point(38, 302);
            this.serach_on_google.Name = "serach_on_google";
            this.serach_on_google.Size = new System.Drawing.Size(189, 25);
            this.serach_on_google.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Diary_Application_Project.Properties.Resources.google2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(4, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 7;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendar_label
            // 
            this.calendar_label.AutoSize = true;
            this.calendar_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_label.Location = new System.Drawing.Point(78, 59);
            this.calendar_label.Name = "calendar_label";
            this.calendar_label.Size = new System.Drawing.Size(124, 25);
            this.calendar_label.TabIndex = 6;
            this.calendar_label.Text = "My Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 104);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // timer_label
            // 
            this.timer_label.BackColor = System.Drawing.Color.Black;
            this.timer_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timer_label.Location = new System.Drawing.Point(-1, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(283, 51);
            this.timer_label.TabIndex = 3;
            this.timer_label.Text = "00:00:00";
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackToPc
            // 
            this.BackToPc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackToPc.BackColor = System.Drawing.Color.Transparent;
            this.BackToPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToPc.Image = global::Diary_Application_Project.Properties.Resources.computer;
            this.BackToPc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackToPc.Location = new System.Drawing.Point(67, 592);
            this.BackToPc.Name = "BackToPc";
            this.BackToPc.Size = new System.Drawing.Size(146, 52);
            this.BackToPc.TabIndex = 0;
            this.BackToPc.Text = "Back to PC";
            this.BackToPc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToPc.UseVisualStyleBackColor = false;
            this.BackToPc.Click += new System.EventHandler(this.BackToPc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.user_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.versionrelease_label);
            this.panel2.Controls.Add(this.labelversion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 732);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 56);
            this.panel2.TabIndex = 1;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(317, 20);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(12, 15);
            this.user_name.TabIndex = 3;
            this.user_name.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // versionrelease_label
            // 
            this.versionrelease_label.AutoSize = true;
            this.versionrelease_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionrelease_label.Location = new System.Drawing.Point(93, 20);
            this.versionrelease_label.Name = "versionrelease_label";
            this.versionrelease_label.Size = new System.Drawing.Size(12, 15);
            this.versionrelease_label.TabIndex = 1;
            this.versionrelease_label.Text = "-";
            // 
            // labelversion
            // 
            this.labelversion.AutoSize = true;
            this.labelversion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelversion.Location = new System.Drawing.Point(18, 20);
            this.labelversion.Name = "labelversion";
            this.labelversion.Size = new System.Drawing.Size(51, 15);
            this.labelversion.TabIndex = 0;
            this.labelversion.Text = "Version:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.AddMemo,
            this.SerachMemo,
            this.Settings,
            this.Tools,
            this.Info,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 75);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::Diary_Application_Project.Properties.Resources.close2;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 72);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AddMemo
            // 
            this.AddMemo.AccessibleDescription = "To write a new memo";
            this.AddMemo.AccessibleName = "To write a new memo";
            this.AddMemo.AutoSize = false;
            this.AddMemo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemo.Image = global::Diary_Application_Project.Properties.Resources.edit;
            this.AddMemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddMemo.Name = "AddMemo";
            this.AddMemo.Size = new System.Drawing.Size(91, 73);
            this.AddMemo.Text = "Add Memo";
            this.AddMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddMemo.Click += new System.EventHandler(this.AddMemo_Click);
            // 
            // SerachMemo
            // 
            this.SerachMemo.AccessibleDescription = "Search memos";
            this.SerachMemo.AccessibleName = "Serach memos";
            this.SerachMemo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerachMemo.Image = global::Diary_Application_Project.Properties.Resources.search;
            this.SerachMemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SerachMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SerachMemo.Name = "SerachMemo";
            this.SerachMemo.Size = new System.Drawing.Size(108, 72);
            this.SerachMemo.Text = "Serach Memo";
            this.SerachMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Settings
            // 
            this.Settings.AccessibleDescription = "Settings";
            this.Settings.AccessibleName = "Settings";
            this.Settings.AutoSize = false;
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Image = global::Diary_Application_Project.Properties.Resources.settings;
            this.Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(80, 73);
            this.Settings.Text = "Settings";
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // Tools
            // 
            this.Tools.AccessibleDescription = "Tools";
            this.Tools.AccessibleName = "Tools";
            this.Tools.AutoSize = false;
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.Tools.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools.Image = global::Diary_Application_Project.Properties.Resources.people;
            this.Tools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(80, 73);
            this.Tools.Text = "Tools";
            this.Tools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // Info
            // 
            this.Info.AccessibleDescription = "Information";
            this.Info.AutoSize = false;
            this.Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Image = global::Diary_Application_Project.Properties.Resources.info1;
            this.Info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(80, 73);
            this.Info.Text = "About Us";
            this.Info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(52, 78);
            this.toolStripButton7.Text = "Minimize";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loockScreenToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            // 
            // loockScreenToolStripMenuItem
            // 
            this.loockScreenToolStripMenuItem.Name = "loockScreenToolStripMenuItem";
            this.loockScreenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loockScreenToolStripMenuItem.Text = "Lock Aplication";
            this.loockScreenToolStripMenuItem.Click += new System.EventHandler(this.loockScreenToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Diary_Application_Project.Properties.Resources.bears3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 788);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dairy Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton AddMemo;
        private System.Windows.Forms.ToolStripButton SerachMemo;
        private System.Windows.Forms.ToolStripDropDownButton Settings;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Tools;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Info;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Button BackToPc;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label calendar_label;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelversion;
        private System.Windows.Forms.Label versionrelease_label;
        private System.Windows.Forms.TextBox serach_on_google;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loockScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

