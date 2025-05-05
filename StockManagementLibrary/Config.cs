using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementLibrary
{
    public class Config
    {
        public Bahasa bahasa { get; set; }


        public Config()
        {
            this.bahasa = Bahasa.Indonesia;
        }
    }
}
