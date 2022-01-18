using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class HeladoChocolateBuilder : HeladoBuilder // Es una clase que implementa HeladoBuilder 
    {
        public HeladoChocolateBuilder()
        {
            _descripcion = "Helado de Chocolate";
        }
        public override Chispas BuildChispas()
        {
            return new ChispasCaramelo();
        }
        public override Galletas BuildGalletas()
        {
            return new GalletasOreo();
        }
        public override Jarabe BuildJarabe()
        {
            return new JarabeChocolate();
        }
    }
}
