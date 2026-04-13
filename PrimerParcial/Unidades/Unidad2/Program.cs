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

    case "7":
        Ejercicio7(); break;

    case "8":
        Ejercicio8(); break;

    case "9":
        Ejercicio9(); break;

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

static void Ejercicio7()
{
    /* 
    Varibles:
    nombre, nota
    totalAlumnos
    continuar
    
    Arrays:
    notas
    alumnos

    Funciones:
    -Pedir datos para el ingreso de nombre y nota
    -Listar alumnos aprobados
     */

    string nombre, continuar;
    double nota;
    int totalAlumnos = 0;


    double[] notas = new double[10];
    string[] alumnos = new string[10];

    do
    {
        System.Console.WriteLine("Ingresa el nombre del alumno:");

        nombre = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(nombre))
        {
            System.Console.WriteLine("Por favor ingresa un nombre valido: ");
            nombre = Console.ReadLine() ?? "";
        }
        alumnos[totalAlumnos] = nombre;

        do
        {
            System.Console.WriteLine("Ingresa una nota de 1 - 10: ");
        } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 1 || nota > 10);

        notas[totalAlumnos] = nota;

        totalAlumnos++;

        System.Console.WriteLine("Desea continuar? \n s:(si) \n n:(no)");
        continuar = Console.ReadLine();
    } while (continuar == "s");
    System.Console.WriteLine($"Cantidad de alumnos ingresados: {totalAlumnos}");



    Console.WriteLine($"Lista de alumnos aprobados: ");
    for (int i = 0; i < totalAlumnos; i++)
    {
        if (notas[i] >= 6)
        {

            Console.WriteLine($"{alumnos[i]} - {notas[i]}");
        }
    }
}

static void Ejercicio8()
{
    /* 
    Variables:
    totalClientes
    continuar

    Arrays:
    codigoCliente
    razonSocial
    ventaPeriodo

    Funciones:
    ClienteQueMásVendio()
    ClienteQueMenosVendio()
    PromedioVentas()
     */

    int totalClientes = 0;
    string continuar;
    string codigoCliente, razonSocial;
    double venta;

    string[] codigoCliente_lista = new string[10];
    string[] razonSocial_lista = new string[10];
    double[] ventaPeriodo_lista = new double[10];


    do
    {
        System.Console.WriteLine("Ingresar código de cliente: ");
        codigoCliente = Console.ReadLine() ?? "";

        while (string.IsNullOrEmpty(codigoCliente))
        {
            System.Console.WriteLine("Por favor ingresa el codigo. ");
            codigoCliente = Console.ReadLine() ?? "";
        }
        codigoCliente_lista[totalClientes] = codigoCliente;


        System.Console.WriteLine("Ingresar razon social: ");
        razonSocial = Console.ReadLine() ?? "";

        while (string.IsNullOrEmpty(razonSocial))
        {
            System.Console.WriteLine("Por favor ingresa la razon social. ");
            razonSocial = Console.ReadLine() ?? "";
        }
        razonSocial_lista[totalClientes] = razonSocial;


        do
        {
            System.Console.WriteLine("Ingresa el monto de la venta: ");
        } while (!double.TryParse(Console.ReadLine(), out venta) || venta < 0);
        ventaPeriodo_lista[totalClientes] = venta;


        ventaPeriodo_lista[totalClientes] = venta;

        totalClientes++;

        System.Console.WriteLine("Desea continuar? \n s:(si) \n n:(no)");
        continuar = Console.ReadLine();

    } while (continuar == "s");


    double ventaMax = ventaPeriodo_lista[0];
    double ventaMin = ventaPeriodo_lista[0];
    int indiceMax = 0;
    int indiceMin = 0;

    for (int i = 0; i < totalClientes; i++)
    {
        if (ventaPeriodo_lista[i] > ventaMax)
        {
            ventaMax = ventaPeriodo_lista[i];
            indiceMax = i;
        }
        if (ventaPeriodo_lista[i] < ventaMin)
        {
            ventaMin = ventaPeriodo_lista[i];
            indiceMin = i;
        }

    }

    Console.WriteLine($"Mayor venta: {razonSocial_lista[indiceMax]} - ${ventaMax}");
    Console.WriteLine($"Menor venta: {razonSocial_lista[indiceMin]} - ${ventaMin}");
}

static void Ejercicio9()
{
    string[] Lista = { "Ana", "Zebra", "Mario", "Carlos", "Bruno" };

    // Ordenar
    for (int i = 0; i < Lista.Length - 1; i++)
    {
        for (int j = 0; j < Lista.Length - 1; j++)
        {
            if (String.Compare(Lista[j], Lista[j + 1]) > 0)
            {
                string aux = Lista[j];
                Lista[j] = Lista[j + 1];
                Lista[j + 1] = aux;
            }
        }
    }

    // Imprimir ya ordenado
    for (int i = 0; i < Lista.Length; i++)
    {
        Console.WriteLine(Lista[i]);
    }

}