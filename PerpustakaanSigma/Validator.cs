using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanSigma
{
    public class Validator
    {
        public static bool ValidateTextBox(params BunifuTextBox[] textBoxes)
        {
            foreach (BunifuTextBox box in textBoxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    MessageBox.Show("Input tidak boleh kosong!");
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateIndex(int index)
        {
            if(index == -1)
            {
                MessageBox.Show("Silahkan pilih data dari tabel terlebih dahulu!");
                return false;
            }
            return true;
        }
        public static bool ValidateNumericTextBox(BunifuTextBox textBox, string alertName)
        {
            var res = int.TryParse(textBox.Text, out _);
            if (!res) MessageBox.Show("Input " + alertName + " harus angka!");
            return res;
        }
    }
}
