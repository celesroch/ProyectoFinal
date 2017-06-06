using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Models
{
    public class ViewModel
    {
        private readonly List<Libros> _libros;

        [Display(Name = "Libro elegido")]
        public int SelectedBookId { get; set; }

        public IEnumerable<SelectList> librosItems
        {
            get {
                yield return new SelectList(_libros, "idLibro", "nomLibro");
            }
        }
    }
}