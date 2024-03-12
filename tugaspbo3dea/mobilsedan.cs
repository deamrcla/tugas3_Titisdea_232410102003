using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3dea
{
    class Otomobil
    {
        public string Tipe;
        public string Warna;
        public int Tahun;
        public virtual void Bunyi()
        {
            Console.WriteLine("Bunyi Default : Brum Brum");
        }    
    }
    class mobilsedan : Otomobil
    {
        public override void Bunyi()
        {
            Console.WriteLine("Bunyi Mobil Sedan Toyota:brum brum");
        }
        public void setMobilSedan(string Tipe, string Warna, int Tahun)
        {
            this.Tipe = Tipe;
            this.Warna = Warna;
            this.Tahun = Tahun;
        }
        public(string,string,int) getMobilSedan()
        {
            return(Tipe,Warna,Tahun);
        }
    }
}
