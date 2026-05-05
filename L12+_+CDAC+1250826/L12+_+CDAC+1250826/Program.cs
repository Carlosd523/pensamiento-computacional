using System;
class Program
{
    // Subprocesos Generales
    static void limpiaPantalla()
    {
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }

    // Subprocesos - Ejercicio #1
    // Procedimiento #1
    static void llenarMatriz(int[,] a, int b, int c)
    {
        for(int i = 0; i < b; i++)
        {
            for(int j = 0; j < c; j++)
            {
                Console.WriteLine("Ingrese un número");
                string dato1 = Console.ReadLine()!;
                int num = int.Parse(dato1);
                a[i, j] = num;
            }
        }
    }

    // Función #1
    static int diagonalPrincipal(int[,] a)
    {
        int suma = 0;
        for(int i = 0; i < a.GetLength(0); i++)
        {
            suma += a[i, i];
        }
        return suma;
    }

    // Función #2
    static int diagonalSecundaria(int[,] a)
    {
        int suma = 0;
        for(int i = 0; i < a.GetLength(0); i++)
        {
            suma += a[i, a.GetLength(0) - 1 - i];
        }
        return suma;
    }

    // Subprocesos - Ejercicio #2

    // Función #1
    static int contadorPares(int[,] a)
    {
        int pares = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i,j] % 2 == 0)
                {
                    pares++;
                }
            }
        }
        return pares;
    }

    // Función #2
    static int contadorImpares(int[,] a)
    {
        int impares = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] % 2 != 0)
                {
                    impares++;
                }
            }
        }
        return impares;
    }

    // Subprocesos - Ejercicio #3
    // Procedimiento #1
    static void ingresarNotas(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.WriteLine("Ingrese la nota del estudiante");
                string dato1 = Console.ReadLine()!;
                int num = int.Parse(dato1);
                a[i, j] = num;
            }
        }
    }

    // Función #1
    static double promedioEstudiante(int[,] a, int b)
    {
        double suma = 0;
        for (int i = 0; i < a.GetLength(1); i++)
        {
            suma += a[b, i];
        }
        double promedio = suma / 4;
        return promedio;
    }

    // Función #2
    static bool estudianteAprueba(double a)
    {
        if(a >= 61)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Subprocesos - Ejercicio #4

    // Función #1
    static bool matrizSimetrica(int[,] a)
    {
        for(int i = 0; i < a.GetLength(0); i++)
        {
            if (a[i,0] != a[i, a.GetLength(1) - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        // Ejercicio #1
        int filas1 = 5;
        int columnas1 = 5;
        int[,] matriz1 = new int[filas1, columnas1];
        llenarMatriz(matriz1, filas1, columnas1);
        Console.WriteLine("La suma de la diagonal principal es: " + diagonalPrincipal(matriz1));
        Console.WriteLine("La suma de la diagonal secundaria es: " + diagonalSecundaria(matriz1));
        limpiaPantalla();

        // Ejercicio #2
        int filas2 = 4;
        int columnas2 = 6;
        int[,] matriz2 = new int[filas2, columnas2];
        llenarMatriz(matriz2, filas2, columnas2);
        Console.WriteLine("La matriz tiene " + contadorPares(matriz2) + " números pares");
        Console.WriteLine("La matriz tiene " + contadorImpares(matriz2) + " números impares");
        limpiaPantalla();

        // Ejercicio #3
        int estudiantes = 5;
        int notes = 4;
        int[,] notas = new int[estudiantes, notes];
        ingresarNotas(notas);
        for(int i = 0; i < notas.GetLength(0); i++)
        {
            Console.WriteLine("El promedio del estudiante " + i + " es: " + promedioEstudiante(notas, i));
            if(estudianteAprueba(promedioEstudiante(notas, i)))
            {
                Console.WriteLine("El estudiante aprobó");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó");
            }
        }
        limpiaPantalla();

        // Ejercicio #4
        int filas3 = 3;
        int columnas3 = 3;
        int[,] matriz_cuadrada = new int[filas3, columnas3];
        llenarMatriz(matriz_cuadrada, filas3, columnas3);
        Console.WriteLine("¿La matriz es simétrica respecto al eje y?" +
            "\n" + matrizSimetrica(matriz_cuadrada));
        limpiaPantalla();

    }
}