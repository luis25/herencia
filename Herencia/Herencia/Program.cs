using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
		
	class Herencia1{
		
	public static void Main(string[] args)
		{
		Persona persona1 = new Persona();
            persona1.Nombre = "Olga";
            persona1.Apellido= "Salazar";
            persona1.Edad = 25;
            persona1.Fechanacimiento="21/08/1987";
            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Ana";
            empleado1.Apellido="Banuelos";
            empleado1.Edad= 21;
            empleado1.Sueldo = 2524;
            Console.WriteLine("\n\n\n\nLos datos del empleado son:");
            empleado1.Imprimir();

            Console.ReadKey();
		}
	}


}
