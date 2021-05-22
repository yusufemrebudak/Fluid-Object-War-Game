using Savas_library.Concrete;
using Savas_library.Enum;
using System;
using System.Windows.Forms;

namespace Savas_Desktop
{
    public partial class ana_form : Form
    {
        private readonly Oyun _oyun; 
        public ana_form()
        {
            InitializeComponent();// burada ucaksavar_panel oluşturulduğu için ucaksavar_panel i parametre olarak nesneye verebildim
            _oyun = new Oyun(ucaksavar_panel,savas_alani_panel);
            _oyun.gecen_sure_degisti += Oyun_gecen_sure_degisti;// oyun sınıfının olayı tetiklendiğinde "Oyun_gecen_sure_degisti" methodu çalışsın dedim
            _oyun.skor_degisti += oyun_skor_degisti;
        }

       

        private void ana_form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.baslat();
                    break;
                case Keys.Right:
                    _oyun.ucak_savar_hareket_ettir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.ucak_savar_hareket_ettir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.ates_et();
                    break;
            }
        }
        private void Oyun_gecen_sure_degisti(object sender, EventArgs e)
        {
            sure_label.Text = _oyun.Gecen_sure.ToString(@"m\:ss");
        }
        private void oyun_skor_degisti(object sender, EventArgs e)
        {
            skor_label.Text = Convert.ToString(_oyun.Skor);
        }


    }
}
