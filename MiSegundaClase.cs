using System;

public class MiSegundaClase
{
    
    public string Mensaje { get; set; }
    public int NumeroEntrada { get; set; }

    public void Incrementar()
    {
      
        NumeroEntrada = NumeroEntrada + 1; // o poner numeroentrada++
    }
    public void IncrementarCinco() 
    {
        
        for (int incremento = 1; incremento < 5; incremento++)
        {
            NumeroEntrada++;
            Console.WriteLine(NumeroEntrada);
        }
    }    
    public void AlejarDelCero()
    {
        if (NumeroEntrada >= 0) // si es positivo lo incremento
        {
            NumeroEntrada++;
        }
        // dejar el 0 en el medio, si es 0 no hace nada
        else if (NumeroEntrada < 0) // y si no lo decremento
        {
            NumeroEntrada--;
        }
    }
    public void PitnarLetras()
    {
        for(int i = 0; i < Mensaje.Length; i++)
        {
            Console.WriteLine(Mensaje[i]);
        }
        
    }
    
    public void Escribir()
    {
        if (String.IsNullOrEmpty(Mensaje)) //si el mensaje está vacio se sale
        {
            return; 
        }
        Console.WriteLine(Mensaje + NumeroEntrada.ToString());
        Mensaje = Console.ReadLine();
    }
}