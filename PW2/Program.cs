using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace PW2
{
     class Program
    {
        [STAThread]
        static void Main()
        {

            string path = "users.txt"; // Define the file
            List<User> users = new List<User>();

            ApplicationConfiguration.Initialize();
            State states = new State();

            if (File.Exists(path))
            {
           
                StreamReader sr = new StreamReader(path); // We use the StreamReader to read the file that we create before.

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] userData = line.Split(';');
                    User tmp = new User(userData[0], userData[1], userData[2], userData[3]);
                    users.Add(tmp);

                }
                sr.Close();

                while (states.GetState() != 0)
                {


                    switch (states.GetState()) //we get the number to see the state of the program
                    {
                        case 1:

                            Application.Run(new Form1(states, users));
                            break;
                        case 2:
                            ReguisterForm r1 = new ReguisterForm(states, users);
                            Application.Run(r1);
                            users = r1.devolverLista();
                    
                            break;
                        case 3:
                            Application.Run(new FormCalculator(states));
                            break;
                        case 4:
                            Application.Run(new ForgotpaswordFORM(states, users));
                            break;
                        default:
                            MessageBox.Show("This state is not correct.");
                            states.ChangeForm(1);
                            break;
                    }


                StreamWriter sw = File.CreateText(path);

                foreach (User user in users)
                {
                    sw.WriteLine(user.Printinfo());
                }
                sw.Close();

                }

            }
            
        }

    }
}