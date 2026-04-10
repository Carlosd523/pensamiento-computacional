using System;
class Program
{
    // Función - Ejercicio #1
    static int Sumatoria(int a)
    {
        int suma = 0;
        while (a > 0)
        {
            int digito = a % 10;
            suma += digito;
            a = a / 10;
        }
        return suma;
    }

    // Función - Ejercicio #2
    static string Correo(string b, string c, string d, string e)
    {
        string correo = "@correo.url.edu.gt";
        correo = correo.Insert(0, e.Substring(0,1));
        correo = correo.Insert(0, d);
        correo = correo.Insert(0, c.Substring(0,1));
        correo = correo.Insert(0, b.Substring(0,1));
        correo = correo.ToLower();
        return correo;
    }

    // Función - Ejercicio #3
    static string Conversion(string f, ref string g)
    {
        string temperatura = f.Substring(4);
        int temp = int.Parse(temperatura);
        temp = (temp * 9 / 5) + 32;
        string grados = temp.ToString();
        g = g.Insert(4, grados);

        return g;
    }

    // Funciones - Ejercicio #4
    // Función 4.1
    static int agregarPuntos(ref int h)
    {
        if(h <= 90)
        {
            h = h + 10;
        }else if(h < 100)
        {
            int unidad = h % 10;
            h = h + (10 - unidad);
        }
        return h;
    }

    // Función 4.2
    static int quitarPuntos(ref int i)
    {
        if(i >= 7)
        {
            i = i - 7;
        }
        else
        {
            i = i - i;
        }
        return i;
    }

    // Función 4.3
    static string obtenerNivel(int j)
    {
        string texto = "";
        if(j <= 49)
        {
            texto = "Básico";
            return texto;
        }else if(j <= 79)
        {
            texto = "Intermedio";
            return texto;
        }
        else
        {
            texto = "Avanzado";
            return texto;
        }
    }

    // Función 4.4
    static string evaluarEstado(int k)
    {
        string texto = "";
        if(k <= 69)
        {
            texto = "Reprobado";
            return texto;
        }else if(k <= 99)
        {
            texto = "Aprobado";
            return texto;
        }
        else
        {
            texto = "Excelente";
            return texto;
        }
    }
    static void Main()
    {
        int num = 0;
        // Ejercicio #1 - Suma de dígitos
        do
        {
            Console.WriteLine("Ingrese un número entero positivo");
            string dato1 = Console.ReadLine()!;
            num = int.Parse(dato1);

            if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡ERROR! Número no valido");
                Console.ResetColor();
            }
        } while (num < 0);

        Console.WriteLine("La suma de los dígitos del número que ingresó es: " + Sumatoria(num));
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Ejercicio #2 - Saldo y retiro
        Console.WriteLine("Para creaar su correo institucional siga las siguientes indicaciones");
        Console.WriteLine("Ingrese su primer nombre");
        string first_name = Console.ReadLine()!;
        Console.WriteLine("Ingrese su segundo nombre");
        string second_name = Console.ReadLine()!;
        Console.WriteLine("Ingrese su primer apellido");
        string first_last_name = Console.ReadLine()!;
        Console.WriteLine("Ingrese su segundo apellido");
        string second_last_name = Console.ReadLine()!;

        Console.WriteLine("Su correo institucional es: " + Correo(first_name, second_name, first_last_name, second_last_name));

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Ejercicio #3 - Conversión de temperatura
        string grados_fahrenheit = "F = ";
        string grados_celsius = "C = ";
        Console.WriteLine("Ingrese la temperatura en grados Celsius");
        string dato3 = Console.ReadLine()!;
        int celsius = int.Parse(dato3);
        string texto = celsius.ToString();
        grados_celsius = grados_celsius.Insert(4, texto);

        Console.WriteLine("A continuación se mostrará la temperatura en Fahrenheit" +
            "\n" + Conversion(grados_celsius, ref grados_fahrenheit));
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Ejercicio #4 - Sistema de puntos
        int opt_menu = 0;
        int puntos = 0;
        do
        {
            // Bloque 4.1 - Ingresar una opción
            do
            {
                Console.WriteLine("Ingrese qué desea hacer con los puntos del estudiante");
                Console.WriteLine("1. AGREGAR PUNTOS" +
                    "\n2. QUITAR PUNTOS" +
                    "\n3. OBTENER NIVEL" +
                    "\n4. EVALUAR ESTADO" +
                    "\n5. SALIR");
                string dato4 = Console.ReadLine()!;
                opt_menu = int.Parse(dato4);

                if(opt_menu < 1 || opt_menu > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡ERROR! Número no valido");
                    Console.ResetColor();
                }
            } while (opt_menu < 1 || opt_menu > 5);

            // Bloque 4.2 - Realizar función requerida
            switch (opt_menu)
            {
                case 1:
                    Console.WriteLine("Los puntos que el estudiante posee son: " + agregarPuntos(ref puntos));
                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Los puntos que posee el estudiante son de: " + quitarPuntos(ref puntos));
                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("El nivel del estudiante es: " + obtenerNivel(puntos));
                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("El estado del estudiante es: " + evaluarEstado(puntos));
                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        } while (opt_menu != 5);
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}