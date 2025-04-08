using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hilo principal iniciado");

        // Crear dos hilos que ejecutarán el método Contar
        Thread hilo1 = new Thread(Contar);
        Thread hilo2 = new Thread(Contar);
        Thread hilo3 = new Thread(Contar);
        Thread hilo4 = new Thread(Contar);
        Thread hilo5 = new Thread(Contar); //agregue otro hilo que es el hilo 5
        // Iniciar los hilos y pasarles un nombre como argumento
        hilo1.Start("Hilo 1");
        hilo2.Start("Hilo 2");
        hilo3.Start("Hilo 3");
        hilo4.Start("Hilo 4");


        // Esperar a que ambos hilos terminen antes de continuar
        hilo1.Join();
        hilo2.Join();
        hilo3.Join();
        hilo4.Join();

        Console.WriteLine("Hilo principal finalizado");
    }

    // Método que ejecutará cada hilo
    static void Contar(object nombre)
    {
        Console.WriteLine($"{nombre} iniciado");

        // Bucle que cuenta del 1 al 5 con pausas de 300 ms entre cada número
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{nombre}: {i}");
            Thread.Sleep(300); // Simula trabajo con una pausa de 300 ms
        }

        Console.WriteLine($"{nombre} finalizado");
    }
}
