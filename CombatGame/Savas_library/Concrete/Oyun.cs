using Savas_library.Enum;
using System.Drawing;
using Savas_library.Interface;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Savas_library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar(Field)
        private readonly Timer _gecen_sure_timer = new Timer { Interval = 1000 };
        private readonly Timer _hareket_timer = new Timer { Interval = 100 };
        private readonly Timer _ucak_olusturma_timer = new Timer { Interval = 1000 };

        private TimeSpan _gecen_sure;
        private readonly Panel _ucaksavar_panel;
        private readonly Panel _savasalani_panel;
        private Ucaksavar _ucaksavar;
        private readonly List<Mermi> _mermiler = new List<Mermi>(); // bir liste oluşturduk generic list
        private readonly List<Ucak> _ucaklar = new List<Ucak>(); // bir liste oluşturduk generic list
        private int _skor;

        #endregion

        #region Olaylar(Events)
        public event EventHandler gecen_sure_degisti;
        public event EventHandler skor_degisti;
        #endregion


        #region Proporties(Özellikler)
        public bool devam_ediyor_mu { get; private set; }
        public TimeSpan Gecen_sure
        {
            get => _gecen_sure;
            private set
            {
                _gecen_sure = value;
                gecen_sure_degisti?.Invoke(this, EventArgs.Empty);
            } 
        }
        public int Skor
        {
            get => _skor;
            private set
            {
                _skor = value;
                skor_degisti?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Metotlar

        public Oyun(Panel ucaksavar_panel, Panel savasalani_panel)
        {
            _ucaksavar_panel = ucaksavar_panel;
            _savasalani_panel = savasalani_panel;
            _gecen_sure_timer.Tick += gecen_sure_timer_tick;
            _hareket_timer.Tick += hareket_timer_tick;
            _ucak_olusturma_timer.Tick += ucak_olusturma_timer_tick;
            _skor = 0;

        }

        public void ates_et()
        {
            if (!devam_ediyor_mu) return;
            var mermi = new Mermi(_savasalani_panel.Size,_ucaksavar.Center);
            _mermiler.Add(mermi);
            _savasalani_panel.Controls.Add(mermi);
        }

        private void gecen_sure_timer_tick(object sender,EventArgs e)
        {
            Gecen_sure += TimeSpan.FromSeconds(1);
            

        }
        private void ucak_olusturma_timer_tick(object sender, EventArgs e)
        {
            ucak_olustur();

        }
        private void hareket_timer_tick(object sender, EventArgs e)
        {
            mermileri_hareket_ettir();
            ucaklari_hareket_ettir();
            vurulan_ucak_cikar();
            Skor = _skor;
        }

        private void vurulan_ucak_cikar()
        {
            
            for (int i = _ucaklar.Count-1 ; i >= 0 ; i--)
            {
                
                var ucak = _ucaklar[i];
                var vuran_mermi = ucak.Vuruldu_mu(_mermiler);
                if (vuran_mermi is null) continue;
                _skor++;
                _ucaklar.Remove(ucak);
                _mermiler.Remove(vuran_mermi);
                _savasalani_panel.Controls.Remove(ucak);
                _savasalani_panel.Controls.Remove(vuran_mermi);
            }
        }

        private void ucaklari_hareket_ettir()
        {
            foreach (var ucak in _ucaklar)
            {
                var carpti_mi = ucak.hareket_ettir(Yon.Asagi);
                if (!carpti_mi) continue;
                bitir();
                break;
            }
        }

        private void mermileri_hareket_ettir()
        {
            for (int i = _mermiler.Count-1; i >=0 ; i--)
            {
                var mermi = _mermiler[i];
                var carpti_mi = mermi.hareket_ettir(Yon.Yukari);
                if (carpti_mi)
                {
                    _mermiler.Remove(mermi);
                    _savasalani_panel.Controls.Remove(mermi);
                }
            }
           
        }

        public void baslat()
        {
            if (devam_ediyor_mu) return;
            devam_ediyor_mu = true;
            zamanlayicilari_baslat();
            ucaksavar_olustur();
            ucak_olustur();
        }

        private void ucak_olustur()
        {
            var ucak = new Ucak(_savasalani_panel.Size);
            _ucaklar.Add(ucak);
            _savasalani_panel.Controls.Add(ucak);
        }

        private void zamanlayicilari_baslat()
        {
            _gecen_sure_timer.Start();
            _hareket_timer.Start();
            _ucak_olusturma_timer.Start();
        }
        private void zamanlayicilari_durdur()
        {
            _gecen_sure_timer.Stop();
            _hareket_timer.Stop();
            _ucak_olusturma_timer.Stop();

        }
        private void ucaksavar_olustur()
        {
            _ucaksavar = new Ucaksavar(_ucaksavar_panel.Width,_ucaksavar_panel.Size);
            _ucaksavar_panel.Controls.Add(_ucaksavar);
            
        }

        private void bitir()
        {
            if (!devam_ediyor_mu) return;
            devam_ediyor_mu = false;
            zamanlayicilari_durdur();

        }

        public void ucak_savar_hareket_ettir(Yon yon)
        {
            if (!devam_ediyor_mu) return;
            _ucaksavar.hareket_ettir(yon);
        }
        #endregion
    
    
    }
}
