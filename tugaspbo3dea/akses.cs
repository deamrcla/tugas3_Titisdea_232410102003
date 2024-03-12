// See https://aka.ms/new-console-template for more information
using tugaspbo3dea;

//Console.WriteLine("Hello, World!");

namespace Tugas3
{
    class Akses
    {
        static void Main(string[]args)
        {
            //akses class
            Otomobil mobil = new Otomobil();
            mobilsedan mobilsedan = new mobilsedan();
            truk truk = new truk();
            Motor motor = new Motor();
            //set value
            mobilsedan.setMobilSedan("toyota", "hitam", 2020);
            truk.setTruk("tronton", "kuning", 2018);
            motor.setMotor("zx", "hitam", 2021);
            //get value dan pemisah value
            //mobilsedan
            (string,string,int) valuesmobilsedan = mobilsedan.getMobilSedan();
            string satumobilsedan = valuesmobilsedan.Item1;
            string duamobilsedan = valuesmobilsedan.Item2;
            int tigamobilsedan = valuesmobilsedan.Item3;

            //truk
            (string,string,int) valuestruk = truk.getTruk();
            string satutruk = valuestruk.Item1;
            string duatruk = valuestruk.Item2;
            int tigatruk = valuestruk.Item3;    

            //motor
            (string,string,int) valuesmotor = motor.getMotor();
            string satumotor = valuesmotor.Item1;
            string duamotor = valuesmotor.Item2;
            int tigamotor = valuesmotor.Item3;
            //overriding
            Console.WriteLine("Overriding");
            mobil.Bunyi();
            mobilsedan.Bunyi();
            truk.Bunyi();
            motor.Bunyi();
            //menampilkan ke konsol
            Console.WriteLine($"\nOtomobil" +
                $"\nMobil Sedan" +
                $"\nTipe : {satumobilsedan}" +
                $"\nWarna : {duamobilsedan}" +
                $"\nTahun : {tigamobilsedan}" +
                $"\n\nTruk" +
                $"\nTipe : {satutruk}" +
                $"\nWarna :{duatruk}" +
                $"\nTahun : {tigatruk}" +
                $"\n\nMotor" +
                $"\nTipe : {satumotor}" +
                $"\nWarna : {duamotor}" +
                $"\nTahun : {tigamotor}");
        }
    }
}
