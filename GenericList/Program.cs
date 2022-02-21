using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayıListesi = new List<int>();

            sayıListesi.Add(23);
            sayıListesi.Add(18);
            sayıListesi.Add(4);
            sayıListesi.Add(5);
            sayıListesi.Add(10);
            sayıListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("sarı");
            renkListesi.Add("turuncu");
            renkListesi.Add("yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayıListesi.Count);

            foreach (var sayı in sayıListesi)
            {
                Console.WriteLine(sayı);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayıListesi.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayıListesi.Remove(4);
            renkListesi.Remove("yeşil");
            sayıListesi.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayıListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayıListesi.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste  içinde arama
            if (sayıListesi.Contains(10)){
                Console.WriteLine("10 liste içinde bulundu");
            }
            //eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            //diziyi listeye çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvan = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz
            hayvan.Clear();

            //liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Özlem";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 24;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Ayşe";
            kullanıcı2.Soyisim = "Demir";
            kullanıcı2.Yas = 22;

            kullanıcListesi.Add(kullanıcı1);
            kullanıcListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 18

            }) ;
            foreach (var kullanıcı in kullanıcListesi)
            {
                Console.WriteLine("Kullanıcı adı:"+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyadı:"+ kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaşı:"+ kullanıcı.Yas);
            }
              
            
         }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

       
       
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        public string Isim { get => isim; set => isim = value; }
    }
}
