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
    }
}
