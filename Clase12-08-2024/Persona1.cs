using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_08_2024
{
    /*Interfaz---Suscribe un contrato con la clase que lo implementa, la clase en este paso Persona 1 esta OBLIGADA a implementar 
    los métodos absctractos de la colección
    */
    public class Persona1 : Mate, Operacion
    {
        public string nombre;
        /*Portected: Solo se puede adceder desde la clase que lo declara, en este caso, la clase Persona1*/
        protected int edad;
        public string definicion = "con el modificador de acceso publico puedo acceder desde cualquier parte del codigo";


        public Persona1(string nombre, int edad)
            /*metodo constructor == nombre de la clase
            /el metodo constructor se utiliza para inicializar los atributos de la clase
            cuando utilizo el constructo se activa el constructo vacio que tienen todas las clases po defcto

            /*/
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string Nombre
        {
            //get para recuperar un valor
            get { return nombre; }

            //ser para establecer un valor
            set { nombre = value; }

            //crear 2 atributos
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public void imprimirDatos()
        {
            Console.WriteLine($"Nombre_ {nombre} edad: {edad}");
        }

        public bool CalcularEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            return false;
        }
        ////////////////////////////////////////////////////////////////////////////////

        public void sumar()
        {
            int sumar = num1DelaClaseMate + num2DelaClaseMate;
            Console.WriteLine($"La suma es: {sumar}");
        }
        public int restar()
        {
            return = num1DelaClaseMate - num2DelaClaseMate;
            Console.WriteLine($"La resta es: {restar}");
        }


    }
}