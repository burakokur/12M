using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISTIDal
    {
        List<DTOStockDetails> GetAll(string malKodu,int baslangicTarihi,int bitisTarihi);
    }
}
