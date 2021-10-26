using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_animales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Animal gato1 = new Animal("Batman",3);
            respuesta1.Text = "Nombre: " + gato1.NombreA + ", Edad: " + gato1.EdadA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            herbívoro herv1 = new herbívoro(null, null, 15);

            carnívoro carn1 = new carnívoro("carne porcina", "leon", 3);
            if (tipoAnimal.Text == "Herbivoro")//clasifica y asigna valores segun el tipo de animal seleccionado
            {
                herv1.setTipoComida("pazto");
                herv1.NombreA = nombreA.Text;
                herv1.EdadA = Int32.Parse(edadA.Text);
                respuesta1.Text = "Nombre: " + herv1.NombreA + ", Edad: " + herv1.EdadA + " Tipo comida: " + herv1.getTipoComida();
            }
            else
            {
                if(tipoAnimal.Text == "Carnivoro")
                {
                    carn1.NombreA = nombreA.Text;
                    carn1.EdadA = Int32.Parse(edadA.Text);
                    respuesta1.Text = "Nombre: " + carn1.NombreA + ", Edad: " + carn1.EdadA + " Tipo comida: " + carn1.getTipoCarne();
                }
            }

            if(metodoA.Text == "Comer")//proceso para ejecutar el metodo comerAnimal
            {
                if (tipoAnimal.Text == "Herbivoro")//clasifica y asigna valores segun el tipo de animal seleccionado
                {
                    respuesta2.Text = herv1.comerAnimal();//accediendo a la funcion mediante re-escritura por override en clases virtuales
                }
                else
                {
                    if (tipoAnimal.Text == "Carnivoro")
                    {
                        respuesta2.Text = carn1.comerAnimal();
                    }
                }
            }
            else
            {
                if (metodoA.Text == "Caminar")//proceso para ejecutar el metodo caminarAnimal
                {
                    llamar objLlamar = new llamar();
                    if (tipoAnimal.Text == "Herbivoro")//clasifica y asigna valores segun el tipo de animal seleccionado
                    {
                        respuesta2.Text = objLlamar.seleccionDesicion(herv1);//segun la subclase heradada, la clase padre selecciona ejecuta la instanciada
                    }
                    else
                    {
                        if(tipoAnimal.Text == "Carnivoro")
                        {
                            respuesta2.Text = objLlamar.seleccionDesicion(carn1);
                        }
                    }
                }
                else
                {
                    respuesta2.Text = herv1.noComo();
                }
            }
        }

        private void buscarA_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
