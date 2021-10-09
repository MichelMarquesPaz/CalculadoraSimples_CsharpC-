using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_01
{
    public partial class tbcalcular : Form
    {
        public tbcalcular()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ;
        }

        int operacao = 1; // Declarei váriavel para inicializar com "1"
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1; // Quando o usuário clicar na radioButton, vai criar esse evento para "soma"
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2; // Quando o usuário clicar na radioButton, vai criar esse evento para "Subtração"
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            operacao = 3; // Quando o usuário clicar na radioButton, vai criar esse evento para "Divisão"
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4; // Quando o usuário clicar na radioButton, vai criar esse evento para "multiplicação"
        }

        private void tbresolver_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2; // Usei tipo Double por ser ponto flutuante// Usa o dobro de espaço.
            double resultado;

            numero1 = Double.Parse(textBox1.Text);  // Conversão do tipo double para string.
            numero2 = Double.Parse(textBox2.Text);

            if(operacao == 1)
            {
                resultado = numero1 + numero2;   //Operação de Soma.
                textBox3.Text = resultado.ToString();
            }
            if (operacao == 2)
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString(); //Subtração.
            }
            if (operacao == 3 && numero2 != 0)
                
            {
                resultado = numero1 / numero2;
                textBox3.Text = resultado.ToString(); //Divisão.
            }
            if (operacao == 4)
            {
                resultado = numero1 * numero2; 
                textBox3.Text = resultado.ToString(); //Multiplicação.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("calc.exe.");
            meuProcesso.WaitForExit(); // Chamando aplicação externa do Windows.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear(); //Limpar todas as textBox.
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Sair da Aplicação
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
