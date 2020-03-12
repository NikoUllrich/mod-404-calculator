namespace mod_404_schachbrett
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudAnzahlZeilen = new System.Windows.Forms.DomainUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlSchachbrett = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.nudAnzahlZeilen);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 58);
            this.panel1.TabIndex = 0;
            // 
            // nudAnzahlZeilen
            // 
            this.nudAnzahlZeilen.Location = new System.Drawing.Point(24, 15);
            this.nudAnzahlZeilen.Name = "nudAnzahlZeilen";
            this.nudAnzahlZeilen.Size = new System.Drawing.Size(52, 23);
            this.nudAnzahlZeilen.TabIndex = 2;
            this.nudAnzahlZeilen.Text = "domainUpDown1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(104, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // pnlSchachbrett
            // 
            this.pnlSchachbrett.BackColor = System.Drawing.Color.White;
            this.pnlSchachbrett.Location = new System.Drawing.Point(12, 97);
            this.pnlSchachbrett.Name = "pnlSchachbrett";
            this.pnlSchachbrett.Size = new System.Drawing.Size(356, 280);
            this.pnlSchachbrett.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 389);
            this.Controls.Add(this.pnlSchachbrett);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Schachbrett";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSchachbrett;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DomainUpDown nudAnzahlZeilen;
    }
}