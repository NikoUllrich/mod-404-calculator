namespace Bankomat_bb
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKarteEin = new System.Windows.Forms.Button();
            this.lblAnleitung = new System.Windows.Forms.Label();
            this.chkKarteValid = new System.Windows.Forms.CheckBox();
            this.txtPWStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKarteEin
            // 
            this.btnKarteEin.Location = new System.Drawing.Point(274, 173);
            this.btnKarteEin.Name = "btnKarteEin";
            this.btnKarteEin.Size = new System.Drawing.Size(101, 39);
            this.btnKarteEin.TabIndex = 0;
            this.btnKarteEin.Text = "Karte eingeben";
            this.btnKarteEin.UseVisualStyleBackColor = true;
            this.btnKarteEin.Click += new System.EventHandler(this.KarteEin_Click);
            // 
            // lblAnleitung
            // 
            this.lblAnleitung.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnleitung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnleitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAnleitung.ForeColor = System.Drawing.Color.White;
            this.lblAnleitung.Location = new System.Drawing.Point(1, -3);
            this.lblAnleitung.Name = "lblAnleitung";
            this.lblAnleitung.Size = new System.Drawing.Size(386, 151);
            this.lblAnleitung.TabIndex = 1;
            this.lblAnleitung.Text = "Bitte geben Sie Ihre Karte ein";
            this.lblAnleitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkKarteValid
            // 
            this.chkKarteValid.AutoSize = true;
            this.chkKarteValid.Location = new System.Drawing.Point(7, 38);
            this.chkKarteValid.Name = "chkKarteValid";
            this.chkKarteValid.Size = new System.Drawing.Size(86, 19);
            this.chkKarteValid.TabIndex = 5;
            this.chkKarteValid.Text = "Karte valid?";
            this.chkKarteValid.UseVisualStyleBackColor = true;
            this.chkKarteValid.CheckedChanged += new System.EventHandler(this.EingebenKartendaten);
            // 
            // txtPWStart
            // 
            this.txtPWStart.Location = new System.Drawing.Point(119, 42);
            this.txtPWStart.Name = "txtPWStart";
            this.txtPWStart.Size = new System.Drawing.Size(84, 23);
            this.txtPWStart.TabIndex = 6;
            this.txtPWStart.TextChanged += new System.EventHandler(this.EingebenKartendaten);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "PIN der Karte:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkKarteValid);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.txtPWStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-6, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hier können Sie die Werte der Karte/des Kontos eingeben:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(226, 42);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(121, 23);
            this.txtSaldo.TabIndex = 6;
            this.txtSaldo.TextChanged += new System.EventHandler(this.EingebenKartendaten);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo des Kontos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 359);
            this.Controls.Add(this.btnKarteEin);
            this.Controls.Add(this.lblAnleitung);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Form1";
            this.Text = "Bankomat";
            this.Load += new System.EventHandler(this.EingebenKartendaten);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnKarteEin;
        private System.Windows.Forms.Label lblAnleitung;
        private System.Windows.Forms.CheckBox chkKarteValid;
        private System.Windows.Forms.TextBox txtPWStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
    }
}

