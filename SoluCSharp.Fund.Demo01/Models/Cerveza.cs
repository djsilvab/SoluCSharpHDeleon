using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluCSharp.Fund.Demo01.Models
{
    public class Cerveza
    {
        public Cerveza()
        {

        }

        public Cerveza(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public override string ToString()
        {
            return $"nombre: {Nombre}, cantidad: {Cantidad}";
        }
    }
}
