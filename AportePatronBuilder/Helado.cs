using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePatronBuilder
{
    public class Helado // Se crea la clase concreta que va a tener relacion con chispas, galletas y jarabe
    {
        Chispas _chispas;
        Galletas _galletas;
        Jarabe _jarabe;
        string _tipo;
        public override string ToString() // Esto es para poder observar el codigo
        {
            return $"{_tipo}, Chispas: {_chispas.Descripcion}, Galletas: {_galletas.Descripcion}, Jarabe: {_jarabe.Descripcion}";
        }
        public Helado(Chispas chispas, Galletas galletas, Jarabe jarabe, string tipo) // Se crear el constructor que recibe los respectivos parametros
        {
            _chispas = chispas;
            _galletas = galletas;
            _jarabe = jarabe;
            _tipo = tipo;
        }
    }
}
