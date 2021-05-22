using Savas_library.Enum;
using Savas_library.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Savas_library.Abstract
{
    internal abstract class Cisim : PictureBox,IHareketEden // her cisim bir picturebox dır.
    {
        public Size Hareket_alani_boyutlari { get;  }

        public int hareket_mesafesi { get; protected set; }

        public new int Right // kendi Right metodumuzu yazdık ana sınıftan geleni ezdi.
        {
            get => base.Right;
            set => Left = value - Width;
        }
        public new int Bottom // kendi Right metodumuzu yazdık ana sınıftan geleni ezdi.
        {
            get => base.Bottom;
            set => Top = value - Height ;
        }
        public int Center
        {
            get => Left + (Width / 2);
            set => Left = value - (Width / 2);
        }
        public int Middle
        {
            get => Top + (Height / 2);
            set => Top = value - (Height / 2);
        }
        protected  Cisim(Size hareket_alani_boyutlari)
        {
            Image = Image.FromFile($"img/{GetType().Name}.png");//exe dosyamın yan tarafında arar. // gettype().name ile nesnenin oluşturulduğu gerçek sınıfın ismi verir yani miras alan sınıfın ismini verir.
            Hareket_alani_boyutlari = hareket_alani_boyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

       

        public bool hareket_ettir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return Yukari_hareket_ettir();
                case Yon.Saga:
                    return Saga_hareket_ettir();
                case Yon.Asagi:
                    return Asagi_hareket_ettir();
                case Yon.Sola:
                    return Sola_hareket_ettir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        private bool Sola_hareket_ettir()
        {
            if (Left == 0) return true;
            var yeni_left = Left - hareket_mesafesi;
            var tasacak_mi = yeni_left < 0;
            Left = tasacak_mi ? 0 : yeni_left;
            return Left == 0;
        }
       

        private bool Saga_hareket_ettir()
        {
            if (Right == Hareket_alani_boyutlari.Width) return true;
            var yeni_right = Right + hareket_mesafesi;
            var tasacak_mi = yeni_right > Hareket_alani_boyutlari.Width;
            Right = tasacak_mi ? Hareket_alani_boyutlari.Width : yeni_right;           
            return Right == Hareket_alani_boyutlari.Width;
        }

        private bool Asagi_hareket_ettir()
        {
            if (Bottom == Hareket_alani_boyutlari.Height) return true;
            var yeni_bottom = Bottom + hareket_mesafesi;
            var tasacak_mi = yeni_bottom > Hareket_alani_boyutlari.Height;
            Bottom = tasacak_mi ? Hareket_alani_boyutlari.Height : yeni_bottom;
            return Bottom == Hareket_alani_boyutlari.Height;
        }

        
        private bool Yukari_hareket_ettir()
        {
            if (Top == 0) return true;
            var yeni_top = Top - hareket_mesafesi;
            var tasacak_mi = yeni_top < 0;
            Top = tasacak_mi ? 0 : yeni_top;
            return Top == 0;
        }
    }
}