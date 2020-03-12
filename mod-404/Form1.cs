using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod_404
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 + zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "+";
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 - zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "-";
        }

        private void btnMultiplizieren_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 * zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "*";
        }

        private void btnDividieren_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 / zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = ":";
        }

        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 + zahl2;
            double ergebnis2 = ergebnis / 2;
            lblErgebnis.Text = Convert.ToString(ergebnis2);

            lblOperator.Text = "";
        }
    }
}