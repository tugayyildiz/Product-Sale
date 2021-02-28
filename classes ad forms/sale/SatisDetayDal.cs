using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaret
{
    public class SatisDetayDal
    {
        Database database = null;
        public SatisDetayDal(Database database)
        {
            this.database = database;
        }
        public DataTable GetAll()
        {
            database.ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from satisdetay", database.connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            database.connection.Close();
            return dataTable;

        }
        public void Add(SatisDetay satis1)
        {
            database.ConnectionControl();
            try
            {

                SqlCommand command = new SqlCommand("Insert into satis values(@evrakno,@kod,@miktar,@fiyat,@tutar,@kdvoran,@kdvtutar,@toplam)", database.connection);
                command.Parameters.AddWithValue("@evrakno", satis1.sad_satisevrakno);
                command.Parameters.AddWithValue("@kod", satis1.sad_urunkodu);
                command.Parameters.AddWithValue("@miktar", satis1.sad_miktar);
                command.Parameters.AddWithValue("@fiyat", satis1.sad_fiyat);
                command.Parameters.AddWithValue("@tutar", satis1.sad_tutar);
                command.Parameters.AddWithValue("@kdvoran", satis1.sad_kdvorani);
                command.Parameters.AddWithValue("@kdvtutar", satis1.sad_kdvtutari);
                command.Parameters.AddWithValue("@toplam", satis1.sad_geneltoplam);
                command.ExecuteNonQuery();
            }
            catch (SqlException exception) { }

        }
    }
}
