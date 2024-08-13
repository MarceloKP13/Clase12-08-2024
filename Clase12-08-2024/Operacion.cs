using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_08_2024
{
    public interface Operacion
    {
        /*Una intefaz es una coleccion de métodos abtractos que suscriben un contrato con la clase que lo implementa y la clase
         * que implementa la interfaz esta 'obligada'  a implementar los metodos abtractos 
         * Los metodo abstractos no tienen ningun implementación
         */

        void sumar();
        int restar();
    }
}
