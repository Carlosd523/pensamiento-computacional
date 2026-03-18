using System;
class Program
{
    static int cantidadCaracteres(string a)
    {
        int caracteres = a.Length;
        return caracteres;
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un string a evaluar");
        string texto = Console.ReadLine()!;
        Console.WriteLine("Su string tiene " + cantidadCaracteres(texto) + "carácteres");
    }
}