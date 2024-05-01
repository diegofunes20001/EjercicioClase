using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperPoder
    {
        /// <summary>
        /// Nombre del superpoder
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Descripción del superpoder
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Nivel del superpoder (1-10)
        /// </summary>
        public int Nivel { get; set; }
        public override string ToString()
        {
            return $"{Nombre} - {Descripcion} - {Nivel}";
        }
      
        public void Imprimir() { }

       
    }
}
