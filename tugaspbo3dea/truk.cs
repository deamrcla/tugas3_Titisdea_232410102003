using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3dea
{
    class truk : Otomobil
    {
        public override void Bunyi()
        {
            Console.WriteLine("Bunyi Truk tronton: bremmm");
        }
        public void setTruk(string Tipe, string Warna, int Tahun)
        {
            this.Tipe = Tipe;
            this.Warna = Warna;
            this.Tahun = Tahun;
        }
        public (string, string, int) getTruk()
        {
            return (Tipe, Warna, Tahun);
        }
    }
}
