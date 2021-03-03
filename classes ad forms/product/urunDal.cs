using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaret
{
    public class urunDal
    {
        Database database = null;
       public urunDal(Database database)
        {
            this.database = database;
        }

        public DataTable GetAll()
        {
            database.ConnectionControl();
        
            SqlCommand command = new SqlCommand("Select * from urun", database.connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            database.connection.Close();
            return dataTable;

        }


        public void Add(urun urun1) {
            database.ConnectionControl();
            try
            {
                
                SqlCommand command = new SqlCommand("Insert into urun values(@kod,@ad,@birim,@fiyat,@kdv)", database.connection);
                command.Parameters.AddWithValue("@kod", urun1.uru_kod);
                command.Parameters.AddWithValue("@ad", urun1.uru_ad);
                command.Parameters.AddWithValue("@birim", urun1.uru_birim);
                command.Parameters.AddWithValue("@fiyat", urun1.uru_fiyat);
                command.Parameters.AddWithValue("@kdv", urun1.uru_kdvorani);
                command.ExecuteNonQuery();
            }
            catch (SqlException exception) 
            {
            }
            
        }

    }

}
