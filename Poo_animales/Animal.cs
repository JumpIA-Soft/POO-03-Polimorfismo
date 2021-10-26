using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_animales
{
    class Animal
    {
        public string nombreA;
        private int edadA;

        //constructores
        public Animal(string nombreA, int edadA)//NombreA
        {//usar el mismo nombre de la variable con this
            this.nombreA = nombreA;
            this.edadA = edadA;
        }

        //propiedades de acceso a los atributos
        public int EdadA
        {
            get { return edadA; }
            set { edadA = value; }
        }

        public string NombreA
        {
            get { return nombreA; }
            set { nombreA = value; }
        }
        //polimorfismo virtual
        public virtual string comerAnimal()
        {
            return "Como comida";
        }
        public virtual string caminarAnimal()
        {
            return "clase padre";
        }
    }
}
