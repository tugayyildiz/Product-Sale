using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaret
{
    public class SatisDal
    {
        Database database = null;
       public SatisDal(Database database)
        {
            this.database = database;
        }

            public DataTable GetAllUrun()
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
        public DataTable GetAllMusteri()
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
        public DataTable GetAllSatis()
        {
            database.ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from satis", database.connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            database.connection.Close();
            return dataTable;

        }

        public void Add(Satis satis1)
        {
            database.ConnectionControl();
            try
            {

                SqlCommand command = new SqlCommand("Insert into satis values(@kod,@evrak_no,@evrak_tarihi,@aciklamaa)", database.connection);
                command.Parameters.AddWithValue("@kod", satis1.sat_musterikodu);
                command.Parameters.AddWithValue("@evrak_no", satis1.sat_evrakno);
                command.Parameters.AddWithValue("@evrak_tarihi", satis1.sat_evraktarihi);
                command.Parameters.AddWithValue("@aciklamaa", satis1.sat_aciklama);
                command.ExecuteNonQuery();
            }
            catch (SqlException exception) {
                Console.WriteLine(exception.Message);
            }

        }

    }
    }

