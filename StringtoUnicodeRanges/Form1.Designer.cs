namespace StringtoUnicodeRanges
{
    partial class StringToUnicodeRange
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.convertTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textMeshProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyRangeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(440, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(568, 118);
            this.richTextBox2.MaximumSize = new System.Drawing.Size(1200, 800);
            this.richTextBox2.MinimumSize = new System.Drawing.Size(200, 300);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(200, 305);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.AutoSize = true;
            this.ConvertButton.Location = new System.Drawing.Point(487, 226);
            this.ConvertButton.MaximumSize = new System.Drawing.Size(200, 200);
            this.ConvertButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(60, 60);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertTypeToolStripMenuItem,
            this.applyRangeFilterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.convertTypeToolStripMenuItem1;
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // convertTypeToolStripMenuItem
            // 
            this.convertTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.textMeshProToolStripMenuItem});
            this.convertTypeToolStripMenuItem.Name = "convertTypeToolStripMenuItem";
            this.convertTypeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.convertTypeToolStripMenuItem.Text = "Convert Type";
            this.convertTypeToolStripMenuItem.Click += new System.EventHandler(this.convertTypeToolStripMenuItem_Click);
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Checked = true;
            this.simpleToolStripMenuItem.CheckOnClick = true;
            this.simpleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // textMeshProToolStripMenuItem
            // 
            this.textMeshProToolStripMenuItem.CheckOnClick = true;
            this.textMeshProToolStripMenuItem.Name = "textMeshProToolStripMenuItem";
            this.textMeshProToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.textMeshProToolStripMenuItem.Text = "TextMeshPro";
            this.textMeshProToolStripMenuItem.Click += new System.EventHandler(this.textMeshProToolStripMenuItem_Click);
            // 
            // applyRangeFilterToolStripMenuItem
            // 
            this.applyRangeFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexFilterToolStripMenuItem});
            this.applyRangeFilterToolStripMenuItem.Name = "applyRangeFilterToolStripMenuItem";
            this.applyRangeFilterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.applyRangeFilterToolStripMenuItem.Text = "Apply Range Filter";
            this.applyRangeFilterToolStripMenuItem.Click += new System.EventHandler(this.applyRangeFilterToolStripMenuItem_Click);
            // 
            // hexFilterToolStripMenuItem
            // 
            this.hexFilterToolStripMenuItem.Name = "hexFilterToolStripMenuItem";
            this.hexFilterToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.hexFilterToolStripMenuItem.Text = "Hex Filter";
            this.hexFilterToolStripMenuItem.Click += new System.EventHandler(this.hexFilterToolStripMenuItem_Click);
            // 
            // convertTypeToolStripMenuItem1
            // 
            this.convertTypeToolStripMenuItem1.AutoSize = false;
            this.convertTypeToolStripMenuItem1.Checked = true;
            this.convertTypeToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convertTypeToolStripMenuItem1.DropDown = this.contextMenuStrip1;
            this.convertTypeToolStripMenuItem1.Name = "convertTypeToolStripMenuItem1";
            this.convertTypeToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.convertTypeToolStripMenuItem1.Text = "Options";
            this.convertTypeToolStripMenuItem1.Click += new System.EventHandler(this.convertTypeToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertTypeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "4E00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "9FFF";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(427, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minumum Range";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(550, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Maksimum Range";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StringToUnicodeRange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Location = new System.Drawing.Point(400, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "StringToUnicodeRange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StringToUnicodeRange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textMeshProToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applyRangeFilterToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem hexFilterToolStripMenuItem;
    }
}

