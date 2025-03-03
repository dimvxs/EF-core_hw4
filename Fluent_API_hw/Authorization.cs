using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Fluent_API_hw
{
    public partial class Authorization : Form
    {
        private string FilePath = "log.txt";
        public Authorization()
        {
            InitializeComponent();
        }

        private async void SignIn()
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {

                try
                {
                  await  using (var db = new ManageContext())
                    {

                        var user = new Users
                        {
                            Login = login,
                            Password = password
                        };

                       bool userExists = db.Users.Any(u => u.Login == login);
                       string loggerInfo = $"{login} - {password} signed in";

                        if (userExists)
                        {

                           File.AppendAllText(FilePath, loggerInfo);

                        }
                        else
                        {
                            MessageBox.Show("User is not exists");
                            return;
                        }

                       

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SignIn();
        }
    }
}
