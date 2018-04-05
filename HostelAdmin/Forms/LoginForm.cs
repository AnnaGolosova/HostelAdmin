using HostelAdmin.Forms;
using HostelAdmin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelAdmin
{
    public partial class LoginForm : Form
    {
        private string password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (DBRepository.Login(LoginTB.Text, PasswordTB.Text))
            {
                case LoginState.Success:
                    this.Hide();
                    new MainForm().Show();
                    break;
                case LoginState.WrongEmail:
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Неверный логин";
                    break;
                case LoginState.WrongPassword:

                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Неверный пароль";
                    break;
                case LoginState.ConnectionError:
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Что-то пошло не так! Проверьте подключение к серверу";
                    break;
            }
        }
    }
}
