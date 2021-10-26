using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_animales
{
    class llamar
    {
        public string seleccionDesicion(Animal objA)//funcion que recibe como parametro el objeto animal
        {
            return objA.caminarAnimal();//gracias a Virtual se ejecuta la funcion caminar correcta segun la informacion del objeto heredado creado
        }
    }
}
