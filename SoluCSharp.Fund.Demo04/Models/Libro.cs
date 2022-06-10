using System;
using System.Collections.Generic;

#nullable disable

namespace SoluCSharp.Fund.Demo04.Models
{
    public partial class Libro
    {
        public Libro()
        {
            AutoresLibros = new HashSet<AutoresLibro>();
            Comentarios = new HashSet<Comentario>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }

        public virtual ICollection<AutoresLibro> AutoresLibros { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}
