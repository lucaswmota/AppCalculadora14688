using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora14688
{
    

    public partial class MainPage : ContentPage
    {

        double total, tempNumero, numero;

        int operacao;



        public MainPage()
        {
            InitializeComponent();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "7";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "8";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "9";
        }

        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            if (lblNumero.Text != "")
            {
                numero += double.Parse(lblNumero.Text);
                operacao = 4;

                lblNumero.Text = "";
            }
            else
            {
               lblMensagemDeErro.Text = "Digite algum numero";
            }

        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            lblNumero.Text="";
            total = 0;
            tempNumero = 0; 
            numero = 0;
            operacao = 0; 
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "4";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "5";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            lblNumero.Text += "6";
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            if (lblNumero.Text != "")
            {
                numero += double.Parse(lblNumero.Text);
                operacao = 3;

                lblNumero.Text = "";
            }
            else
            {
                lblMensagemDeErro.Text = "Digite algum numero";
            }
        }

        private void btnSomar_Clicked(object sender, EventArgs e)
        {
            if (lblNumero.Text != "")
            {
                numero += double.Parse(lblNumero.Text);
                operacao = 1;

                lblNumero.Text = "";
            }
            else
            {
                lblMensagemDeErro.Text = "Digite algum numero";
            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "1";
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "2";
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "3";
        }

        private void btnSubtrair_Clicked(object sender, EventArgs e)
        {
            if (lblNumero.Text != "")
            {
                numero += double.Parse(lblNumero.Text);
                operacao = 2;

                lblNumero.Text = "";
            }
            else
            {
                lblMensagemDeErro.Text = "Digite algum numero";
            }
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {

            lblNumero.Text += "0";
        }

        private void btnVirgula_Clicked(object sender, EventArgs e)
        {
            try
            {
                numero += double.Parse(lblNumero.Text += ".");
            }
            catch(Exception)
            {
                lblMensagemDeErro.Text = "Digite algum numero";
                lblNumero.Text = "";
            }
        }

        private void btnIgual_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (operacao == 1) 
                {
                    tempNumero += double.Parse(lblNumero.Text);

                    total = numero + tempNumero;

                    lblNumero.Text=total.ToString();


                }
                else if(operacao == 2)
                {
                    tempNumero += double.Parse(lblNumero.Text);

                    total = numero - tempNumero;
                    lblNumero.Text = total.ToString();
                }
                else if(operacao==3)
                {
                    tempNumero += double.Parse(lblNumero.Text);

                    total = numero * tempNumero;
                    lblNumero.Text = total.ToString();
                }
                else if(operacao ==4)
                {
                    tempNumero += double.Parse(lblNumero.Text);

                    total = numero / tempNumero;
                    lblNumero.Text = total.ToString();
                }
                else
                {
                    lblMensagemDeErro.Text = "Tente Novamente";
                    lblNumero.Text = "";
                    total = 0;
                    tempNumero = 0;
                    numero = 0;
                    operacao = 0;
                }
                total= 0;
                tempNumero = 0;
                numero = 0;
            }
            catch(FormatException)
            {
                lblMensagemDeErro.Text = "Insira um numero para fazer operações";
            }
        }
    }
}
