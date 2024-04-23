namespace _135
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.küçükHarfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.büyükHarfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.küçükHarfToolStripMenuItem,
            this.büyükHarfToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 48);
            // 
            // küçükHarfToolStripMenuItem
            // 
            this.küçükHarfToolStripMenuItem.Name = "küçükHarfToolStripMenuItem";
            this.küçükHarfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.küçükHarfToolStripMenuItem.Text = "küçük harf";
            this.küçükHarfToolStripMenuItem.Click += new System.EventHandler(this.küçükHarfToolStripMenuItem_Click);
            // 
            // büyükHarfToolStripMenuItem
            // 
            this.büyükHarfToolStripMenuItem.Name = "büyükHarfToolStripMenuItem";
            this.büyükHarfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.büyükHarfToolStripMenuItem.Text = "büyük harf";
            this.büyükHarfToolStripMenuItem.Click += new System.EventHandler(this.büyükHarfToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 357);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem küçükHarfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem büyükHarfToolStripMenuItem;
    }
}

