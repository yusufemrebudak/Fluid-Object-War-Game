using Savas_library.Enum;
using System;

namespace Savas_library.Interface
{
    internal interface IOyun 
        // internal yazarsak interface in başına bu interface yalnızca o assembly içerisinde kullanılabilir
        // yani sadece savas_library içerisinden IOyun interface ine erişebilirim.Public dersem diğer projelerden de erişebiliriz yani bir access modifier dir.
    {
        event EventHandler gecen_sure_degisti;
        bool devam_ediyor_mu { get; }
        TimeSpan Gecen_sure { get; }
        void baslat();
        void ates_et();
        void ucak_savar_hareket_ettir(Yon yon);
    }
}
