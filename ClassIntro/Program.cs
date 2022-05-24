namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Kerem Varış";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Pyton";
            kurs2.Egitmen = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c#";
            kurs3.Egitmen = "Engin Demirog";
            kurs3.IzlenmeOrani = 68;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "data";
            kurs4.Egitmen = "Engin Demirog";
            kurs4.IzlenmeOrani = 100;



            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }


        }
    }



    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }



}


