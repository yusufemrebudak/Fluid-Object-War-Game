using Savas_library.Enum;
using System.Drawing;

namespace Savas_library.Interface
{
    internal interface IHareketEden
    {
        /// <summary>
        /// Cismi istenilen yonde hareket ettirir
        /// </summary>
        /// <param name="yon">Hangi yonde hareket ettireceği</param>
        /// <returns>Cisim duvara çarparsa true dondurur</returns>
        bool hareket_ettir(Yon yon);
        Size Hareket_alani_boyutlari { get; }
        int hareket_mesafesi { get; }
    }
}
