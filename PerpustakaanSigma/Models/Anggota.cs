using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan.Models
{
    public class Anggota
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
    }
    public class DataAnggota
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
    }
}
