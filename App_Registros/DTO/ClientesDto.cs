using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Registros.DAO
{
    class ClientesDto
    {
        //Atributos
        int _ID;
        string _Nombre;
        string _Apellidos;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Ocupacion;


        //Propiedades Getters And Setters
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
    }
}
