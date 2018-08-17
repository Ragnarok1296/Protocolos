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

        public DataTable obtenerLlavesPublica(string telefono)
        {
            DataTable llaves = new DataTable();

            if (conn.connection())
            {
                string query = "Call obtenerLlavePublica('" + telefono + "');";

                llaves = conn.consulta_busqueda(query);

            }

            return llaves;
        }

    }
}