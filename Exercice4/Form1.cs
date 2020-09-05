using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNb2.Enabled = false;
            btnValid2.Enabled = false;
            btnGetSuite.Enabled = false;
        }

        private void btnValid1_Click(object sender, EventArgs e)
        {
            string entier1 = txtNb1.Text;
            if (ValideUnEntier("premier", ref entier1) == true)
            {
                txtNb2.Enabled = true;
                btnValid2.Enabled = true;
            }
        }

        private static void GetSerie(ref string entier1, ref string entier2)
        {
            int nb1 = int.Parse(entier1);
            int nb2 = int.Parse(entier2);
            string serie = "";

            while (nb1 <= nb2)
            {
                serie += $"{nb1} ";
                nb1 += 2;
            }
            MessageBox.Show(serie);
        }

        private static Boolean ValidationIntervalle(string entier1, string entier2)
        {
            if (int.Parse(entier1) < int.Parse(entier2))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Le second paramètre est plus petit que le premier.");
                return false;
            }
        }

        private static Boolean ValideUnEntier(string identidiant, ref string entier)
        {
            if (String.IsNullOrWhiteSpace(entier))
            {
                MessageBox.Show($"Le {identidiant} entier n'est pas un entier.");
                return false;
            }
            else if (int.Parse(entier) % 2 != 0)
            {
                MessageBox.Show($"Le {identidiant} n'est pas un entier pair.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnValid2_Click(object sender, EventArgs e)
        {
            string entier2 = txtNb2.Text;
            if (ValideUnEntier("premier", ref entier2) == true)
            {
                btnGetSuite.Enabled = true;
            }
        }

        private void btnGetSuite_Click(object sender, EventArgs e)
        {
            string entier1 = txtNb1.Text;
            string entier2 = txtNb2.Text;

            if(ValidationIntervalle(entier1, entier2))
            {
                GetSerie(ref entier1, ref entier2);
                txtNb1.Text = "";
                txtNb2.Text = "";
                txtNb2.Enabled = false;
                btnValid2.Enabled = false;
                btnGetSuite.Enabled = false;
            }
        }
    }
}
