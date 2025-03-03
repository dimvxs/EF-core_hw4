using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Fluent_API_hw
{
    public partial class Registration : Form
    {
        private string FilePath = "log.txt";
        public Registration()
        {
            InitializeComponent();
        }


        private async void SignUp()
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {

                try
                {
                    await using (var db = new ManageContext())
                    {

                        var user = new Users
                        {
                            Login = login,
                            Password = password
                        };

                        bool userExists = db.Users.Any(u => u.Login == login);
                        string loggerInfo = $"{login} - {password} added";

                        if (!userExists)
                        {
                            await db.AddAsync(user);
                            await db.SaveChangesAsync();
                            File.AppendAllText(FilePath, loggerInfo);

                        }
                        else
                        {
                            MessageBox.Show("User exists");
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
            if (textBox2.Text.Equals(textBox3.Text))
            {
                SignUp();
            }
            else
            {
                MessageBox.Show("Passwords are not equals");
                return;
            }
        }
    }
}
