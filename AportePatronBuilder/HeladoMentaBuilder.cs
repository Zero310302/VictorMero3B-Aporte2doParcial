using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class HeladoMentaBuilder : HeladoBuilder // Es una clase que implementa HeladoBuilder 
    {
        public HeladoMentaBuilder()
        {
            _descripcion = "Helado de Menta";
        }
        public override Chispas BuildChispas()
        {
            return new ChispasChocolate();
        }
        public override Galletas BuildGalletas()
        {
            return new GalletasMaria();
        }
        public override Jarabe BuildJarabe()
        {
            return new JarabeFresa();
        }
    }
}
