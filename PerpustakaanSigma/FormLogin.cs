using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanSigma
{
    public partial class FormLogin : Form
    {
        public OdbcConnection Connection { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            Connection = Database.Connect();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextBox(InputUsername, InputPassword)) return;

            var cmd = new OdbcCommand("SELECT id FROM users WHERE username=? AND password=?", Connection);
            cmd.Parameters.AddWithValue("", InputUsername.Text);
            cmd.Parameters.AddWithValue("", InputPassword.Text);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();
            MessageBox.Show(reader.HasRows ? "Login berhasil!" : "Username atau Password salah!");
            reader.Close();
        }
    }
}
