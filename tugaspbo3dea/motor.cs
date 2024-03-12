using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3dea
{
    class Motor : Otomobil
    {
        public override void Bunyi()
        {
            Console.WriteLine("Bunyi Motor Zx25r: ngingggg");
        }
        public void setMotor(string Tipe, string Warna, int Tahun)
        {
            this.Tipe = Tipe;
            this.Warna = Warna;
            this.Tahun = Tahun;
        }
        public (string, string, int) getMotor()
        {
            return (Tipe, Warna, Tahun);
        }
    }  
}
