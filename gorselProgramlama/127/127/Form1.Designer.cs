namespace _127
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
            this.Txt_babaadi = new System.Windows.Forms.TextBox();
            this.Txt_bolumu = new System.Windows.Forms.TextBox();
            this.Txt_adisoyadi = new System.Windows.Forms.TextBox();
            this.listBox_babaadi = new System.Windows.Forms.ListBox();
            this.listBox_bolumu = new System.Windows.Forms.ListBox();
            this.listBox_adisoyadi = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_babaadi
            // 
            this.Txt_babaadi.Location = new System.Drawing.Point(594, 168);
            this.Txt_babaadi.Name = "Txt_babaadi";
            this.Txt_babaadi.Size = new System.Drawing.Size(100, 20);
            this.Txt_babaadi.TabIndex = 13;
            // 
            // Txt_bolumu
            // 
            this.Txt_bolumu.Location = new System.Drawing.Point(413, 168);
            this.Txt_bolumu.Name = "Txt_bolumu";
            this.Txt_bolumu.Size = new System.Drawing.Size(100, 20);
            this.Txt_bolumu.TabIndex = 12;
            // 
            // Txt_adisoyadi
            // 
            this.Txt_adisoyadi.Location = new System.Drawing.Point(239, 168);
            this.Txt_adisoyadi.Name = "Txt_adisoyadi";
            this.Txt_adisoyadi.Size = new System.Drawing.Size(100, 20);
            this.Txt_adisoyadi.TabIndex = 11;
            // 
            // listBox_babaadi
            // 
            this.listBox_babaadi.FormattingEnabled = true;
            this.listBox_babaadi.Location = new System.Drawing.Point(594, 67);
            this.listBox_babaadi.Name = "listBox_babaadi";
            this.listBox_babaadi.Size = new System.Drawing.Size(120, 95);
            this.listBox_babaadi.TabIndex = 10;
            this.listBox_babaadi.SelectedIndexChanged += new System.EventHandler(this.eleman_tıklanırsa);
            // 
            // listBox_bolumu
            // 
            this.listBox_bolumu.FormattingEnabled = true;
            this.listBox_bolumu.Location = new System.Drawing.Point(413, 67);
            this.listBox_bolumu.Name = "listBox_bolumu";
            this.listBox_bolumu.Size = new System.Drawing.Size(120, 95);
            this.listBox_bolumu.TabIndex = 9;
            this.listBox_bolumu.SelectedIndexChanged += new System.EventHandler(this.eleman_tıklanırsa);
            // 
            // listBox_adisoyadi
            // 
            this.listBox_adisoyadi.FormattingEnabled = true;
            this.listBox_adisoyadi.Location = new System.Drawing.Point(230, 67);
            this.listBox_adisoyadi.Name = "listBox_adisoyadi";
            this.listBox_adisoyadi.Size = new System.Drawing.Size(120, 95);
            this.listBox_adisoyadi.TabIndex = 8;
            this.listBox_adisoyadi.SelectedIndexChanged += new System.EventHandler(this.eleman_tıklanırsa);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_babaadi);
            this.Controls.Add(this.Txt_bolumu);
            this.Controls.Add(this.Txt_adisoyadi);
            this.Controls.Add(this.listBox_babaadi);
            this.Controls.Add(this.listBox_bolumu);
            this.Controls.Add(this.listBox_adisoyadi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_babaadi;
        private System.Windows.Forms.TextBox Txt_bolumu;
        private System.Windows.Forms.TextBox Txt_adisoyadi;
        private System.Windows.Forms.ListBox listBox_babaadi;
        private System.Windows.Forms.ListBox listBox_bolumu;
        private System.Windows.Forms.ListBox listBox_adisoyadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

