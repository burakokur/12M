using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{   //SPden dönen değerleri DTO ile karşılamak.
   public class DTOStockDetails:IDTO
    {   
        public int SiraNo { get; set; }
        public string IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public int GirisMiktari { get; set; }
        public int CikisMiktari { get; set; }
        public int StokMiktari { get; set; }

    }
}
