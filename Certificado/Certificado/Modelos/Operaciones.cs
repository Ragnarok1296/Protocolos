using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Certificado.Modelos
{
    public class Operaciones
    {
        MySQLConnection conn;

        public Operaciones()
        {
            conn = new MySQLConnection();
        }

        public Boolean insertarUsuario(Usuarios usuarios, Llaves llavePublica1, Llaves llavePublica2, Llaves certificador1, Llaves certificador2)
        {
            Boolean operacion = false;
            
            if (conn.connection())
            {
                string query = "Call agregarUsuario('" + usuarios.Nombre + "','" + usuarios.Apellidos + "','" + usuarios.Telefono
                + "','" + llavePublica1.Llave + "','" + llavePublica2.Llave + "','" + certificador1.Llave + "','" + certificador2.Llave + "');";

                if (conn.insertar_actualizar_eliminar(query))
                    operacion = true;

            }

            return operacion;
        }

        public String obtenerModulo(int id)
        {
            String modulo = "";

            if (conn.connection())
            {
                string query = "Call obtenerModulo('" + id + "');";

                modulo = conn.consulta_busqueda(query).Rows[0].ItemArray[0].ToString();

            }

            return modulo;
        }

        public DataTable obtenerLlavesEntidad(int id)
        {
            DataTable llaves = new DataTable();

            if (conn.connection())
            {
                string query = "Call obtenerLlavesEntidad('" + id + "');";

                llaves = conn.consulta_busqueda(query);

            }

            return llaves;
        }

    }
}