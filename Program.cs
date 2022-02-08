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
           

           MiSegundaClase objetoMiSegundaClase = new MiSegundaClase();
           Console.WriteLine("Escriba un número");
           objetoMiSegundaClase.NumeroEntrada = Int32.Parse(Console.ReadLine());
           objetoMiSegundaClase.Incrementar();
           objetoMiSegundaClase.ParoImpar();
           objetoMiSegundaClase.Mensaje = "El resultado es ";
           objetoMiSegundaClase.Escribir();
           
        }

    }
   
}
