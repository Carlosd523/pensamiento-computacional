using System;
class Program
{
    static void Main()
    {
        // Problema #1 - Mostrar números del 1 al 20
        string nombre = ("Carlos Daniel Angulo Campos");
        int carnet = 1250826;
        int indice = 1;

        Console.WriteLine("Nombre: ", nombre, " Carnet: ", carnet.ToString());

        while(indice <= 20)
        {
            if(indice % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            // Salida de datos - Números del 1 al 20
            Console.WriteLine(indice);
            indice++;
        }
        Console.ForegroundColor = ConsoleColor.White;

        // Problema #2 - Determinar los divisores positivos de un número

        // Entrada de datos - Número entero
        Console.WriteLine("Ingrese un número entero positivo");
        string? numero = Console.ReadLine();
        int entero = int.Parse(numero!);
        int divisor = entero;

        do
        {
            if(entero % divisor == 0)
            {
                // Salida de datos - Divisores
                Console.WriteLine(divisor);
            }
            divisor--;
        } while (divisor > 0);

        // Problema #3 - Serie de Fibonacci

        // Entrada de datos - Número n
        Console.WriteLine("Ingrese n cantidad de números que desee ver de la serie de Fibonacci");
        string? num = Console.ReadLine();
        int n = int.Parse(num!);
        int num1 = 0;
        int num2 = 1;

        // Salida de datos - Parte #1
        Console.WriteLine(num1);
        Console.WriteLine(num2);

        int operaciones = n - 2;

        for(int i = 0; i < operaciones; i++)
        {
            // Salida de datos - Parte #2
            int resultado = num1 + num2;
            Console.WriteLine(resultado);
            num1 = num2;
            num2 = resultado;
        }

        // Problema #4 - Tablas de multiplicar

        for(int i = 1; i <= 12; i++)
        {
            int factor_1 = i;
            Console.WriteLine("Tabla del " + factor_1.ToString());
            for(int j = 1; j <= 10; j++)
            {
                int factor_2 = j;
                int result = factor_1 * factor_2;
                Console.WriteLine(factor_1.ToString() + " x " + factor_2.ToString() + " = " + result.ToString());
            }
        }
    }
}