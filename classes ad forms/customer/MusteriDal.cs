using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaret
{
    public class MusteriDal
    {
        Database database = null;
        public MusteriDal(Database database)
        {
            this.database = database;
        }

  
        public DataTable GetAll()
        {
            database.ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from musteri", database.connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            database.connection.Close();
            return dataTable;

        }


        public void Add(Musteri musteri1){
            database.ConnectionControl();
            try
            {

                SqlCommand command = new SqlCommand("Insert into musteri values(@kod,@ad,@adres_1,@adres_2,@adres_3,@tel,@mail)", database.connection);
                command.Parameters.AddWithValue("@kod", musteri1.mus_kod);
                command.Parameters.AddWithValue("@ad", musteri1.mus_ad);
                command.Parameters.AddWithValue("@adres_1", musteri1.mus_adres1);
                command.Parameters.AddWithValue("@adres_2", musteri1.mus_adres2);
                command.Parameters.AddWithValue("@adres_3", musteri1.mus_adres3);
                command.Parameters.AddWithValue("@tel", musteri1.mus_telefon);
                command.Parameters.AddWithValue("@mail", musteri1.mus_email);

                command.ExecuteNonQuery();
            }
            catch (SqlException exception) { }
        }


    }
}
