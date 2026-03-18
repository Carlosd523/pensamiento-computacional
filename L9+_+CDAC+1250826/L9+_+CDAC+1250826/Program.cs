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

    // Función - Problema #3
    static double descuentoBoleto(double d, ref double e)
    {
        e = e * d;
        return e;
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

        // Main - Problema #3
        Console.WriteLine("BIENVENIDO A ANGULO'S CINEMA");
        Console.WriteLine("Ingrese el precio del boleto");
        string dato3 = Console.ReadLine()!;
        double precio = double.Parse(dato3);
        int edad = 0;

        do
        {
            Console.WriteLine("Ingrese su edad");
            string dato4 = Console.ReadLine()!;
            edad = int.Parse(dato4);

            if(edad < 0)
            {
                Console.WriteLine("Ingrese una edad válida");
            }
        } while (edad < 0);

        double descuento = 1;

        if(edad < 18)
        {
            Console.WriteLine("Usted tiene descuento del 5% por ser niño");
            descuento -= 0.05;
        }else if(edad >= 65)
        {
            Console.WriteLine("Usted tiene descuento del 10% por ser adulto mayor");
            descuento -= 0.1;
        }

        int membresia = 0;

        do
        {
            Console.WriteLine("¿Usted tiene membresía premium? 0 = No / 1 = Sí");
            string dato5 = Console.ReadLine()!;
            membresia = int.Parse(dato5);
        } while (membresia < 0 || membresia > 1);

        if(membresia == 1)
        {
            Console.WriteLine("Usted tiene descuento del 20%");
            descuento -= 0.2;
        }

        Console.WriteLine("El valor actual de su boleto es: Q." + precio);
        Console.WriteLine("El valor final de su boleto es: Q." + descuentoBoleto(descuento, ref precio));

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}