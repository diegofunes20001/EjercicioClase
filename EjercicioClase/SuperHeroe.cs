using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe : SuperPoder
    {

        /// <summary>
        /// Nombre del superhéroe
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Identidad secreta del superhéroe
        /// </summary>
        public string IdentidadSecreta { get; set; }

        /// <summary>
        /// Ciudad donde opera el superhéroe
        /// </summary>
        public string Ciudad { get; set; }

        /// <summary>
        /// Indica si el superhéroe puede volar
        /// </summary>
        public bool PuedeVolar { get; set; }

        /// <summary>
        /// Superpoder del superhéroe
        /// </summary>
        public SuperPoder SuperPoder { get; set; } 

        public override string ToString()
        {
            return $"Nombre: {Nombre} Identidad Secreta:{IdentidadSecreta} Ciudad:{Ciudad} PuedeVolar:{PuedeVolar} Super Poder:{SuperPoder}";
        }

        /// <summary>
        /// Imprimir de Sobrehumana
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine($"Nombre:",Nombre);
            Console.WriteLine($"Identidad Secreta:",IdentidadSecreta);
            Console.WriteLine($"Ciudad:",Ciudad);
            Console.WriteLine($"Puede Volar:",PuedeVolar);
            Console.WriteLine($"Super Poder:",SuperPoder) ;
            Console.WriteLine($"Descripcion:",Descripcion);
            Console.WriteLine($"Nivel:",Nivel);
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
