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

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

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

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

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

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Problema 4 - Solicitar un número y elegir una opción

        int option_menu;
        Console.WriteLine("Por favor ingrese un número");
        string? dato2 = Console.ReadLine();
        int num2 = int.Parse(dato2!);

        Console.WriteLine("Seleccione una opción:" +
            "\n 1: Mostrar los números desde el número ingresado hasta 1" +
            "\n 2: Mostrar los múltiplos de 3 hasta el número ingresado" +
            "\n 3: Mostrar los múltiplos de 5 hasta el número ingresado");

        do
        {
            Console.WriteLine("Ingrese la opción que quiera");
            string? option = Console.ReadLine();
            option_menu = int.Parse(option!);

            if(option_menu < 1 || option_menu > 3)
            {
                Console.WriteLine("Por favor ingrese un número válido");
            }
        } while (option_menu < 1 || option_menu > 3);

        switch (option_menu)
        {
            case 1:
                for(int i = num2; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                break;

            case 2:
                for(int i = 1; i <= num2; i++)
                {
                    if(i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;

            case 3:
                for(int i = 1; i <= num2; i++)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
        }

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        //Problema 5 - Triángulo de asteriscos

        Console.WriteLine("Ingrese el número de filas que quiera imprimir en el triángulo de asteriscos");
        string? dato3 = Console.ReadLine();
        int filas = int.Parse(dato3!);

        string asterisco = "*";

        for(int i = 1; i <= filas; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(asterisco);
            }
            Console.WriteLine();
        }
    }
}