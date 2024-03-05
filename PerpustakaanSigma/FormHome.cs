using CrystalDecisions.CrystalReports.Engine;
using PerpustakaanSigma.perpustakaanDataSetTableAdapters;
using PerpustakaanSigma.Reports;
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
            // TODO: This line of code loads data into the 'perpustakaanDataSet.peminjaman' table. You can move, or remove it, as needed.
            this.peminjamanTableAdapter.Fill(this.perpustakaanDataSet.peminjaman);

            ResetAnggota();
            ResetBuku();
        }
        public void PrintDocument(string documentName)
        {
            var pd = new PrintDialog();
            if (pd.ShowDialog() != DialogResult.OK) return;

            var rd = new ReportDocument();
            rd.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
            rd.Load(Application.StartupPath + "/../../Reports/Report" + documentName + ".rpt");
            rd.PrintToPrinter(pd.PrinterSettings.Copies, pd.PrinterSettings.Collate, pd.PrinterSettings.FromPage, pd.PrinterSettings.ToPage);
        }

        // Tab Anggota
        int selectedAnggotaIndex = -1;
        private void BtnDeleteAnggota_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateIndex(selectedAnggotaIndex)) return;

            var selectedAnggotaId = perpustakaanDataSet.anggotas[selectedAnggotaIndex].Id;
            anggotasTableAdapter.DeleteQuery(selectedAnggotaId);

            ResetAnggota();
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
                anggotasTableAdapter.Insert(TextBoxAnggotaNama.Text, TextBoxAnggotaAlamat.Text, TextBoxAnggotaNoTelp.Text);

                ResetAnggota();
            } else {
                var selectedAnggotaId = perpustakaanDataSet.anggotas[selectedAnggotaIndex].Id;
                anggotasTableAdapter.UpdateQuery(TextBoxAnggotaNama.Text, TextBoxAnggotaAlamat.Text, TextBoxAnggotaNoTelp.Text, selectedAnggotaId);

                ResetAnggota();
            }
        }
        private void BtnClearAnggota_Click(object sender, EventArgs e)
        {
            ResetAnggota();
        }
        private void BtnPrintAnggota_Click(object sender, EventArgs e)
        {
            PrintDocument("Anggota");
        }

        // Tab Buku
        int selectedBukuIndex = -1;
        private void BtnHapusBuku_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateIndex(selectedBukuIndex)) return;
            bukusTableAdapter.DeleteQuery(selectedBukuIndex);

            ResetBuku();
        }
        public void SetEditBuku()
        {
            var buku = perpustakaanDataSet.bukus[selectedBukuIndex];
            TextBoxBukuJudul.Text = buku.Judul;
            TextBoxBukuPenulis.Text = buku.Penulis;
            TextBoxBukuPenerbit.Text = buku.Penerbit;
            TextBoxBukuStok.Text = buku.Stok.ToString();

            LabelActionBuku.Text = "Edit Buku";
            BtnActionBuku.Text = "Edit";
        }
        public void ResetBuku()
        {
            selectedBukuIndex = -1;

            TextBoxBukuJudul.Clear();
            TextBoxBukuPenulis.Clear();
            TextBoxBukuPenerbit.Clear();
            TextBoxBukuStok.Clear();

            LabelActionBuku.Text = "Tambah Buku";
            BtnActionBuku.Text = "Tambah";
            bukusTableAdapter.Fill(perpustakaanDataSet.bukus);
        }
        private void BtnActionBuku_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextBox(TextBoxBukuJudul, TextBoxBukuPenerbit, TextBoxBukuPenulis, TextBoxBukuStok)) return;
            if (!Validator.ValidateNumericTextBox(TextBoxBukuStok, "stok")) return;

            if(selectedBukuIndex == -1)
            {
                bukusTableAdapter.Insert(TextBoxBukuJudul.Text, TextBoxBukuPenulis.Text, TextBoxBukuPenerbit.Text, int.Parse(TextBoxBukuStok.Text));

                ResetBuku();
            } else
            {
                var selectedBukuId = perpustakaanDataSet.bukus[selectedBukuIndex].Id;
                bukusTableAdapter.UpdateQuery(TextBoxBukuJudul.Text, TextBoxBukuPenulis.Text, TextBoxBukuPenerbit.Text, int.Parse(TextBoxBukuStok.Text), selectedBukuId);

                ResetBuku();
            }
        }
        private void BtnPrintBuku_Click(object sender, EventArgs e)
        {
            PrintDocument("Buku");
        }
        private void DataGridViewBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBukuIndex = DataGridViewBuku.CurrentCell.RowIndex;
            SetEditBuku();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peminjamanTableAdapter.FillBy(this.perpustakaanDataSet.peminjaman);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
