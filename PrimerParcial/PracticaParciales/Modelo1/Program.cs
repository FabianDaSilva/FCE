// MODELO 1 — Estacionamiento "EL GARAJE"
//
// Un estacionamiento necesita un sistema para gestionar sus vehículos.
// Tiene capacidad para 50 autos como máximo.
// Cada auto almacena los siguientes datos:
// - Patente: string (no puede repetirse)
// - Nombre del titular: string
// - Hora de entrada: string (ej: "14:30")
// - Número de cochera: int (se asigna automáticamente: máximo actual + 1, o 1 si es el primero)
//
// ARRAYS OBLIGATORIOS:
// string[] patentes     = new string[50];
// string[] titulares    = new string[50];
// string[] horasEntrada = new string[50];
// int[]    cocheras     = new int[50];
// int      totalAutos   = 0;
//
// MENÚ:
// 1 - Registrar ingreso
//     - Verificar que haya espacio (totalAutos < 50). Si no → error
//     - Pedir patente (no vacía). Si ya existe → error
//     - Pedir nombre del titular (no vacío)
//     - Pedir hora de entrada (no vacía)
//     - Asignar número de cochera (máximo + 1, o 1 si es el primero)
//     - Confirmar ingreso exitoso
// 2 - Listar autos (cochera, patente, titular, hora de entrada)
// 3 - Buscar auto por patente → mostrar todos sus datos. Si no existe → error
// 4 - Salir

void Modelo1()
{
    string[] patentes = new string[50];
    string[] titulares = new string[50];
    string[] horasEntrada = new string[50];
    int[] cocheras = new int[50];
    int totalAutos = 0;

    string menu;

    do
    {
        System.Console.WriteLine("=====================");
        System.Console.WriteLine("======MODELO UNO=====");
        System.Console.WriteLine("=====================");
        System.Console.WriteLine("1.Alta\n2.Listar\n3.Buscar\n4.Salir");

        menu = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(menu))
        {
            System.Console.WriteLine("Por favor selecciona una opcion:\n1.Alta\n2.Listar\n3.Buscar\n4.Salir");
            menu = Console.ReadLine() ?? "";
        }
        switch (menu)
        {
            case "1":
                Registrar(ref totalAutos, patentes, titulares, horasEntrada, cocheras); break;
            case "2":
                Listar(totalAutos, patentes, titulares, horasEntrada, cocheras); break;
            case "3":
                Buscar(totalAutos, patentes, titulares, horasEntrada, cocheras); break;
        }
    } while (menu != "4");
}

Modelo1();

void Registrar(ref int totalAutos, string[] patentes, string[] titulares, string[] horasEntrada, int[] cocheras)
{
    if (totalAutos >= 50)
    {
        System.Console.WriteLine("No hay más espacio");
        return;
    }

    string patente;
    System.Console.WriteLine("Por favor ingresa tu nro de patente: ");
    patente = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(patente))
    {
        System.Console.WriteLine("Ingresa tu nro de patente: ");
        patente = Console.ReadLine() ?? "";
    }

    for (int p = 0; p < totalAutos; p++)
    {
        if (patente == patentes[p])
        {
            System.Console.WriteLine("Esta patente ya existe");
            return;
        }
    }
    patentes[totalAutos] = patente;

    string nombre;
    System.Console.WriteLine("Por favor ingresa tu nombre: ");
    nombre = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(nombre))
    {
        System.Console.WriteLine("Ingresa tu nombre: ");
        nombre = Console.ReadLine() ?? "";
    }
    titulares[totalAutos] = nombre;

    string horaEntrada;
    System.Console.WriteLine("Por favor ingresa la hora de entrada: ");
    horaEntrada = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(horaEntrada))
    {
        System.Console.WriteLine("Ingresa la hora de entrada: ");
        horaEntrada = Console.ReadLine() ?? "";
    }
    horasEntrada[totalAutos] = horaEntrada;

    int nroCochera = 1;
    for (int c = 0; c < totalAutos; c++)
    {
        if (cocheras[c] > nroCochera)
            nroCochera = cocheras[c];
    }
    if (totalAutos > 0)
        nroCochera++;
    cocheras[totalAutos] = nroCochera;

    totalAutos++;
    System.Console.WriteLine("Ingreso confirmado exitosamente");
}

void Listar(int totalAutos, string[] patentes, string[] titulares, string[] horasEntrada, int[] cocheras)
{
    for (int i = 0; i < totalAutos; i++)
    {
        System.Console.WriteLine($"=========================\nTitulares: {titulares[i]}\nPatentes: {patentes[i]}\nHora de entrada: {horasEntrada[i]}\nCocheras: {cocheras[i]}\n=========================");
    }
}

void Buscar(int totalAutos, string[] patentes, string[] titulares, string[] horasEntrada, int[] cocheras)
{
    string buscador;
    bool encontrado = false;
    System.Console.WriteLine("Por favor ingresa la patente");
    buscador = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(buscador))
    {
        System.Console.WriteLine("Ingresa la patente");
        buscador = Console.ReadLine() ?? "";
    }

    for (int b = 0; b < totalAutos; b++)
    {
        if (patentes[b] == buscador)
        {
            System.Console.WriteLine($"=========================\nResultado:\nTitulares: {titulares[b]}\nPatentes: {patentes[b]}\nHora de entrada: {horasEntrada[b]}\nCocheras: {cocheras[b]}\n=========================");
            encontrado = true;
            break;
        }
    }
    if (!encontrado)
        System.Console.WriteLine("Patente no encontrada");
}
