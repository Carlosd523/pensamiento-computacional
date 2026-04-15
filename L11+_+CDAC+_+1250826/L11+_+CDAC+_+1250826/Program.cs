using System;
class Program
{
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
    static void Main()
    {
        //Ejercicio #1
        Console.WriteLine("Ingrese una palabra");
        string palabra = Console.ReadLine()!;
        Console.WriteLine(palindromo(palabra, palabraInversa(palabra)));
    }
}