using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Controllers
{
    public class Contexto:DbContext
    {
        public DbSet <Libros> Libros { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

    }
}