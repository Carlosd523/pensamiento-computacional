using System;
// Ejercicio #1 - Clase #1
class CuentaBancaria
{
    private string Titular { get; set; }
    private string NumeroCuenta { get; set; }
    private double Saldo { get; set; }

    // Constructor
    public CuentaBancaria(string titular, string numeroCuenta, double saldo)
    {
        Titular = titular;
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    // Subproceso #1
    public void MostrarInformacion()
    {
        Console.WriteLine("EL TITULAR DE LA CUENTA ES: " + Titular +
            "\nEL NUMERO DE CUENTA ES: " + NumeroCuenta +
            "\nEL SALDO DE LA CUENTA ES: Q" + Saldo);
    }

    // Subproceso #2
    public void DepositarMonto()
    {
        bool valido = false;
        double monto = 0;
        while (!valido)
        {
            Console.WriteLine("¿Cuál es el monto que desea depositar?");
            string dato = Console.ReadLine()!;

            if (double.TryParse(dato, out monto))
            {
                if (monto > 0)
                    valido = true;
                else
                    Console.WriteLine("El monto debe de ser mayor a cero");
            }
            else
                Console.WriteLine("Ingrese un valor válido");
        }
        Console.WriteLine("El monto depositado es: " + monto);
        Saldo += monto;
    }

    // Subproceso #3
    public void RetirarMonto()
    {
        bool valido = false;
        double monto = 0;
        while (!valido)
        {
            Console.WriteLine("¿Cuál es el monto que desea retirar?");
            string dato = Console.ReadLine()!;

            if (double.TryParse(dato, out monto))
            {
                if (monto > 0 && monto < Saldo)
                    valido = true;
                else
                    Console.WriteLine("Monto inválido");
            }
            else
                Console.WriteLine("Ingrese un valor válido");
        }
        Console.WriteLine("El monto retirado es: " + monto);
        Saldo -= monto;
    }
}

// Ejercicio 2 - Clase #1
class Producto
{
    private string Nombre { get; set; }
    private double Precio { get; set; }
    private int Cantidad { get; set; }

    // Constructor
    public Producto(string nombre, double precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    // Subproceso #1
    public void MostrarInformacion()
    {
        Console.WriteLine("INFORMACIÓN DEL PRODUCTO" +
            "\nNOMBRE: " + Nombre +
            "\nPRECIO: Q" + Precio +
            "\nCANTIDAD DISPONIBLE: " + Cantidad);
    }

    // Subproceso #2
    public void Vender()
    {
        bool valido = false;
        int cantidadVendida = 0;
        while (!valido)
        {
            Console.WriteLine("INGRESE LA CANTIDAD VENDIDA");
            string dato = Console.ReadLine()!;
            if (int.TryParse(dato, out cantidadVendida))
            {
                if (cantidadVendida <= Cantidad && cantidadVendida > 0)
                    valido = true;
                else
                    Console.WriteLine("Cantidad inválida");
            }
            else
                Console.WriteLine("Ingrese un valor válido");
        }
        Cantidad -= cantidadVendida;
    }

    // Subproceso #3
    public void Reabastecer()
    {
        bool valido = false;
        int cantidadReabastecida = 0;
        while (!valido)
        {
            Console.WriteLine("INGRESE LA CANTIDAD REABASTECIDA");
            string dato = Console.ReadLine()!;
            if (int.TryParse(dato, out cantidadReabastecida))
            {
                if (cantidadReabastecida > 0)
                    valido = true;
                else
                    Console.WriteLine("La cantidad reabastecida debe de ser mayor a cero");
            }
            else
                Console.WriteLine("Ingrese un valor válido");
        }
        Cantidad += cantidadReabastecida;
    }
}

// Ejercicio #3 - Clase #1
class Estudiante
{
    private string Nombre { get; set; }
    private int Edad { get; set; }
    private string Grado { get; set; }
    private double[] Notas { get; set; }

    public Estudiante(string nombre, int edad, string grado, double[] notas)
    {
        Nombre = nombre;
        Edad = edad;
        Grado = grado;
        Notas = notas;
    }

    // Subproceso #1
    public double CalcularPromedio()
    {
        double suma = 0;
        for(int i = 0; i < Notas.Length; i++)
            suma += Notas[i];
        double promedio = suma / Notas.Length;
        return promedio;
    }

