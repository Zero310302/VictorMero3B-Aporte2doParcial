using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class Chispas // Se crea la clase Chispas y la descripcion e implementacion de cada uno de sus tipos
    {
        protected string _descripcion; 
        public string Descripcion { get { return _descripcion; } }
    }
    public class ChispasChocolate : Chispas 
    {
        public ChispasChocolate()
        {
            _descripcion = "Chispas de Chocolate";
        }
    }
    public class ChispasMenta : Chispas
    {
        public ChispasMenta()
        {
            _descripcion = "Chispas de Menta";
        }
    }
    public class ChispasCaramelo : Chispas
    {
        public ChispasCaramelo() 
        {
            _descripcion = "Chispas de caramelo";
        }
    }
}
