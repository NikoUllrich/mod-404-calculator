namespace Bankomat_bb
{
    partial class UnterMenuSaldo
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
            this.lblUntermenu = new System.Windows.Forms.Label();
            this.btnWeiter = new System.Windows.Forms.Button();
            this.lblAnleitung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUntermenu
            // 
            this.lblUntermenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUntermenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUntermenu.ForeColor = System.Drawing.Color.White;
            this.lblUntermenu.Location = new System.Drawing.Point(3, 203);
            this.lblUntermenu.Name = "lblUntermenu";
            this.lblUntermenu.Size = new System.Drawing.Size(387, 55);
            this.lblUntermenu.TabIndex = 13;
            this.lblUntermenu.Text = "label2";
            // 
            // btnWeiter
            // 
            this.btnWeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnWeiter.Location = new System.Drawing.Point(119, 121);
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.Size = new System.Drawing.Size(125, 50);
            this.btnWeiter.TabIndex = 12;
            this.btnWeiter.Text = "Weiter";
            this.btnWeiter.UseVisualStyleBackColor = true;
            this.btnWeiter.Click += new System.EventHandler(this.ButtonWeiter_Click);
            // 
            // lblAnleitung
            // 
            this.lblAnleitung.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnleitung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnleitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAnleitung.ForeColor = System.Drawing.Color.White;
            this.lblAnleitung.Location = new System.Drawing.Point(5, 10);
            this.lblAnleitung.Name = "lblAnleitung";
            this.lblAnleitung.Size = new System.Drawing.Size(386, 60);
            this.lblAnleitung.TabIndex = 15;
            this.lblAnleitung.Text = "Bitte drücken Sie Weiter";
            this.lblAnleitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnterMenuSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 313);
            this.Controls.Add(this.lblUntermenu);
            this.Controls.Add(this.btnWeiter);
            this.Controls.Add(this.lblAnleitung);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "UnterMenuSaldo";
            this.Text = "UnterMenuSaldo";
            this.Load += new System.EventHandler(this.UnterMenuSaldo_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblUntermenu;
        private System.Windows.Forms.Button btnWeiter;
        private System.Windows.Forms.Label lblAnleitung;
    }
}