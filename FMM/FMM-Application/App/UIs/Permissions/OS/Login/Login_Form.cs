using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMM_Application.App.UIs.Permissions.OS.Login
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        public void Login_data()
        {
            errorProvider1.Clear();
            errorProvider1.Clear();
            if (this.text_user.Text.Trim() != "" && this.text_pass.Text.Trim() != "")
            {
                // Database Connection Codes and sql queries





            }

            else
            {
                if (this.text_pass.Text.Trim() == "")
                    errorProvider1.SetError(text_pass, "Password Can not be Empty");

                if (this.text_user.Text.Trim() == "")
                    errorProvider1.SetError(text_user, "Username Can not be Empty");
            }
        }

        private void text_user_TextChanged(object sender, EventArgs e)
        {
            if (this.text_user.Text.Trim() != "" && this.text_pass.Text.Trim() != "")
                Btn_OK.Enabled = true;

            else
                Btn_OK.Enabled = false;
        }

        private void text_pass_TextChanged(object sender, EventArgs e)
        {
            if (this.text_user.Text.Trim() != "" && this.text_pass.Text.Trim() != "")
                Btn_OK.Enabled = true;

            else
                Btn_OK.Enabled = false;
        }

        private void text_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                this.text_pass.Focus();

            if (e.KeyData == Keys.Enter)
                this.text_pass.Focus();
        }

        private void text_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
                this.text_user.Focus();

            if (e.KeyData == Keys.Enter)
                Login_data();
        }
    }
}
