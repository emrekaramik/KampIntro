using System;

namespace OOP3

{
     class Program
    {
        static void Main(string[] args)
        {
            //interfaceler implemente edildiği classın referanslarını tutar
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
           
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager);

        }
    }
}