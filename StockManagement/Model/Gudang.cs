using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    class Gudang
    {
        
        public String namaGudang { get; set; }
        public String lokasi { get; set; }

        public List<Barang> listItemGudang { get; set; }
    }
}
