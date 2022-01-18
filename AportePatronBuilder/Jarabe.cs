using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class Jarabe // Se crea la clase Jarabe y la descripcion e implementacion de cada uno de sus tipos
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class JarabeChocolate : Jarabe
    {
        public JarabeChocolate()
        {
            _descripcion = "Jarabe de Chocolate";
        }
    }
    public class JarabeVainilla : Jarabe
    {
        public JarabeVainilla()
        {
            _descripcion = "Jarabe de Vainilla";
        }
    }
    public class JarabeFresa : Jarabe
    {
        public JarabeFresa()
        {
            _descripcion = "Jarabe de Fresa";
        }
    }
}
