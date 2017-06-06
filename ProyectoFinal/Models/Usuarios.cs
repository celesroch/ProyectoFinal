using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DataLayer;

namespace ProyectoFinal.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage = "Intruduce un nombre")]
        [Display(Name = "NomUsuario")]
        public string NomUsuario { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        public bool checkUser(string nomUsuario, string password)
        {
            bool flag = false;
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count (*) from Usuarios where NomUsuario='" + nomUsuario + "' and Password='" + password + "'", conn);
                flag = Convert.ToBoolean(cmd.ExecuteScalar());
                return flag;
               
            }
            
        }


    }
}