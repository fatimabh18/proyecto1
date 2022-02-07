 using System;
 public class MiPrimeraClase
    {
        public string MyProperty { get; set; } // crear una propiedad, get la puedo leer, set la puedo escribir
        public string MensajeDeEntrada { get; set; }
        public void Ejecutar()
        {
              Console.WriteLine(MyProperty);
              MensajeDeEntrada = Console.ReadLine();
              Console.WriteLine(MyProperty + MensajeDeEntrada);
        }

    }