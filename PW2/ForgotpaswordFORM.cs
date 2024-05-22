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
    public partial class ForgotpaswordFORM : Form
    {
        private string userName; //we use composition for each form because all of them needs a state object
        private string psswd;
        private string email;
        private State state;
        private List<User> users;
        public ForgotpaswordFORM(State state, List<User> users)
        {
            this.state = state;
            this.users = users;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.state.ChangeForm(1);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string path = "users.txt"; // Define the file
                StreamReader sr = new StreamReader(path); // We use the StreamReader to read the file that we create before.
                foreach (User u in users)
                {   
                    if (u.GetName() == textBox3.Text)
                    {
                        if (textBox1.Text == textBox2.Text)
                        {
                            string line;
                            line = sr.ReadLine();

                            string[] userData = line.Split(';');
                            userData[2] = textBox1.Text;
                            User tmp = new User(userData[0], userData[1], userData[2], userData[3]);
                            users.Add(tmp);
                            sr.Close();
                            this.state.ChangeForm(1);
                            this.Close();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
