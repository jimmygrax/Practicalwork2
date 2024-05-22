using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW2
{
    public partial class FormCalculator : Form
    {
        private State state;
        private List<User> users;

        // variables

        string operados = "";
        double num1 = 0;
        double num2 = 0;


        public FormCalculator(State state)
        {
            this.state = state;
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            this.state.ChangeForm(1);
            this.Close();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = "0";
            num1 = 0;
            num2 = 0;
            operados = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text = textbox_resultados.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            textbox_resultados.Text += " + ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text += " - ";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textbox_resultados.Text += " * ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text += " / ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Operation op1 = new Operation(textbox_resultados.Text);

            op1.Parametros();

            textbox_resultados.Text = op1.Devolver();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textbox_resultados.Text += " ^ ";

        }

        private void button18_Click(object sender, EventArgs e)
        {
           textbox_resultados.Text += " % ";
        }
    }
}
