using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    class Notifikasi
    {
        public enum notifApp { keluar, masuk, notif_habis, notif_expired };

        string[] screenName = { "Notif Keluar", "Notif Masuk", "Notif Habis", "Notif Expired" };

        public string ReadNotif(notifApp status)
        {
            return screenName[(int)status];
        }
    }

}
