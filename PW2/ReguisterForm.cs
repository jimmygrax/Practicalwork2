using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PW2
{
    public partial class ReguisterForm : Form
    {
        private string name;
        private string email;
        private string password;
        private string username;
        private string passwordconf;
        private string filepath;
        private State state;
        private List<User> users; // i create the list users 
        public ReguisterForm(State state, List<User> users)
        {
            this.state = state;
            this.users = users;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.state.ChangeForm(1);
            this.Close(); //return to main
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox4.Text) //if passwords are not the same
            {
                MessageBox.Show("Passwords are not the same. Please try again.");
                return;
            }
            if (textBox1.Text == textBox3.Text) //if passwords are not the same
            {
                MessageBox.Show("The name and the username must be diferent");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text)) //if fields are empty
            {
                MessageBox.Show("Fields are not completely filled.");
                return;
            }
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            if(!checkBox1.Checked) 
            {
                MessageBox.Show("You mus agree to the terms and conditions of our security and protection policies.");
                return;
            }

            User newUser = new User(name, username, password, email);
            users.Add(newUser);

            MessageBox.Show("Usuario registrado exitosamente.");
            this.state.ChangeForm(1);
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.state.ChangeForm(1);
            this.Close(); //return to main
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            username = textBox3.Text; // Here I assign the variable to what the user writes in the emailbox.
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            password = textBox5.Text;
            textBox5.PasswordChar = '*'; // cahnge how it looks de text you write in to the box
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            passwordconf = textBox4.Text;
            textBox4.PasswordChar = '*';
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
        public List<User> devolverLista()
        {
            return this.users;
        }
        private bool IsPasswordValid(string password)
        {
            return password.Length >= 8;
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            this.email = textBox_email.Text;
        }
    }
}
