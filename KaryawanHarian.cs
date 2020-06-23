using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji()
        {
            return (UpahPerJam * JumlahJamKerja);
        }
    }
}
