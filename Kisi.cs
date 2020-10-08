using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassUygulama
{
    class Kisi
    {
        


        string _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        string _soyAd;
        public string SoyAd
        {
            get { return _soyAd; }
            set { _soyAd = value; }
        }

        string _meslek;
        public string Meslek
        {
            get { return _meslek; }
            set { _meslek = value; }
        }

        DateTime _tarih;
        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        bool _evliMi;
        public bool EvliMi
        {
            get { return _evliMi; }
            set { _evliMi = value; }
        }

        public override string ToString()
        {
            //bir metodu tekrar tanımlar.
            return _ad +","+ _soyAd +","+ _meslek +","+_tarih +","+ _evliMi;
        }

        public string TamAd
        {
            get { return _ad + _soyAd; }
        }

    }
}
