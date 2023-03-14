using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIDeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbnFeminino_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (rbnFeminino.Checked )
                {
                    double altura;
                    bool alturacheck = double.TryParse(txtAltura.Text, out altura);
                    double conta = (62.1 * altura) - 44.7;
                    resultado.Text = Convert.ToString(conta);
                }
                 if(txtAltura.Text == "")
                {
                    resultado.Text = Convert.ToString(" ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbnMasculino.Checked && txtAltura.Text != "" )
                {
                    double altura;
                    bool alturacheck = double.TryParse(txtAltura.Text, out altura);
                    double conta = (72.7 * altura) - 58;
                    resultado.Text = Convert.ToString(conta);
                }
                if(txtAltura.Text == "")
                {
                    resultado.Text = Convert.ToString(" ");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }
    }
}
