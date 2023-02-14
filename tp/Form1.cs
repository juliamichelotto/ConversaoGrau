using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (this.cboTipoConversao.SelectedIndex == 0)
            {
                float celsius = 0;
                if (float.TryParse(txtValorRecebido.Text, out celsius))
                {
                    float fahrenheit = (float)((celsius * 1.8) + 32);
                    txtResultado.Text = $"{fahrenheit:N2}";
                }
                else
                {
                    MessageBox.Show("Valor Inválido");
                    txtResultado.Text = "";
                }
            }
            else if (this.cboTipoConversao.SelectedIndex == 1)
            {
                {
                    float fahrenheit = 0;
                    if (float.TryParse(txtValorRecebido.Text, out fahrenheit))
                    {
                        float celsius = (float)((fahrenheit - 32) / 1.8);
                        txtResultado.Text = $"{celsius:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Valor Inválido");
                        txtResultado.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de convrsão!");
            }

        }
    }
}

