using Savas_library.Abstract;
using System;
using System.Drawing;

namespace Savas_library.Concrete
{
    class Mermi : Cisim

    {
        public Mermi(Size hareket_alani_boyutlari,int namlu_ortasi_x) :base(hareket_alani_boyutlari)
        {
            baslangic_konumu_ayarla(namlu_ortasi_x);
            hareket_mesafesi = (int)(Height * 1.5);
        }

        private void baslangic_konumu_ayarla(int namlu_ortasi_x)
        {
            Bottom = Hareket_alani_boyutlari.Height;
            Center = namlu_ortasi_x;
        } 
    }
}
