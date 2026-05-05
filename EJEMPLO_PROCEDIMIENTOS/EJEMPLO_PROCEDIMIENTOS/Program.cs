using System;
class Program
{
    static string lanzamientoMoneda(int lado)
    {
        Random dato1 = new Random();
        int ladoAleatorio = dato1.Next(1, 3);

        if(ladoAleatorio == 1)
        {
            return "Cara";
        }
        else
        {
            return "Escudo";
        }
    }

    static void Main()
    {
        for(int i = 1; i <11; i++)
        {
            Console.WriteLine(lanzamientoMoneda(i));
        }
    }
}