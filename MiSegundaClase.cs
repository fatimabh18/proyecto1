using System;

public class MiSegundaClase
{
    
    public string Mensaje { get; set; }
    public int NumeroEntrada { get; set; }

    public void Incrementar()
    {
      
        NumeroEntrada = NumeroEntrada + 1; // o poner numeroentrada++
    }
    public void ParoImpar()
    {
        if ((NumeroEntrada % 2 == 0))
        {
            Console.WriteLine("Es un número par");
        }
        else 
        {
            Console.WriteLine("Es un número impar");
        }
    }
    public void Escribir()
    {
        Console.WriteLine(Mensaje + NumeroEntrada.ToString());
        Mensaje = Console.ReadLine();
    }
}