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
    static double Retiro(ref double b, double c)
    {
        double monto = b;
        if(b > c)
        {
            monto = b - c;
        }
        return monto;
    }

    // Función - Ejercicio #3
    static int Conversion(int d, ref int e)
    {
        e = (d * 9 / 5) + 32;
        return e;
    }

    // Funciones - Ejercicio #4
    // Función 4.1
    static int agregarPuntos(ref int f)
    {
        if(f <= 90)
        {
            f = f + 10;
        }else if(f < 100)
        {
            int unidad = f % 10;
            f = f + (10 - unidad);
        }
        return f;
    }

    // Función 4.2
    static int quitarPuntos(ref int g)
    {
        if(g >= 7)
        {
            g = g - 7;
        }
        else
        {
            g = g - g;
        }
        return g;
    }

    // Función 4.3
    static string obtenerNivel(int h)
    {
        string texto = "";
        if(h <= 49)
        {
            texto = "Básico";
            return texto;
        }else if(h <= 79)
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
    static string evaluarEstado(int i)
    {
        string texto = "";
        if(i <= 69)
        {
            texto = "Reprobado";
            return texto;
        }else if(i <= 99)
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
        double saldo = 10000.00;
        Console.WriteLine("Su saldo actualmente es de: " + saldo);
        double retiro = 0;
        do
        {
            Console.WriteLine("Ingrese la cantidad de dinero que desea retirar");
            string dato2 = Console.ReadLine()!;
            retiro = double.Parse(dato2);

            if(retiro < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡ERROR! Número no valido");
                Console.ResetColor();
            }
        } while (retiro < 0);

        Console.WriteLine("Su saldo actual es de: " + Retiro(ref saldo, retiro));
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Ejercicio #3 - Conversión de temperatura
        Console.WriteLine("Ingrese la temperatura en grados Celsius");
        string dato3 = Console.ReadLine()!;
        int grados_celsius = int.Parse(dato3);
        int grados_fahrenheit = 0;

        Console.WriteLine("La temperatura en grados Fahrenheit es de: " + Conversion(grados_celsius, ref grados_fahrenheit));
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
                    "\n 2. QUITAR PUNTOS" +
                    "\n 3. OBTENER NIVEL" +
                    "\n 4. EVALUAR ESTADO" +
                    "\n 5. SALIR");
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