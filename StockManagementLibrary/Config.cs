using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementLibrary
{
    class Config
    {
        public string BahasaIndonesia { get; set; }
        public string BahasaInggris { get; set; }
        public Config() { }
          

        public Config(string bahasaIndonesia, string bahasaInggris)
        {
            this.BahasaIndonesia = bahasaIndonesia;
            this.BahasaInggris = bahasaInggris;
        }
    }
}
