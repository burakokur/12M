using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{   //STK veri tabanı nesnesi oluşturuldu.
    public class STK:IEntity
    {
        public int Id { get; set; }
        public string MalAdi { get; set; }
        public string MalKodu { get; set; }
    }
}
