using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primeiro;
        double segundo;
        string operador;
        bool validar = false;

        public Calculadora()

        {
            InitializeComponent();
        }

        // Classes criadas 
        Classes.ClSoma obj = new Classes.ClSoma();
        Classes.Clsubtracao  obj2 = new Classes.Clsubtracao();
        Classes.ClMultiplicao obj3 = new Classes.ClMultiplicao();
        Classes.ClDivisao obj4 = new Classes.ClDivisao();


        private void Form1_Load(object sender, EventArgs e)
        {

        }
         // Programando cada um dos botões criados //
        private void btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }
    
        private void btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ",";
        }
        // Programação dos botões de cálculo (operadores)// 
        private void btnsoma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
            validar = false;
        }

        private void bntmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
            validar = false;
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            operador = "*";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        { // Programando o botão de = com base nas classes criadas // 
            segundo = double.Parse(tbxScreen.Text);
            
            double Som;
            double Su;
            double Mul;
            double Div; 
            switch(operador)
            {
                case "+":
                    Som = obj.Somar((primeiro), (segundo));
                    tbxScreen.Text = Som.ToString();
                    break;
                case "-":
                    Su = obj2.subtracao((primeiro), (segundo));
                    tbxScreen.Text = Su.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicao((primeiro), (segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Divisao((primeiro), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        
        }
        private void btnexcluir_Click(object sender, EventArgs e)
        { // Programando o botão ← //
            {
                if (tbxScreen.Text.Length == 1)
                    tbxScreen.Text = "";
                else
                    tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
            }
        }
    }
    }

