using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingAssignment.Models
{
    public static class ToyDb
    {
        public static void Catalog(Toy t)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ToyDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Toy (Title,Description,Color,Company,Type)" +
                " VALUES (@Title,Description,Color,Company,Type)";
            cmd.Parameters.AddWithValue("@Title", t.Title);
            cmd.Parameters.AddWithValue("@Description", t.Description);
            cmd.Parameters.AddWithValue("@Color", t.Color);
            cmd.Parameters.AddWithValue("@Company", t.Company);
            cmd.Parameters.AddWithValue("@Type", t.Type);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }

        
    }
}
