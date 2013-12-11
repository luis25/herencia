
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
	
	public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string fechanac;

        public string Nombre
        {
         set{
            nombre = value;
            }
            get {
            return nombre;
            }
        }
         public string Apellido
        {
         set{
            apellido = value;
            }
            get {
            return apellido;
            }
        }
        public int Edad
        {
        set{
            edad = value;
            }
            get {
            return edad;
            }
        }
public string Fechanacimiento
        {
         set{
            fechanac= value;
            }
            get {
            return fechanac;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Apellido:"+ Apellido);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Fecha de nacimiento:"+ Fechanacimiento);
        }
    }
}