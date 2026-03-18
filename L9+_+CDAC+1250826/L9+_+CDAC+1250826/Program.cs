using System;
class Program
{
    // Función - Problema #1
    static int cantidadCaracteres(string a)
    {
        int caracteres = a.Length;
        return caracteres;
    }

    // Función - Problema #2
    static (int, int) cambioValores(ref int b, ref int c)
    {
        (b, c) = (c, b);
        return (b, c);
    }

    static void Main()
    {
        // Main - Problema #1
        Console.WriteLine("Ingrese un string a evaluar");
        string texto = Console.ReadLine()!;
        Console.WriteLine("Su string tiene " + cantidadCaracteres(texto) + " carácteres");

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Main - Problema #2
        Console.WriteLine("Ingrese el valor de su primera variable");
        string dato1 = Console.ReadLine()!;
        int variable1 = int.Parse(dato1);

        Console.WriteLine("Ingrese el valor de su segunda variable");
        string dato2 = Console.ReadLine()!;
        int variable2 = int.Parse(dato2);

        Console.WriteLine("El valor actual de las variables es de: " +
            "\n" + variable1 + " para la primera variable" +
            "\n" + variable2 + " para la segunda variable");
        cambioValores(ref variable1, ref variable2);
        Console.WriteLine("El valor después de haber cambiado los valores es de: " +
            "\n" + variable1 + " para la primera variable" +
            "\n" + variable2 + " para la segunda variable");
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();


    }
}