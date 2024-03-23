using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_DoHuynhNguyenVu
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService service = new();
            UserAccount acc = service.CheckLogin(txtEmail.Text,
                txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Con cac sai email, password roi", "Wrong credentails",
                    MessageBoxButtons.OK);
            }
            if (acc.Role == 1)
            {
                BookManager f = new();
                f.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
            }
            return;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
