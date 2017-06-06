using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Prestamos
    {
        [Key]
        public int idLibro { get; set; }

        [Key]
        public int idUsuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Observaciones { get; set; }

        public bool list()
        {
            bool flag = false;
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Libros.nomLibro,Usuarios.Nombre,Prestamos.Fecha,Prestamos.Observaciones from Usuarios INNER JOIN Prestamos ON Prestamos.idUsuario=Usuario.idUsuario INNER JOIN Libros ON Prestamos.idLibro=Libro.idLibro", conn);
                flag = Convert.ToBoolean(cmd.ExecuteScalar());
                return flag;

            }

        }
    }
}