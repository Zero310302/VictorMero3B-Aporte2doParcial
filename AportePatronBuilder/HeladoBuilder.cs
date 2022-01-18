using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public abstract class HeladoBuilder // Se crea la clase abstracta HeladoBuilder que permite las operaciones del patron Builder
    {
        protected string _descripcion;
        public abstract Chispas BuildChispas(); // Define que tipo de chispas genera
        public abstract Galletas BuildGalletas(); // Define que tipo de galletas genera
        public abstract Jarabe BuildJarabe(); // Define que tipo de jarabe genera
        public override string ToString() // Es para observar el codigo
        {
            return _descripcion;
        }
        public Helado BuildHelado() // Esta es una operacion concreta que es la que genera chispas, galletas y jarabe
        {
            Chispas chispas = BuildChispas();
            Galletas galletas = BuildGalletas();
            Jarabe jarabe = BuildJarabe();

            return new Helado(chispas, galletas, jarabe, _descripcion);
        }
    }
}
