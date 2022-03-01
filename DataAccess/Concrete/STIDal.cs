using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{   //Veri Tabanı  işlemleri gerçekleştirildi .(Veriye erişildi)
    public class STIDal : ISTIDal
    {   
        public List<DTOStockDetails> GetAll(string malKodu, int baslangicTarihi, int bitisTarihi)
        {    
            string connectionString = "server=DESKTOP-MD480VI;Database=Test;trusted_connection=true;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                connection.Open();

                SqlCommand command = new SqlCommand("SP_12M", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_MALKODU", malKodu);
                command.Parameters.AddWithValue("@p_BASLANGICTARIH", baslangicTarihi);
                command.Parameters.AddWithValue("@p_BITISTARIH", bitisTarihi);
                List<DTOStockDetails> stockDetails = new List<DTOStockDetails>();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    stockDetails.Add(new DTOStockDetails
                    {
                        SiraNo  = Convert.ToInt32(dataReader[0]),
                        IslemTur = dataReader[1].ToString(),
                        EvrakNo =dataReader[2].ToString(),
                        Tarih = dataReader[3].ToString(),
                        GirisMiktari= Convert.ToInt32(dataReader[4]),
                        CikisMiktari= Convert.ToInt32(dataReader[5]),
                        StokMiktari= Convert.ToInt32(dataReader[6])
                    }
                    ) ;


                }

                connection.Close();
                connection.Dispose();
                return stockDetails;
            }
        }
    }
}