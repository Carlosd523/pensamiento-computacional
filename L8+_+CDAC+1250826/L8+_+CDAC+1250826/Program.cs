using System;
class Program
{
    static void Main()
    {
        // Problema #1 - Solicitar 20 números. Identificar el mayor, el menor y el promedio de los números
        int num;
        int num_menor = 0;
        int num_mayor = 0;
        double sumatoria = 0;

        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingrese un número");
            string? dato = Console.ReadLine();
            num = int.Parse(dato!);

            sumatoria += num;

            if(i == 0)
            {
                num_menor = num;
                num_mayor = num;
            }else if(num < num_menor)
            {
                num_menor = num;
            }else if(num > num_mayor)
            {
                num_mayor = num;
            }
        }

        double promedio = sumatoria / 20;

        Console.WriteLine("El número más grande es " + num_mayor);
        Console.WriteLine("El número más pequeño es " + num_menor);
        Console.WriteLine("El promedio de todos los números es de " + promedio);

        // Problema #2 - Números del 1 -100, múltiplos de 2, 7 y ambos

        for(int i = 1; i <= 100; i++)
        {
            int numero = i;

            if(numero % 2 == 0 && numero % 7 == 0)
            {
                Console.WriteLine("ParSiete");
            }else if(numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }else if(numero % 7 == 0)
            {
                Console.WriteLine("Siete");
            }
        }

        // Problema #3 - Compras de un cliente

        int compra = 0;
        double cobro = 0;
        double total = 0;
        int contador = 0;

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese el total de su compra");
            string? dato = Console.ReadLine();
            compra = int.Parse(dato!);

            if(compra > 700)
            {
                cobro = compra * 0.88;
                contador++;
            }else if(compra > 300)
            {
                cobro = compra * 0.95;
                contador++;
            }
            else
            {
                cobro = compra;
            }
            Console.WriteLine("El cliente pagó Q." + cobro);
            total += cobro;
        }

        Console.WriteLine(contador + " personas recibiberon descuento");
        Console.WriteLine("El total recaudado es de " + total);
    }
}