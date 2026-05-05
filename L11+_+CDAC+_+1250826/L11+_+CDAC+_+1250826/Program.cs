using System;
class Program
{
    // Funciones - Generales
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

    //Funciones - Ejercicio #4
    static void salarios(string[] a, double[] b, double[] c)
    {
        Console.WriteLine("Estos son los salarios a los que se les debe de pagar cada trabajador:");
        for(int i = 0; i < 6; i++)
        {
            double salario = 0;
            if (c[i] <= 40)
            {
                salario = b[i] * c[i];
            }
            else
            {
                double horas_extra = c[i] - 40;
                salario = (b[i] * 40) + (b[i] * horas_extra * 1.5);
            }
            Console.WriteLine(a[i] + ": Q" + salario.ToString("F2"));
            salario = 0;
        }
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

        // Ejercicio #3
        int[] aleatorio = new int[10];
        for(int i = 0; i < 10; i++)
        {
            Random rnd = new Random();
            aleatorio[i] = rnd.Next(50, 101);
        }
        do
        {
            do
            {
                Console.WriteLine("SELECCIONE LA OPCIÓN QUE DESEE" +
                "\n1. REPORTE DE RENDIMIENTO" +
                "\n2. ESTADÍSTICAS" +
                "\n3. SALIR");
                string dato1 = Console.ReadLine()!;
                opt_menu = int.Parse(dato1);

                if (opt_menu < 1 || opt_menu > 3)
                {
                    Console.WriteLine("NÚMERO INVÁLIDO, INGRESAR OTRO VALOR");
                }
            } while (opt_menu < 1 || opt_menu > 3);

            switch (opt_menu)
            {
                case 1:
                    Console.WriteLine("Los números son los siguientes");
                    for (int i = 0; i < 10; i++)
                    {
                        if (aleatorio[i] >= 50 && aleatorio[i] <= 64)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(aleatorio[i]);
                            Console.ResetColor();
                        }else if (aleatorio[i] > 64 && aleatorio[i] <= 79)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(aleatorio[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(aleatorio[i]);
                            Console.ResetColor();
                        }
                    }
                    limpiaPantalla();
                    break;
                case 2:
                    double suma = 0;
                    int num_mayor = aleatorio[0];
                    int num_menor = aleatorio[0];
                    for (int i = 0; i < 10; i++)
                    {
                        suma += aleatorio[i];
                        if (aleatorio[i] > num_mayor)
                        {
                            num_mayor = aleatorio[i];
                        }else if (aleatorio[i] < num_menor)
                        {
                            num_menor = aleatorio[i];
                        }
                    }
                    double promedio = suma / 10;
                    Console.WriteLine("El promedio es: " + promedio +
                        "\nEl número mayor es: " + num_mayor +
                        "\nEl número menor es: " + num_menor);
                    limpiaPantalla();
                    break;
            }
        } while (opt_menu != 3);
        limpiaPantalla();

        // Ejercicio #4
        string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
        double[] horas_trabajador = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
        double[] horas_trabajadas = new double[6];

        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine("Ingrese las horas laburadas del trabajador");
            string dato2 = Console.ReadLine()!;
            int horas = int.Parse(dato2);

            horas_trabajadas[i] = horas;
        }
        salarios(nombres, horas_trabajador, horas_trabajadas);
        limpiaPantalla();
    }
}