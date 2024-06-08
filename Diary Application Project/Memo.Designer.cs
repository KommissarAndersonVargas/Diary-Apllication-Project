namespace Diary_Application_Project
{
    partial class Memo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memo));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Save_as = new System.Windows.Forms.ToolStripSplitButton();
            this.justSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMemo = new System.Windows.Forms.ToolStripButton();
            this.Open_Folder = new System.Windows.Forms.ToolStripButton();
            this.GoToPaint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.font = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colortext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.CenterAligment = new System.Windows.Forms.ToolStripButton();
            this.JustificatedAligment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Decrase = new System.Windows.Forms.ToolStripButton();
            this.Increase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(687, 430);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_as,
            this.NewMemo,
            this.Open_Folder,
            this.GoToPaint});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(687, 91);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Save_as
            // 
            this.Save_as.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justSave,
            this.SaveAs});
            this.Save_as.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_as.Image = global::Diary_Application_Project.Properties.Resources._85541_as_guardar_save_icon;
            this.Save_as.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_as.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_as.Name = "Save_as";
            this.Save_as.Size = new System.Drawing.Size(64, 88);
            this.Save_as.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // justSave
            // 
            this.justSave.Name = "justSave";
            this.justSave.Size = new System.Drawing.Size(121, 22);
            this.justSave.Text = "Save";
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(121, 22);
            this.SaveAs.Text = "Save as";
            // 
            // NewMemo
            // 
            this.NewMemo.AccessibleName = "New File";
            this.NewMemo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewMemo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMemo.Image = global::Diary_Application_Project.Properties.Resources._46774_add_notes_paper_document_icon;
            this.NewMemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewMemo.Name = "NewMemo";
            this.NewMemo.Size = new System.Drawing.Size(52, 88);
            this.NewMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewMemo.ToolTipText = "New file";
            this.NewMemo.Click += new System.EventHandler(this.NewMemo_Click);
            // 
            // Open_Folder
            // 
            this.Open_Folder.AccessibleDescription = "Open folder";
            this.Open_Folder.AccessibleName = "Open folder";
            this.Open_Folder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_Folder.Image = global::Diary_Application_Project.Properties.Resources.folder;
            this.Open_Folder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Open_Folder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_Folder.Name = "Open_Folder";
            this.Open_Folder.Size = new System.Drawing.Size(52, 88);
            this.Open_Folder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Open_Folder.ToolTipText = "Open Folder";
            // 
            // GoToPaint
            // 
            this.GoToPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoToPaint.Image = global::Diary_Application_Project.Properties.Resources._2250037_art_artistic_brush_materials_paint_icon;
            this.GoToPaint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GoToPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoToPaint.Name = "GoToPaint";
            this.GoToPaint.Size = new System.Drawing.Size(52, 88);
            this.GoToPaint.Text = "toolStripButton1";
            this.GoToPaint.ToolTipText = "Go to Microsoft Paint";
            this.GoToPaint.Click += new System.EventHandler(this.GoToPaint_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font,
            this.toolStripSeparator1,
            this.colortext,
            this.toolStripSeparator2,
            this.BackColor,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.CenterAligment,
            this.JustificatedAligment,
            this.toolStripSeparator6,
            this.Decrase,
            this.Increase,
            this.toolStripSeparator8,
            this.Copy,
            this.Paste,
            this.toolStripSeparator4,
            this.Undo,
            this.Redo,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 108);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // font
            // 
            this.font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.font.Image = ((System.Drawing.Image)(resources.GetObject("font.Image")));
            this.font.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(46, 59);
            this.font.Text = "toolStripButton1";
            this.font.ToolTipText = "Font";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // colortext
            // 
            this.colortext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colortext.Image = ((System.Drawing.Image)(resources.GetObject("colortext.Image")));
            this.colortext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.colortext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colortext.Name = "colortext";
            this.colortext.Size = new System.Drawing.Size(52, 59);
            this.colortext.Text = "toolStripButton2";
            this.colortext.ToolTipText = "Text Color";
            this.colortext.Click += new System.EventHandler(this.colortext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // BackColor
            // 
            this.BackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackColor.Image = global::Diary_Application_Project.Properties.Resources._11211455_highlighter_marker_tip_education_felt_tip_pen_icon;
            this.BackColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(52, 59);
            this.BackColor.Text = "toolStripButton3";
            this.BackColor.ToolTipText = "Back color";
            this.BackColor.Click += new System.EventHandler(this.BackColor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Diary_Application_Project.Properties.Resources._10131934_text_line_icon;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 59);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Left Align";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // CenterAligment
            // 
            this.CenterAligment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterAligment.Image = global::Diary_Application_Project.Properties.Resources._9023962_text_align_center_fill_icon;
            this.CenterAligment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CenterAligment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterAligment.Name = "CenterAligment";
            this.CenterAligment.Size = new System.Drawing.Size(52, 59);
            this.CenterAligment.Text = "toolStripButton5";
            this.CenterAligment.ToolTipText = "Center Line";
            this.CenterAligment.Click += new System.EventHandler(this.CenterAligment_Click);
            // 
            // JustificatedAligment
            // 
            this.JustificatedAligment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.JustificatedAligment.Image = global::Diary_Application_Project.Properties.Resources._9110890_text_align_right_icon;
            this.JustificatedAligment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.JustificatedAligment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JustificatedAligment.Name = "JustificatedAligment";
            this.JustificatedAligment.Size = new System.Drawing.Size(52, 59);
            this.JustificatedAligment.Text = "toolStripButton6";
            this.JustificatedAligment.ToolTipText = "Right Align ";
            this.JustificatedAligment.Click += new System.EventHandler(this.JustificatedAligment_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 62);
            // 
            // Decrase
            // 
            this.Decrase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Decrase.Image = global::Diary_Application_Project.Properties.Resources._351980_decrease_format_indent_icon;
            this.Decrase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Decrase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Decrase.Name = "Decrase";
            this.Decrase.Size = new System.Drawing.Size(52, 59);
            this.Decrase.Text = "toolStripButton7";
            this.Decrase.ToolTipText = "Decrease";
            this.Decrase.Click += new System.EventHandler(this.Decrase_Click);
            // 
            // Increase
            // 
            this.Increase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Increase.Image = global::Diary_Application_Project.Properties.Resources._352386_format_increase_indent_icon;
            this.Increase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Increase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(52, 59);
            this.Increase.ToolTipText = "Increase";
            this.Increase.Click += new System.EventHandler(this.Increase_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 62);
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Image = global::Diary_Application_Project.Properties.Resources._8530597_copy_icon;
            this.Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(46, 59);
            this.Copy.Text = "toolStripButton9";
            this.Copy.ToolTipText = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = global::Diary_Application_Project.Properties.Resources._173947_paste_icon;
            this.Paste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(52, 59);
            this.Paste.Text = "toolStripButton10";
            this.Paste.ToolTipText = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 62);
            // 
            // Undo
            // 
            this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo.Image = global::Diary_Application_Project.Properties.Resources._9027551_undo_arrow_icon;
            this.Undo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(52, 59);
            this.Undo.Text = "toolStripButton11";
            this.Undo.ToolTipText = "Undo";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Redo.Image = global::Diary_Application_Project.Properties.Resources._9027451_redo_icon;
            this.Redo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(52, 59);
            this.Redo.Text = "toolStripButton12";
            this.Redo.ToolTipText = "Redo";
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 62);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 598);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mega Memo";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(225, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(225, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Memo Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Memo Title:";
            // 
            // Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 692);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Memo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memo";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton NewMemo;
        private System.Windows.Forms.ToolStripButton Open_Folder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSplitButton Save_as;
        private System.Windows.Forms.ToolStripMenuItem justSave;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripButton font;
        private System.Windows.Forms.ToolStripButton colortext;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BackColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton CenterAligment;
        private System.Windows.Forms.ToolStripButton JustificatedAligment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton Decrase;
        private System.Windows.Forms.ToolStripButton Increase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripButton Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.ToolStripButton Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripButton GoToPaint;
    }
}