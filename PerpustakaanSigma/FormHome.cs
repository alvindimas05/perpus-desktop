using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanSigma
{
    public partial class FormHome : Form
    {
        public OdbcConnection Connection { get; set; }
        public FormHome()
        {
            InitializeComponent();
            Connection = Database.Connect();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            ResetAnggota();
        }

        int selectedAnggotaIndex = -1;
        private void BtnDeleteAnggota_Click(object sender, EventArgs e)
        {
            var selectedAnggotaId = perpustakaanDataSet.anggotas[selectedAnggotaIndex].Id;
            var cmd = new OdbcCommand("DELETE FROM anggotas WHERE id=?", Connection);
            cmd.Parameters.AddWithValue("", selectedAnggotaId);
            cmd.ExecuteNonQuery();

            anggotasTableAdapter.Fill(perpustakaanDataSet.anggotas);
        }

        private void DataGridViewAnggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAnggotaIndex = DataGridViewAnggota.CurrentCell.RowIndex;
            SetEditAnggota();
        }

        public void SetEditAnggota()
        {
            var anggota = perpustakaanDataSet.anggotas[selectedAnggotaIndex];
            TextBoxAnggotaNama.Text = anggota.Nama;
            TextBoxAnggotaAlamat.Text = anggota.Alamat;
            TextBoxAnggotaNoTelp.Text = anggota.NoTelp;

            LabelActionAnggota.Text = "Edit Anggota";
            BtnActionAnggota.Text = "Edit";
        }

        public void ResetAnggota()
        {
            selectedAnggotaIndex = -1;

            TextBoxAnggotaNama.Clear();
            TextBoxAnggotaAlamat.Clear();
            TextBoxAnggotaNoTelp.Clear();

            LabelActionAnggota.Text = "Tambah Anggota";
            BtnActionAnggota.Text = "Tambah";
            anggotasTableAdapter.Fill(perpustakaanDataSet.anggotas);
        }

        private void BtnActionAnggota_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextBox(TextBoxAnggotaNama, TextBoxAnggotaAlamat, TextBoxAnggotaNoTelp)) return;

            // Jika menambah data
            if(selectedAnggotaIndex == -1)
            {
                var cmd = new OdbcCommand("INSERT INTO anggotas (Nama, Alamat, NoTelp) VALUES (?, ?, ?)", Connection);
                cmd.Parameters.AddWithValue("", TextBoxAnggotaNama.Text);
                cmd.Parameters.AddWithValue("", TextBoxAnggotaAlamat.Text);
                cmd.Parameters.AddWithValue("", TextBoxAnggotaNoTelp.Text);
                cmd.ExecuteNonQuery();

                ResetAnggota();
            }
        }
    }
}
