using Savas_library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Savas_library.Concrete
{
    internal class Ucak:Cisim
    {
        private static readonly Random Random = new Random(); // static yapmamın sebebi her ucak nesnesi için ayrı bir Random nesnesi oluşmaması için 
        // statik yaparsam statik bölgede yalnızca 1 tane nesne olur
        public Ucak(Size hareket_alani_boyutlari) : base(hareket_alani_boyutlari)
        {
            hareket_mesafesi = (int)(Height*0.15);
            Left = Random.Next(hareket_alani_boyutlari.Width - Width + 1);// her next denildiğinde o sabit listeden sırasıyla gelir.
            
        }
        public Mermi Vuruldu_mu(List<Mermi> mermiler)
        {
            foreach (var mermi in mermiler)
            {
                var vuruldu_mu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vuruldu_mu) return mermi;
            }
            return null;
        }
    }
}
