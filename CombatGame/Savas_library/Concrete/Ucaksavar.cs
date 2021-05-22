using Savas_library.Abstract;
using System.Drawing;
using System.Windows.Forms;

namespace Savas_library.Concrete
{
    internal class Ucaksavar :Cisim // her ucaksavar bir cisimdir

    {
        public Ucaksavar(int panel_genisliği,Size hareket_alani_boyutlari) : base(hareket_alani_boyutlari)
        {
            Center = panel_genisliği / 2;
            hareket_mesafesi = Width/2;

        } 
    }
}
