using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMM_Application.App.UIs.Permissions.OS.Login
{
    public partial class Login_Form : Form
    {
        private SqlConnection con;
        public Login_Form()
        {
            InitializeComponent();
        }

        public void Login_data()
        {
            errorProvider1.Clear();
            if (this.text_user.Text.Trim() != "" && this.text_pass.Text.Trim() != "")
            {
                con = FMM_Application.App.DataAccess.Connection.Connection.connect();
                DataTable dt = log_in(this.text_user.Text, this.text_pass.Text);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome", "Valid Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } 
                
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    close();
                }
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
                Login_data();
        }

        private void text_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
                this.text_user.Focus();

            if (e.KeyData == Keys.Enter)
                Login_data();
        }

        private void Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        private void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private DataTable Read(String sp, SqlParameter[] para)
        {
            SqlCommand sqlCom = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.StoredProcedure,
                CommandText = sp
            };

            if (para != null)
            {
                sqlCom.Parameters.AddRange(para);
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

  

        private DataTable log_in(string username, string password)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50)
            {
                Value = username
            };

            para[1] = new SqlParameter("@pass", SqlDbType.NVarChar, 50)
            {
                Value = password
            };
            DataTable dt = Read("login_sp", para);
            Open();

            return dt;
        }
    }
}
