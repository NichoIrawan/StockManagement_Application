using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Notifikasi
    {
        public enum notifApp { keluar, masuk, habis, kadaluarsa };

        string[] screenName = { "Notif Keluar", "Notif Masuk", "Notif Habis", "Notif Expired" };

        public string ReadNotif(notifApp status)
        {
            return screenName[(int)status];
        }
    }

}
