using System;
namespace Donguler_While_Foreach
{
    class Program
    {
        static void Main(string[]args)
        {
            //1'den başlayıp konsoldan girilen sayıya kadar olan sayıların ortalamasını yazdıran program.
        Console.WriteLine("Sayı giriniz: ");
        int sayi=Convert.ToInt32(Console.ReadLine());
        int sayac=1;
        int toplam=0;
        
           while (sayac<=sayi)
           { 
              toplam=toplam+sayac;
              sayac++;  
           } 
           Console.WriteLine(toplam/sayi);
       
       //a' dan z'ye kadar harfleri yazdıran program.
        char character='a';
        while(character<='z')
        {
            Console.Write(character);
            character++;
        }
        //foreach döngüsü ile dizi döndürme. 
         string[] arabalar={"BMW","MERCEDES","AUDI","OPEL","TOYOTA"};
         foreach (var araba in arabalar)
          {
          Console.WriteLine(araba); 
          }
          } 
      }
}
