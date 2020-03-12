namespace Bankomat_bb
{
    partial class Menu
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
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.lblAnleitung = new System.Windows.Forms.Label();
            this.btnAbheben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(1, 219);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(120, 28);
            this.btnSaldo.TabIndex = 0;
            this.btnSaldo.Text = "Saldo anzeigen";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.ButtonSaldo_Click);
            // 
            // btnEnde
            // 
            this.btnEnde.Location = new System.Drawing.Point(295, 219);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(91, 28);
            this.btnEnde.TabIndex = 0;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.ButtonEnde_Click);
            // 
            // lblAnleitung
            // 
            this.lblAnleitung.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnleitung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnleitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAnleitung.ForeColor = System.Drawing.Color.White;
            this.lblAnleitung.Location = new System.Drawing.Point(1, 61);
            this.lblAnleitung.Name = "lblAnleitung";
            this.lblAnleitung.Size = new System.Drawing.Size(386, 78);
            this.lblAnleitung.TabIndex = 14;
            this.lblAnleitung.Text = "Hauptmenu:\r\nBitte wählen Sie eine Aktion";
            // 
            // btnAbheben
            // 
            this.btnAbheben.Location = new System.Drawing.Point(152, 219);
            this.btnAbheben.Name = "btnAbheben";
            this.btnAbheben.Size = new System.Drawing.Size(108, 28);
            this.btnAbheben.TabIndex = 15;
            this.btnAbheben.Text = "Bargeld Abheben";
            this.btnAbheben.UseVisualStyleBackColor = true;
            this.btnAbheben.Click += new System.EventHandler(this.btnAbheben_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 313);
            this.Controls.Add(this.btnAbheben);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.lblAnleitung);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.Label lblAnleitung;
        private System.Windows.Forms.Button btnAbheben;
    }
}