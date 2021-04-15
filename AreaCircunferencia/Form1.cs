using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AreaCircunferencia
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnClique_Click(object sender, EventArgs e)
    {
        //Treinamento - Calcule a area da circunferencia, tipo double
        //Jonas Valereo - Técnico em Informática

        //Declarando as variaveis, tipo double

        double raio, pi, area;


        //Declarando entrada de dado no textbox

        raio = double.Parse(textBoxRaio.Text, CultureInfo.InvariantCulture);
        pi = double.Parse(textBoxPi.Text, CultureInfo.InvariantCulture);

        //Declarando a variavel area da circunferencia 

        area = Math.Pow(raio, 2.0) * pi;


        //imprimir saida de dados no MessagemBox, concatenação

        MessageBox.Show("O valor da area = " + area.ToString("F2", CultureInfo.InvariantCulture)
            , "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

        MessageBox.Show("Teste de novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando codigo limpar textbox, focus

            textBoxRaio.Text = " ";
            textBoxPi.Text = " ";
            textBoxRaio.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair do programa

            Close();
        }

        //Fim do programa

   }

}
