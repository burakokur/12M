using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{   //STI veri tabanı nesnesi oluşturuldu.
    //Bağımlılıkları yönetmek için soyut bir classtan türetildi.

    public class STI :IEntity
    {
        public int SiraNo { get; set; }
        public int Id { get; set; }
        public short IslemTuru { get; set; }
        public string EvrakNo { get; set; }
        public int Tarih { get; set; }
        public string MalKodu { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Miktar { get; set; }
        public decimal Tutar { get; set; }
        public string Birim { get; set; }

    }
}
