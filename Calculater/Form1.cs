using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            Desplay_opr.Text = "Not";
        }

        //==========

        double Number1 = 0;
        double Number2 = 0;
        char Opr = ' ';



        //Number Buttons:
        private void button10_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "0";
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "1";
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "2";
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "3";
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "5";
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "6";
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "7";
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "8";
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            Desplay.Text = Desplay.Text + "9";
        }

        //===============================
        //Opertions:
        private void BtClear_Click(object sender, EventArgs e)
        {
            //Clear Text Box;
            if(Desplay.Text != "")
            {
                Desplay.Text = "";
                Desplay_opr.Text = "Not";
            }

            else
            {
                Desplay_opr.Text = "It's Clear!";
            }
        }

        private void BtPlus_Click(object sender, EventArgs e)
        {

            if (Desplay.Text != "")
            {
                //Plus:
                Number1 = Convert.ToDouble(Desplay.Text);

                Desplay_opr.Text = Desplay.Text + " +";

                Desplay.Text = "";
                Opr = '+';
            }

            else
            {
                Desplay_opr.Text = "Enter A Number!";
            }

        }

        private void BtEquals_Click(object sender, EventArgs e)
        {
            //Equals:
            if (Desplay.Text != "" && Opr != ' ')
            {
                Number2 = Convert.ToDouble(Desplay.Text);
                Desplay_opr.Text += Number2 + " = ";

                double Sum = Process.Calculate(Opr, Number1, Number2);
                Desplay.Text = Sum.ToString();
            }

            else
            {
                Desplay_opr.Text = "Error!";
            }

        }

        private void Btmin_Click(object sender, EventArgs e)
        {
            if (Desplay.Text != "")
            {
                Number1 = Convert.ToDouble(Desplay.Text);

                Desplay_opr.Text = Desplay.Text + " -";

                Desplay.Text = "";
                Opr = '-';
            }

            else
            {
                Desplay_opr.Text = "Enter A Number!";
            }
        }

        private void Btmol_Click(object sender, EventArgs e)
        {
            if (Desplay.Text != "")
            {
                Number1 = Convert.ToDouble(Desplay.Text);

                Desplay_opr.Text = Desplay.Text + " *";

                Desplay.Text = "";
                Opr = '*';
            }


            else
            {
                Desplay_opr.Text = "Enter A Number!";
            }
        }

        private void Btdivid_Click(object sender, EventArgs e)
        {
            if (Desplay.Text != "")
            {
                Number1 = Convert.ToDouble(Desplay.Text);

                Desplay_opr.Text = Desplay.Text + " /";

                Desplay.Text = "";
                Opr = '/';
            }


            else
            {
                Desplay_opr.Text = "Enter A Number!";
            }
        }
    }
}
