using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Registros.DAO
{
    class ConexionBD
    {
        protected SqlConnection Conexion = new SqlConnection("Server=DT-JTORO\\SQLEXPRESS;Database=Practica_Patrones;User Id=sa;Password=nomelase;");
    }
}
