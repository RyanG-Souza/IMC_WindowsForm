using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txb_Altura.Text) != 0)
                {
                    double a = double.Parse(txb_Altura.Text.Replace('.', ','));
                    double b = double.Parse(txb_Peso.Text.Replace('.', ','));
                    double imc = b / (a * a);
                    txb_Resultado.Text = Math.Round(imc, 2).ToString();

                    if (imc < 18.5)
                    {
                        lbl_Saude.Text = "Você está abaixo do peso!";
                        lbl_Saude.ForeColor = Color.GreenYellow;
                    }
                    else if (imc < 24.9)
                    {
                        lbl_Saude.Text = "Peso ideal!";
                        lbl_Saude.ForeColor = Color.Green;
                    }
                    else if (imc < 29.9)
                    {
                        lbl_Saude.Text = "Levemente acima do Peso!";
                        lbl_Saude.ForeColor = Color.Yellow;
                    }
                    else if (imc < 34.9)
                    {
                        lbl_Saude.Text = "Obesidade grau I";
                        lbl_Saude.ForeColor = Color.Orange;
                    }
                    else if (imc < 39.9)
                    {
                        lbl_Saude.Text = "Obesidade grau II";
                        lbl_Saude.ForeColor = Color.OrangeRed;
                    }
                    else if (imc > 40)
                    {
                        lbl_Saude.Text = "Obesidade grau III";
                        lbl_Saude.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbl_Saude.Text = (" O peso não podem ser 0"); 
                    lbl_Saude.ForeColor = Color.DarkRed;
                }
                

            }
            catch (Exception ex)
            {
                lbl_Saude.Text = ("Algo deu errado!!");
            }
        }
    }
}
