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

    // Funciones - Problema #4
    static int recibirDaño(ref int puntosSalud)
    {
        if(puntosSalud - 5 >= 0)
        {
            puntosSalud = puntosSalud - 5;
        }
        else
        {
            puntosSalud = puntosSalud - puntosSalud;
        }
        return puntosSalud;
    }

    static int curar(ref int puntosSalud)
    {
        if(puntosSalud + 3 <= 15)
        {
            puntosSalud = puntosSalud + 3;
        }
        else
        {
            puntosSalud = puntosSalud + (15 - puntosSalud);
        }
        return puntosSalud;
    }

    static void mostrarSalud(int puntosSalud)
    {
        if(puntosSalud <= 5 && puntosSalud >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Su salud es de " + puntosSalud + "pts");
            Console.ResetColor();
        }else if(puntosSalud > 5 && puntosSalud <= 10)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Su salud es de " + puntosSalud + "pts");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Su salud es de " + puntosSalud + "pts");
            Console.ResetColor();
        }
        return;
    }

    static string calificarDesempeño(int puntosSalud)
    {
        if(puntosSalud >= 0 && puntosSalud <= 5)
        {
            return "C";
        }else if(puntosSalud > 5 && puntosSalud <= 10)
        {
            return "B";
        }else if(puntosSalud > 10 && puntosSalud <= 14)
        {
            return "A";
        }
        else
        {
            return "S";
        }
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

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();

        Console.WriteLine("El valor después de haber cambiado los valores es de: " +
            "\n" + variable1 + " para la primera variable" +
            "\n" + variable2 + " para la segunda variable");
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Main - Problema #3
        Console.WriteLine("BIENVENIDO A ANGULO'S CINEMA");
        Console.WriteLine("El precio por boleto es de Q50.00");
        double precio = 50;
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
            descuento -= 0.15;
        }

        int membresia = 0;

        do
        {
            Console.WriteLine("¿Usted tiene membresía premium? 0 = No / 1 = Sí");
            string dato6 = Console.ReadLine()!;
            membresia = int.Parse(dato6);
        } while (membresia < 0 || membresia > 1);

        if(membresia == 1)
        {
            Console.WriteLine("Usted tiene descuento del 20%");
            descuento -= 0.9;
        }

        Console.WriteLine("El valor actual de su boleto es: Q." + precio);
        Console.WriteLine("El valor final de su boleto es: Q." + descuentoBoleto(descuento, ref precio));

        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();

        // Main - Problema #4

        int vida = 15;
        int opcion = 0;

        Console.WriteLine("BIENVENIDO A ANGULO'S GAME");
        do
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Decida qué hará durante el día" +
                "\n" + "1 = Comer algo" +
                "\n" + "2 = Luchar contra mounstros" +
                "\n" + "3 = Mostrar estadísticas" +
                "\n" + "4 = Salir del juego");
                Console.ResetColor();
                string dato7 = Console.ReadLine()!;
                opcion = int.Parse(dato7);

                if (opcion < 1 || opcion > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, ingrese un número válido");
                    Console.ResetColor();
                }
            } while (opcion < 1 || opcion > 4);

            switch (opcion)
            {
                case 1:
                    if(vida == 15)
                    {
                        Console.WriteLine("Salud al máximo");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    Console.WriteLine("Ha comido una manzana");
                    Console.WriteLine("Su salud ha aumentado");
                    curar(ref vida);

                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    if(vida == 0)
                    {
                        Console.WriteLine("No puede luchar contra mounstros actualmente");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    Console.WriteLine("Ha luchado contra 10 bokoblins");
                    Console.WriteLine("Su salud ha disminuido");
                    recibirDaño(ref vida);

                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("A continuación se mostrarán sus estadísticas");
                    mostrarSalud(vida);

                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        } while (opcion != 4);
        Console.WriteLine("Muchas gracias por haber jugado" +
            "\n" + "Su desempeño fue " + calificarDesempeño(vida));
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}