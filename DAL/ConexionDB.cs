using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    
    public class ConexionDB
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public ConexionDB()
        {
            con = new SqlConnection("Data Source = JUNIOR-PC\\ROOT;Initial Catalog = RegistroPeliculaDb;Integrated Security = true");
            cmd = new SqlCommand();
        }
        public bool Ejecutar(String ComandoSql)
        {
            bool retorno = false;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ComandoSql;
                cmd.ExecuteNonQuery();
                retorno = true;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }
        public DataTable ObtenerDatos(string ComandoSql)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
