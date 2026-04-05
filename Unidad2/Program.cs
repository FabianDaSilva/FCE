Console.WriteLine("==================");
Console.WriteLine("==== Unidad 2 ====");
Console.WriteLine("==================");
Console.WriteLine("Ingrese el numero del ejercicio a ejecutar: ");
string? opcion = Console.ReadLine();
switch (opcion)
{
    case "1":
        Ejercicio1(); break;

    case "2":
        Ejercicio2(); break;

    case "3":
        Ejercicio3(); break;

    case "4":
        Ejercicio4(); break;

    case "5":
        Ejercicio5(); break;

    case "6":
        Ejercicio6(); break;

    default:
        Console.WriteLine("No hay mas ejercicios para ejecutar");
        break;
}

static void Ejercicio1()
{
    int[,] matriz = new int[5, 5];
    for (int fila = 0; fila < 5; fila++)
    {
        for (int columna = 0; columna < 5; columna++)
        {
            if (fila == columna || fila + columna == 4)
            {
                matriz[fila, columna] = 1;
            }
            else
            {
                matriz[fila, columna] = 0;
            }
        }
    }

    for (int fila = 0; fila < 5; fila++)
    {
        for (int columna = 0; columna < 5; columna++)
        {
            Console.Write(matriz[fila, columna] + " ");
        }
        Console.WriteLine();
    }

}

static void Ejercicio2()
{
    int[,] matriz = new int[20, 5];
    int contador = 1;

    for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz.GetLength(1); columna++)
        {
            matriz[fila, columna] = contador++;
            Console.Write(matriz[fila, columna] + " ");
        }
        Console.WriteLine();
    }

}

static void Ejercicio3()
{
    int[,] matriz = new int[20, 5];
    int contador = 1;

    for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        if (fila % 2 == 0)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                matriz[fila, columna] = contador++;
                Console.Write(matriz[fila, columna] + " ");
            }
        }
        else
        {
            for (int columna = 4; columna >= 0; columna--)
            {
                matriz[fila, columna] = contador++;
            }
            // imprimir la fila en orden
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + " ");
            }
        }
        Console.WriteLine();
    }

}


static void Ejercicio4()
{
    int[,] matriz = new int[20, 5];
    int contador = 1;

    for (int columna = 4; columna >= 0; columna--)
    {
        if (columna % 2 == 0)
        {
            for (int fila = 19; fila >= 0; fila--)
                matriz[fila, columna] = contador++;
        }
        else
        {
            for (int fila = 0; fila < 20; fila++)
                matriz[fila, columna] = contador++;
        }
    }

    for (int fila = 0; fila < 20; fila++)
    {
        for (int columna = 0; columna < 5; columna++)
            Console.Write($"{matriz[fila, columna],4}");
        Console.WriteLine();
    }
}

static void Ejercicio5()
{
    int[,] matriz = new int[20, 5];
    int contador = 1;

    for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        for (int columna = 4; columna >= 0; columna--)
        {
            matriz[fila, columna] = contador++;
        }

        for (int columna = 0; columna < 5; columna++)
        {
            Console.Write(matriz[fila, columna] + " ");
        }

        Console.WriteLine();
    }

}

static void Ejercicio6()
{
    string[] clientes_nombres = new string[10];
    string[] clientes_direccion = new string[10];
    string[] clientes_telefono = new string[10];

    string opcion;
    int totalClientes = 0;


    opcion = Console.ReadLine();
    do
    {
        Console.WriteLine("1.Alta de clientes\n2.Consulta\n3.Salir");
        opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                Alta(clientes_nombres, clientes_direccion, clientes_telefono, ref totalClientes);
                break;
            case "2":
                Consulta(clientes_nombres, clientes_direccion, clientes_telefono, totalClientes);
                break;
            case "3":
                Console.WriteLine("Salir");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

    } while (opcion != "3");


    static string Pedir(string mensaje)
    {
        string dato = "";
        while (string.IsNullOrEmpty(dato))
        {
            Console.Write(mensaje);
            dato = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(dato))
                Console.WriteLine("Por favor ingresa un valor valido.");
        }
        return dato;
    }

    static void Alta(string[] nombres, string[] direcciones, string[] telefonos, ref int totalClientes)

    {
        string nombre = Pedir("Ingresa tu nombre: ");
        nombres[totalClientes] = nombre;

        string direccion = Pedir("Ingresa tu direccion: ");
        direcciones[totalClientes] = direccion;

        string telefono = Pedir("Ingresa tu telefono: ");
        telefonos[totalClientes] = telefono;

        totalClientes++;

    }
    static void Consulta(string[] nombres, string[] direcciones, string[] telefonos, int totalClientes)
    {

        string buscar = Pedir("Ingresa el nombre a buscar: ");
        for (int i = 0; i < totalClientes; i++)
        {
            if (nombres[i] == buscar)
            {
                Console.WriteLine($"Direccion: {direcciones[i]}");
                Console.WriteLine($"Telefono: {telefonos[i]}");
                return;
            }
        }
        Console.WriteLine("No hay coincidencia");


    }

}