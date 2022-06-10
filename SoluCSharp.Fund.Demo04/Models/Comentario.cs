using System;
using System.Collections.Generic;

#nullable disable

namespace SoluCSharp.Fund.Demo04.Models
{
    public partial class Comentario
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public int LibroId { get; set; }
        public string UsuarioId { get; set; }

        public virtual Libro Libro { get; set; }
        public virtual AspNetUser Usuario { get; set; }
    }
}
