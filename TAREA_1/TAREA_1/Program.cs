using System;
class Program
{
    static void limpiaPantalla()
    {
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }

    // Funciones - Ejercicio #2
    static bool EsAbierta(char a)
    {
        a = char.ToLower(a);
        return "aeoáéó".Contains(a);
    }
    static bool EsCerradaTonica(char a)
    {
        a = char.ToLower(a);
        return "íú".Contains(a);
    }
    static bool EsVocal(char a)
    {
        a = char.ToLower(a);
        return "aeiouáéíóú".Contains(a);
    }

    static bool EsHiato(char a, char b)
    {
        a = char.ToLower(a);
        b = char.ToLower(b);

        if(EsVocal(a) && EsVocal(b))
        {
            if ((EsAbierta(a) && EsAbierta(b)) ||
            (EsCerradaTonica(a) && EsAbierta(b)) ||
            (EsAbierta(a) && EsCerradaTonica(b)) ||
            a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    static bool TieneHiato(string a)
    {

        for (int i = 0; i < a.Length - 1; i++)
        {
            char x = a[i];
            char y = a[i + 1];

            if(EsHiato(x, y))
            {
                return true;
            }
        }
        return false;
    }
    static void Main()
    {
        // Ejercicio #1
        bool valido = false;
        double num = 0;

        while (!valido)
        {
            Console.WriteLine("Ingrese un número real");
            string salida = Console.ReadLine()!;

            if(double.TryParse(salida, out num))
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Ingrese un valor adecuado");
            }
        }

        double cuadrado = Math.Pow(num, 2);
        Console.WriteLine("La potencia cuadrada del número ingresado es: " + Math.Pow(num, 2));

        if(num >= 0)
        {
            Console.WriteLine("La raíz cuadrada del número es: " + Math.Sqrt(num));
        }
        else
        {
            Console.WriteLine("Los números negativos no tienen raíz cuadrada");
        }
        limpiaPantalla();

        // Ejercicio #2
        string palabra = "";
        bool valido1 = false;
        while (!valido1)
        {
            Console.WriteLine("Ingrese una palabra para determinar si es hiato");
            palabra = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(palabra))
            {
                Console.WriteLine("Ingrese una palabra");
            }
            else
            {
                valido1 = true;
            }
        }

        Console.WriteLine(TieneHiato(palabra));
        limpiaPantalla();

        // Ejercicio #3
        int indice = 0;
        string[] arreglo = { "Rojo", "Azul", "Amarrillo", "Verde", "Blanco", "Violeta", "Naranja" };
        bool valido2 = false;
        while (!valido2)
        {
            do
            {
                Console.WriteLine("Ingrese un número entre 0 y 9");
                string dato1 = Console.ReadLine()!;
                if (int.TryParse(dato1, out indice))
                {
                    if(indice < 0 || indice > 9)
                    {
                        Console.WriteLine("Ingrese un valor dentro del rango dado");
                    }
                    else
                    {
                        valido2 = true;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un valor adecuado");
                }
            } while (indice < 0 || indice > 9);
        }

        try
        {
            Console.WriteLine(arreglo[indice]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("No existe un color en esa posición");
        }
        limpiaPantalla();
    }
}