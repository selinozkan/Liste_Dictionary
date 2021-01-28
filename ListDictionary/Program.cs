using System;
using System.Collections.Generic;

namespace ListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // <LİST>


            /* 
             1) Diziler sabit boyutludur belirtiğin boyutun dışına çıkılmaz.Koleksiyonlar
            ise dinamik yapıdadır, eleman eklendikçe boyutu artmaktadır.
            2) Dizilerde aynı veri tipindeki elemanları içermekte ama koleksiyolarda böyle
            bir kısıtlama bulunmamaktadır.
            


            // Eleman ekleme ve sayma
            List<int> sayilar = new List<int>();
            sayilar.Add(13);
            sayilar.Add(15);
            sayilar.Add(17);
           
            Console.WriteLine(sayilar.Count);

            // Elemanları foreach döngüsünde gösterme
            foreach (var sayı in sayilar)
            {
                Console.WriteLine(sayı);
            }

            // Eleman çıkarma

            sayilar.Remove(13);
            foreach (var sayı in sayilar)
            {
                Console.WriteLine(sayı);
            }

              */

            List<string> liste = new List<string>();
            liste.Add("selin");
            Console.WriteLine(liste.Count);
            Console.WriteLine(liste.Count);
            bool varmı = liste.Contains("selin");
            Console.WriteLine(varmı);

            MyDictionary<string,int> c = new MyDictionary<string, int>();
            c.Add("GÜNSELİ",25);

            c.Add("DERİN", 16);

        
            for (int i = 0; i < c.İsim.Length; i++)
            {
                Console.WriteLine("İsim :{0}  YAŞ:{1}", c.İsim[i], c.Yas[i]);
            }
             
            
            



        }
    }
}
