using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8.ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji()
        {
            return (JumlahPenjualan * Komisi);
        }
    }
}
