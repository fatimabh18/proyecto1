 using System;

namespace proyecto_consola
{
    class Program
    {
         static void Main(string[] args) // método principal
        {
           
           MiPrimeraClase objetoMiPrimeraClase = new MiPrimeraClase(); // instanciar la clase, se le asigna un valor
           objetoMiPrimeraClase.MyProperty = "Hola Mundo";
           objetoMiPrimeraClase.Ejecutar();  

           Console.WriteLine("Escribe desde Program" + objetoMiPrimeraClase.MensajeDeEntrada);
        }

    }
   
}
