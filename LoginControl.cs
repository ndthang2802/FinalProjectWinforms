using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class LoginControl : UserControl
    {
        private string _username;
        private string _password;
        Action<string> _setUsername;
        public LoginControl(Action<string> setUsername)
        {
            InitializeComponent();
            _setUsername = setUsername;
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TOPPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void username_input_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(username_input.Text))
            {
                _username = username_input.Text;
            }    
        }

        private void username_input_Enter(object sender, EventArgs e)
        {
            if (username_input.Text == "Nhập username...")
            {
                username_input.Text = "";
            }
        }

        private void username_input_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_input.Text))
                username_input.Text = "Nhập username...";
        }
        private void password_input_Enter(object sender, EventArgs e)
        {
            if (password_input.Text == "Nhập mật khẩu...")
            {
                password_input.Text = "";
            }
        }

        private void password_input_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_input.Text))
                password_input.Text = "Nhập mật khẩu...";
        }

        private void password_input_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(password_input.Text))
            {
                _password = password_input.Text;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (_username == "test" && _password == "test")
            {
                _setUsername(_username);
            }
        }
    }
}
