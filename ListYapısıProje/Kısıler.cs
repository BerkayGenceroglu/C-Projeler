using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListYapısıProje
{
    public class Kısıler
    {
        string isim;
        string soyisim;
        int yas;

        //isim, soyisim, yas adlı özel değişkenler (field) oluşturuluyor.
        //Adı, Soyadı, Yası adında public özellikler(property) tanımlanıyor
        //🔹 isim, soyisim ve yas değişkenlerini dışarıdan direkt erişime kapatmak (encapsulation).
        //🔹 Bunlara sadece get ve set metotları ile ulaşabilmek.
        public string Adı
        {
            get { return isim; } 
            set {  isim = value; }
        }
        public string Soyadı
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
        public int Yası
        {
            get { return yas; }
            set { yas = value;}
        }

    }
}
