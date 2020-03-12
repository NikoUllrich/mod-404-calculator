namespace mod_404
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
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.btnDividieren = new System.Windows.Forms.Button();
            this.btnMultiplizieren = new System.Windows.Forms.Button();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(17, 108);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(94, 23);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(149, 108);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(94, 23);
            this.btnSubtraktion.TabIndex = 1;
            this.btnSubtraktion.Text = "Subtaktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.Location = new System.Drawing.Point(17, 192);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(94, 23);
            this.btnMittelwert.TabIndex = 2;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // btnDividieren
            // 
            this.btnDividieren.Location = new System.Drawing.Point(149, 150);
            this.btnDividieren.Name = "btnDividieren";
            this.btnDividieren.Size = new System.Drawing.Size(94, 23);
            this.btnDividieren.TabIndex = 3;
            this.btnDividieren.Text = "Dividieren";
            this.btnDividieren.UseVisualStyleBackColor = true;
            this.btnDividieren.Click += new System.EventHandler(this.btnDividieren_Click);
            // 
            // btnMultiplizieren
            // 
            this.btnMultiplizieren.Location = new System.Drawing.Point(17, 150);
            this.btnMultiplizieren.Name = "btnMultiplizieren";
            this.btnMultiplizieren.Size = new System.Drawing.Size(94, 23);
            this.btnMultiplizieren.TabIndex = 4;
            this.btnMultiplizieren.Text = "Multiplizieren";
            this.btnMultiplizieren.UseVisualStyleBackColor = true;
            this.btnMultiplizieren.Click += new System.EventHandler(this.btnMultiplizieren_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.Location = new System.Drawing.Point(118, 15);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(24, 23);
            this.lblOperator.TabIndex = 5;
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErgebnis.Location = new System.Drawing.Point(93, 59);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(75, 23);
            this.lblErgebnis.TabIndex = 6;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(12, 12);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 23);
            this.txtOperand1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ergebnis:";
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(149, 12);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 23);
            this.txtOperand2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 245);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.btnMultiplizieren);
            this.Controls.Add(this.btnDividieren);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnMittelwert;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnMultiplizieren;
        private System.Windows.Forms.Button btnDividieren;
    }
}