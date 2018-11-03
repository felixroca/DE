using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE
{
    interface DE_IFormPedido
    {
        //Metodos a los que llamara la interface
        void ObtenerCalle(string calle);
        void ObtenerNumero(string numero);
        void ObtenerCiudad(string ciudad);
    }
}
