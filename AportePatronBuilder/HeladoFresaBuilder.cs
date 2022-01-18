using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class HeladoFresaBuilder : HeladoBuilder // Es una clase que implementa HeladoBuilder 
    {
        public HeladoFresaBuilder()
        {
            _descripcion = "Helado de Fresa";
        }
        public override Chispas BuildChispas()
        {
            return new ChispasMenta();
        }
        public override Galletas BuildGalletas()
        {
            return new GalletasVainilla();
        }
        public override Jarabe BuildJarabe()
        {
            return new JarabeVainilla();
        }
    }
}
