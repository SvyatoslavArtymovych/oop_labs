namespace lab11_13
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Lab11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab_11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lab12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultLab12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lab11ToolStripMenuItem,
            this.Lab12ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Lab11ToolStripMenuItem
            // 
            this.Lab11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab_11ToolStripMenuItem});
            this.Lab11ToolStripMenuItem.Name = "Lab11ToolStripMenuItem";
            this.Lab11ToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.Lab11ToolStripMenuItem.Text = "Лабораторна робота №11";
            // 
            // lab_11ToolStripMenuItem
            // 
            this.lab_11ToolStripMenuItem.Name = "lab_11ToolStripMenuItem";
            this.lab_11ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lab_11ToolStripMenuItem.Text = "Результати";
            this.lab_11ToolStripMenuItem.Click += new System.EventHandler(this.lab_11ToolStripMenuItem_Click);
            // 
            // Lab12ToolStripMenuItem
            // 
            this.Lab12ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultLab12ToolStripMenuItem});
            this.Lab12ToolStripMenuItem.Name = "Lab12ToolStripMenuItem";
            this.Lab12ToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.Lab12ToolStripMenuItem.Text = "Лабораторна робота №12";
            // 
            // resultLab12ToolStripMenuItem
            // 
            this.resultLab12ToolStripMenuItem.Name = "resultLab12ToolStripMenuItem";
            this.resultLab12ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resultLab12ToolStripMenuItem.Text = "Результати";
            this.resultLab12ToolStripMenuItem.Click += new System.EventHandler(this.resultLab12ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Головна форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Lab11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab_11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Lab12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultLab12ToolStripMenuItem;
    }
}

