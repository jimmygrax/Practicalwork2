namespace PW2
{
    public partial class Form1 : Form
    {
        private string name;
        private string userName; //we use composition for each form because all of them needs a state object
        private string password;
        private string email;
        private State state;
        private List<User> users;
        public Form1(State state, List<User> users)
        {
            this.state = state;
            this.users = users;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User tmp in users)
            {
                if (tmp.GetName() == textBox1.Text && tmp.GetPassword() == textBox2.Text)
                {
                    //  Here I compare that what is put in the registerfrom is the same as what the user puts in the textbox.
                    MessageBox.Show("The registation it was a completly.");
                    this.state.ChangeForm(3);
                    this.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.state.ChangeForm(2);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
            textBox2.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.state.ChangeForm(4);
            this.Close();
        }
    }
}