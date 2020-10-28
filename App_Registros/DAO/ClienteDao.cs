using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Registros.DAO
{
    class ClienteDao : ConexionBD
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();

        // Metodos CRUD (Create, Read, Update, Delete)
        public List<ClientesDto> VerRegistros(string Condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);
            Conexion.Open();

            LeerFilas = Comando.ExecuteReader();

            List<ClientesDto> ListaGenerica = new List<ClientesDto>();

            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClientesDto
                {
                    ID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellidos = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7)
                }); ;
            }

            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }

        public void Create() { }
        public void Update() { }
        public void Delete() { }
    }
}
