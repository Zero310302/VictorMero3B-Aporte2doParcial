using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class Galletas // Se crea la clase Galletas y la descripcion e implementacion de cada uno de sus tipos
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class GalletasVainilla : Galletas
    {
        public GalletasVainilla()
        {
            _descripcion = "Galletas de Vainilla";
        }
    }
    public class GalletasOreo : Galletas
    {
        public GalletasOreo()
        {
            _descripcion = "Galletas Oreo";
        }
    }
    public class GalletasMaria : Galletas
    {
        public GalletasMaria()
        {
            _descripcion = "Galletas Maria";
        }
    }
}
