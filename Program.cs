 using System;

namespace proyecto_consola
{
    class Program
    {
        static void Main(string[] args) // método principal
        {
           string mensaje2 ="";
           Console.WriteLine("Introduzca un texto");
           mensaje2= Console.ReadLine();
           string mensajedesalida ="";
           Console.WriteLine("Introduzca un texto");
           mensajedesalida = Console.ReadLine();
           
           bool resultado = mensaje2.Equals(mensajedesalida);
           Console.WriteLine(resultado);
           Console.ReadLine();
           
           
         
           
           
        
       }

    }
}
