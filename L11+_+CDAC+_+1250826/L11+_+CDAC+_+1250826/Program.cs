using System;
class Program
{
    static void limpiaPantalla()
    {
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    // Funciones - Ejercicio #1
    static string palabraInversa(string a)
    {
        string palabra_inversa = "";
        for (int i = a.Length; i > 0; i--)
        {
            palabra_inversa = palabra_inversa + a[i - 1];
        }
        return palabra_inversa;
    }
    static Boolean palindromo(string a, string b)
    {
        if(a.ToLower() == b.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Funciones - Ejercicio #2
    static string capitalizacion(string texto)
    {
        texto = texto.Trim();
        return texto.Substring(0, 1).ToUpper() + texto.Substring(1);
    }
    static void Main()
    {
        // Ejercicio #1
        Console.WriteLine("Ingrese una palabra");
        string palabra = Console.ReadLine()!;
        Console.WriteLine(palindromo(palabra, palabraInversa(palabra)));

        limpiaPantalla();

        // Ejercicio #2
        Console.WriteLine("BIENVENIDO AL TRADUCTOR DE TRES IDIOMAS");
        int opt_menu = 0;
        string[] spanish = { "rojo", "azul", "amarillo", "blanco", "verde"};
        string[] english = { "red", "blue", "yellow", "white", "green" };
        string[] italian = { "rosso", "blu", "giallo", "bianco", "verde" };

        do
        {
            do
            {
                Console.WriteLine("SELECCIONE LA OPCIÓN QUE DESEE" +
                "\n1. PRACTICAR LECCIÓN" +
                "\n2. TERMINAR LECCIÓN");
                string dato1 = Console.ReadLine()!;
                opt_menu = int.Parse(dato1);

                if(opt_menu < 1 || opt_menu > 2)
                {
                    Console.WriteLine("NÚMERO INVÁLIDO, INGRESAR OTRO VALOR");
                }
            } while (opt_menu < 1 || opt_menu > 2);

            if(opt_menu == 1)
            {
                Console.WriteLine("Ingrese un color en español");
                string color = Console.ReadLine()!;
                for(int i = 0; i < 5; i++)
                {
                    if(color.ToLower() == spanish[i])
                    {
                        Console.WriteLine(capitalizacion(spanish[i]) + ", " + capitalizacion(english[i]) + ", " + capitalizacion(italian[i]));
                        break;
                    }else if(color.ToLower() != spanish[i] && i == 4)
                    {
                        Console.WriteLine("La palabra no corresponde a la lección actual.");
                    }
                }

                limpiaPantalla();
            }
        } while (opt_menu != 2);

        limpiaPantalla();
    }
}