    // Subproceso #2
    public void MostrarInformación()
    {
        Console.WriteLine("INFORMACIÓN ESTUDIANTE" +
            "\nNOMBRE DEL ESTUDIANTE: " + Nombre +
            "\nEDAD: " + Edad +
            "\nGRADO: " + Grado +
            "\nNOTAS: ");
        for (int i = 0; i < (Notas.Length); i++)
            Console.WriteLine(Notas[i]);
        Console.WriteLine("PROMEDIO: " + CalcularPromedio());
    }

    // Subproceso #3
    public void Aprobar()
    {
        if (CalcularPromedio() >= 61)
            Console.WriteLine("El estudiante aprobó");
        else
            Console.WriteLine("El estudiante reprobó");
    }

    // Subproceso #4
    public void AgregarNota()
    {
        Console.WriteLine("Ingrese la nueva nota");
        string dato = Console.ReadLine()!;
        double nuevaNota;
        double[] nuevoArreglo = new double[Notas.Length + 1];
        if (double.TryParse(dato, out nuevaNota))
        {
            if (nuevaNota >= 0 && nuevaNota <= 100)
            {
                for (int i = 0; i < Notas.Length; i++)
                    nuevoArreglo[i] = Notas[i];
                nuevoArreglo[Notas.Length] = nuevaNota;
                Notas = nuevoArreglo;
                Console.WriteLine("El nuevo promedio es de: " + CalcularPromedio());
            }
            else
                Console.WriteLine("Ingrese una nota válida");
        }
        else
            Console.WriteLine("Ingrese un valor válido");
    }
}
class Program
{
    static void LimpiaPantalla()
    {
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }

    static void Main()
    {
        // Ejercicio #1
        CuentaBancaria cuenta1 = new CuentaBancaria("Daniela", "1010345650", 50000);
        CuentaBancaria cuenta2 = new CuentaBancaria("Javier", "3024350684", 25000);

        cuenta1.MostrarInformacion();
        LimpiaPantalla();
        cuenta1.DepositarMonto();
        cuenta1.MostrarInformacion();
        LimpiaPantalla();
        cuenta1.RetirarMonto();
        cuenta1.MostrarInformacion();
        LimpiaPantalla();

        cuenta2.MostrarInformacion();
        LimpiaPantalla();
        cuenta2.DepositarMonto();
        cuenta2.MostrarInformacion();
        LimpiaPantalla();
        cuenta2.RetirarMonto();
        cuenta2.MostrarInformacion();
        LimpiaPantalla();

        // Ejercicio #2
        Producto leche = new Producto("Leche", 20.99, 10);
        Producto pan = new Producto("Pan", 5.75, 20);

        leche.MostrarInformacion();
        LimpiaPantalla();
        leche.Vender();
        leche.MostrarInformacion();
        LimpiaPantalla();
        leche.Reabastecer();
        leche.MostrarInformacion();
        LimpiaPantalla();

        pan.MostrarInformacion();
        LimpiaPantalla();
        pan.Vender();
        pan.MostrarInformacion();
        LimpiaPantalla();
        pan.Reabastecer();
        pan.MostrarInformacion();
        LimpiaPantalla();

        // Ejercicio #3
        Estudiante estudiante1 = new Estudiante("Daniel", 17, "Quinto Bachillerato", new double[] { 67.6, 45.7, 89.23, 56.56, 100.00, 34.67 });
        Estudiante estudiante2 = new Estudiante("Andrea", 18, "Quinto Bachillerato", new double[] { 54.3, 23.5, 76.5, 32.3, 45.7, 80.1 });

        estudiante1.MostrarInformación();
        LimpiaPantalla();
        estudiante2.MostrarInformación();
        LimpiaPantalla();
        estudiante1.Aprobar();
        estudiante2.Aprobar();
        LimpiaPantalla();
        estudiante1.AgregarNota();
        LimpiaPantalla();
        estudiante2.AgregarNota();
        LimpiaPantalla();
        estudiante1.MostrarInformación();
        LimpiaPantalla();
        estudiante2.MostrarInformación();
        LimpiaPantalla();
        estudiante1.Aprobar();
        estudiante2.Aprobar();
    }
}