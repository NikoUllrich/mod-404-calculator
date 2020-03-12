using System.ComponentModel;

namespace Bankomat_bb
{
    partial class BarAbheben
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbheben = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Betrag Eingeben:";
            // 
            // btnAbheben
            // 
            this.btnAbheben.Location = new System.Drawing.Point(12, 92);
            this.btnAbheben.Name = "btnAbheben";
            this.btnAbheben.Size = new System.Drawing.Size(75, 23);
            this.btnAbheben.TabIndex = 2;
            this.btnAbheben.Text = "Abheben";
            this.btnAbheben.UseVisualStyleBackColor = true;
            // 
            // btnEnde
            // 
            this.btnEnde.Location = new System.Drawing.Point(224, 92);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(75, 23);
            this.btnEnde.TabIndex = 3;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // BarAbheben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 197);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.btnAbheben);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "BarAbheben";
            this.Text = "BarAbheben";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbheben;
        private System.Windows.Forms.Button btnEnde;
    }
}