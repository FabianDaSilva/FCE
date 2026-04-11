// MODELO 2 — Videoclub "BLOCKBUSTER"
//
// Un videoclub necesita un sistema para gestionar sus alquileres.
// Tiene hasta 100 alquileres simultáneos.
// Cada alquiler almacena:
// - DNI del cliente: string (puede alquilar más de una vez)
// - Nombre del cliente: string
// - Título de la película: string
// - Fecha de devolución: string (ej: "15/04/2026")
//
// ARRAYS OBLIGATORIOS:
// string[] dnis            = new string[100];
// string[] nombres         = new string[100];
// string[] titulos         = new string[100];
// string[] fechas          = new string[100];
// int      totalAlquileres = 0;
//
// MENÚ:
// 1 - Registrar alquiler
//     - Verificar que haya espacio. Si no → error
//     - Pedir DNI (no vacío)
//     - Pedir nombre (no vacío)
//     - Pedir título de película (no vacío)
//     - Pedir fecha de devolución (no vacía)
//     - Confirmar registro exitoso
// 2 - Listar todos los alquileres (DNI, nombre, título, fecha)
// 3 - Buscar por DNI → listar todos los alquileres de ese cliente. Si no existe → error
// 4 - Mostrar el alquiler con la fecha de devolución más próxima (el primero alfabéticamente por fecha)
// 5 - Salir


static void Modelo2()
{
    string[] dnis = new string[100];
    string[] nombres = new string[100];
    string[] titulos = new string[100];
    string[] fechas = new string[100];
    int totalAlquileres = 0;

    string dni = "", nombre = "", titulo = "", fecha = "", menu;
    System.Console.WriteLine("=====================");
    System.Console.WriteLine("======MODELO DOS=====");
    System.Console.WriteLine("=====================");

    do
    {
        System.Console.WriteLine("==============\n1.Registrar alquiler\n2.Listar todos los alquileres\n3.Buscar por DNI\n4.Mostrar el alquiler con la fecha de devolución más próxima\n5.Salir\n==============");

        menu = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(menu))
        {
            System.Console.WriteLine("Seleccioná una opcion valida");
            menu = Console.ReadLine() ?? "";
        }

        switch (menu)
        {

            case "1":
                Registrar(ref totalAlquileres, dni, dnis, nombre, nombres, titulo, titulos, fecha, fechas); break;
            case "2":
                Listar(ref totalAlquileres, dnis, nombres, titulos, fechas); break;
            case "3":
                Buscar(totalAlquileres, dnis, nombres, titulos, fechas); break;
            case "4":
                AlquileresPorVencer(totalAlquileres, dnis, nombres, titulos, fechas); break;

        }


    } while (menu != "5");

}

Modelo2();

static void Registrar(ref int totalAlquileres, string dni, string[] dnis, string nombre, string[] nombres, string titulo, string[] titulos, string fecha, string[] fechas)
{
    // 1 - Registrar alquiler
    //     - Verificar que haya espacio. Si no → error
    //     - Pedir DNI (no vacío)
    //     - Pedir nombre (no vacío)
    //     - Pedir título de película (no vacío)
    //     - Pedir fecha de devolución (no vacía)
    //     - Confirmar registro exitoso

    if (totalAlquileres >= 100)
    {
        System.Console.WriteLine("No hay más espacio");
        return;
    }

    System.Console.WriteLine("Por favor ingresa tu dni: ");
    dni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(dni))
    {
        System.Console.WriteLine("Ingresa tu dni:");
        dni = Console.ReadLine() ?? "";
    }
    dnis[totalAlquileres] = dni;


    System.Console.WriteLine("Por favor ingresa tu nombre: ");
    nombre = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(nombre))
    {
        System.Console.WriteLine("Ingresa tu nombre:");
        nombre = Console.ReadLine() ?? "";
    }
    nombres[totalAlquileres] = nombre;


    System.Console.WriteLine("Por favor ingresa tu titulo: ");
    titulo = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(titulo))
    {
        System.Console.WriteLine("Ingresa tu titulo:");
        titulo = Console.ReadLine() ?? "";
    }
    titulos[totalAlquileres] = titulo;


    System.Console.WriteLine("Ingresar fecha de devolucion: ");
    fecha = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(fecha))
    {
        System.Console.WriteLine("Ingresa tu fecha:");
        fecha = Console.ReadLine() ?? "";
    }
    fechas[totalAlquileres] = fecha;

    totalAlquileres++;

    System.Console.WriteLine("Registro exitoso!");

}

static void Listar(ref int totalAlquileres, string[] dnis, string[] nombres, string[] titulos, string[] fechas)
{
    for (int l = 0; l < totalAlquileres; l++)
    {
        System.Console.WriteLine($"===================Dni:{dnis[l]}\nNombre:{nombres[l]}\nTitulo:{titulos[l]}\nFecha de devolucion:{fechas[l]}\n===================");
    }
}

static void Buscar(int totalAlquileres, string[] dnis, string[] nombres, string[] titulos, string[] fechas)
{
    // 3 - Buscar por DNI → listar todos los alquileres de ese cliente. Si no existe → error

    string buscarDni;
    System.Console.WriteLine("Ingresa tu dni para ver tus alquileres: ");
    buscarDni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(buscarDni))
    {
        System.Console.WriteLine("Ingresa tu dni: ");
        buscarDni = Console.ReadLine() ?? "";
    }
    bool existe = false;
    for (int i = 0; i < totalAlquileres; i++)
    {
        if (buscarDni == dnis[i])
        {
            System.Console.WriteLine($"===================\nPeliculas alquiladas:\nTitulos:{titulos[i]}\nFecha de devolucion:{fechas[i]}\n===================");
            existe = true;
        }
    }
    if (!existe)
    {
        System.Console.WriteLine("No existe");
    }
}

static void AlquileresPorVencer(int totalAlquileres, string[] dnis, string[] nombres, string[] titulos, string[] fechas)
{
    int indiceMenor = 0;
    for (int v = 0; v < totalAlquileres; v++)
    {
        if (String.Compare(fechas[v], fechas[indiceMenor]) < 0)
        {
            indiceMenor = v;
        }
    }
    Console.WriteLine($"{dnis[indiceMenor]} - {titulos[indiceMenor]} - {fechas[indiceMenor]}");
}