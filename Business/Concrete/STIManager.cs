using Business.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{   //İleriye dönük İş kuralları için oluşturulan katman.
    public class STIManager : ISTIService
    {
        public List<DTOStockDetails> GetAll(string malKodu, int baslangicTarihi, int bitisTarihi)
        {
            STIDal sTIDal = new STIDal();
            return sTIDal.GetAll(malKodu,baslangicTarihi,bitisTarihi);
        }
    }
}
