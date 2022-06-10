using System;
using System.Collections.Generic;

#nullable disable

namespace SoluCSharp.Fund.Demo04.Models
{
    public partial class AutoresLibro
    {
        public int LibroId { get; set; }
        public int AutorId { get; set; }
        public int Orden { get; set; }

        public virtual Autore Autor { get; set; }
        public virtual Libro Libro { get; set; }
    }
}
