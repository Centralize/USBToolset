namespace USB_Toolset
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAT32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nTFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USB Drive";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem,
            this.mBRToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAT32ToolStripMenuItem,
            this.nTFSToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fAT32ToolStripMenuItem
            // 
            this.fAT32ToolStripMenuItem.Name = "fAT32ToolStripMenuItem";
            this.fAT32ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.fAT32ToolStripMenuItem.Text = "FAT32";
            // 
            // nTFSToolStripMenuItem
            // 
            this.nTFSToolStripMenuItem.Name = "nTFSToolStripMenuItem";
            this.nTFSToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.nTFSToolStripMenuItem.Text = "NTFS";
            // 
            // mBRToolStripMenuItem
            // 
            this.mBRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gPTToolStripMenuItem,
            this.mBRToolStripMenuItem1});
            this.mBRToolStripMenuItem.Name = "mBRToolStripMenuItem";
            this.mBRToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mBRToolStripMenuItem.Text = "Boot Record";
            // 
            // gPTToolStripMenuItem
            // 
            this.gPTToolStripMenuItem.Name = "gPTToolStripMenuItem";
            this.gPTToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.gPTToolStripMenuItem.Text = "GPT";
            // 
            // mBRToolStripMenuItem1
            // 
            this.mBRToolStripMenuItem1.Name = "mBRToolStripMenuItem1";
            this.mBRToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.mBRToolStripMenuItem1.Text = "MBR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove RD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Create RD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "USB Toolset Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAT32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nTFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBRToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

