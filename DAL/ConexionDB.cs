using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    
    class ConexionDB
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public ConexionDB()
        {
            con = new SqlConnection("Data Source = JUNIOR-PC\ROOT;Initial Catalog = RegistroPeliculaDb;Integrated Security = true");
            cmd = new SqlCommand();
        }
    }
}
