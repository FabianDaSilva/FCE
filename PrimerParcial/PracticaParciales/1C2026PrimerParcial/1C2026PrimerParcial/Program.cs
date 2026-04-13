// 1ER PARCIAL - 1C 2026
// Sistema de Trazabilidad para Laboratorio
//
// ARRAYS ARTÍCULOS (máx 100):
// string[] codigos        = new string[100];
// string[] nombres        = new string[100];
// int      totalArticulos = 0;
//
// ARRAYS MOVIMIENTOS DE STOCK (máx 10.000):
// string[] movCodigos  = new string[10000];
// string[] movLotes    = new string[10000];
// string[] movSeries   = new string[10000];
// int[]    movUnidades = new int[10000];    // siempre 1 (entrada unitaria)
// int      totalMov    = 0;
//
// MENÚ:
// A - Cargar ingreso de stock
//     a. Si no hay lugar (totalMov >= 10000) → error y vuelve al menú
//     b. Pedir código de artículo → validar que exista en codigos[]. Si no → error
//     c. Pedir número de lote → pedir hasta que ingrese un lote NUEVO
//        (que no exista ya para ese artículo en movimientos)
//     d. Pedir número de serie → validar que la combinación lote+serie no exista. Si existe → error
//     e. Si el lote ya tiene >= 5 series registradas → error y vuelve al menú
//     f. Guardar movimiento: código, lote, serie, unidades=1. totalMov++
// D - Listar todas las grabaciones (código artículo, lote, serie, unidades)
// S - Salir
// Punto 1: cargar artículos desde archivo → NO DESARROLLAR (solo invocar)

void SistemaTrazabilidad()
{
    // Arrays artículos
    string[] codigos = new string[100];
    string[] nombres = new string[100];
    int totalArticulos = 0;

    // Arrays movimientos
    string[] movCodigos = new string[10000];
    string[] movLotes = new string[10000];
    string[] movSeries = new string[10000];
    int[] movUnidades = new int[10000];
    int totalMov = 0;

    // Punto 1: cargar artículos desde archivo (NO DESARROLLAR)
    CargarArchivo(codigos, nombres, ref totalArticulos);

    string menu;
    do
    {
        Console.WriteLine("===================");
        Console.WriteLine("A - Cargar ingreso de stock");
        Console.WriteLine("D - Listar grabaciones");
        Console.WriteLine("S - Salir");
        Console.WriteLine("===================");
        menu = Console.ReadLine()?.ToUpper() ?? "";
        while (string.IsNullOrEmpty(menu))
        {
            Console.WriteLine("Ingresá una opción válida:");
            menu = Console.ReadLine()?.ToUpper() ?? "";
        }

        switch (menu)
        {
            case "A":
                CargarIngreso(ref totalMov, totalArticulos, codigos, movCodigos, movLotes, movSeries, movUnidades); break;
            case "D":
                ListarGrabaciones(totalMov, movCodigos, movLotes, movSeries, movUnidades); break;
        }

    } while (menu != "S");
}

SistemaTrazabilidad();

// Punto 1 - NO DESARROLLAR
void CargarArchivo(string[] codigos, string[] nombres, ref int totalArticulos) { }

// Opción A - Cargar ingreso de stock
void CargarIngreso(ref int totalMov, int totalArticulos, string[] codigos,
                   string[] movCodigos, string[] movLotes, string[] movSeries, int[] movUnidades)
{
    // a. Verificar espacio
    if (totalMov >= 10000)
    {
        Console.WriteLine("No hay lugar para más movimientos de stock");
        return;
    }

    // b. Pedir código de artículo y validar que exista
    string pedirCodigo;
    Console.WriteLine("Ingresá el código de artículo:");
    pedirCodigo = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirCodigo))
    {
        Console.WriteLine("Ingresá el código de artículo:");
        pedirCodigo = Console.ReadLine() ?? "";
    }

    int indiceArticulo = -1;
    for (int i = 0; i < totalArticulos; i++)
    {
        if (codigos[i] == pedirCodigo)
        {
            indiceArticulo = i;
            break;
        }
    }
    if (indiceArticulo == -1)
    {
        Console.WriteLine("El artículo no existe");
        return;
    }

    // c. Pedir lote → pedir hasta que sea uno NUEVO para ese artículo
    string pedirLote;
    bool loteExiste;
    do
    {
        loteExiste = false;
        Console.WriteLine("Ingresá el número de lote:");
        pedirLote = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(pedirLote))
        {
            Console.WriteLine("Ingresá el número de lote:");
            pedirLote = Console.ReadLine() ?? "";
        }

        for (int i = 0; i < totalMov; i++)
        {
            if (movCodigos[i] == pedirCodigo && movLotes[i] == pedirLote)
            {
                loteExiste = true;
                break;
            }
        }
        if (loteExiste)
            Console.WriteLine("Ese lote ya existe para este artículo. Ingresá un lote nuevo:");

    } while (loteExiste);

    // d. Pedir número de serie → validar que la combinación lote+serie no exista
    string pedirSerie;
    Console.WriteLine("Ingresá el número de serie:");
    pedirSerie = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirSerie))
    {
        Console.WriteLine("Ingresá el número de serie:");
        pedirSerie = Console.ReadLine() ?? "";
    }

    for (int i = 0; i < totalMov; i++)
    {
        if (movLotes[i] == pedirLote && movSeries[i] == pedirSerie)
        {
            Console.WriteLine("La combinación lote + serie ya existe");
            return;
        }
    }

    // e. Validar que el lote no tenga ya >= 5 series
    int seriesPorLote = 0;
    for (int i = 0; i < totalMov; i++)
    {
        if (movLotes[i] == pedirLote)
            seriesPorLote++;
    }
    if (seriesPorLote >= 5)
    {
        Console.WriteLine("El lote ya tiene 5 series registradas");
        return;
    }

    // f. Guardar movimiento
    movCodigos[totalMov] = pedirCodigo;
    movLotes[totalMov] = pedirLote;
    movSeries[totalMov] = pedirSerie;
    movUnidades[totalMov] = 1;
    totalMov++;
    Console.WriteLine("Grabación realizada exitosamente");
}

// Opción D - Listar grabaciones
void ListarGrabaciones(int totalMov, string[] movCodigos, string[] movLotes, string[] movSeries, int[] movUnidades)
{
    for (int i = 0; i < totalMov; i++)
    {
        Console.WriteLine($"===================\nArtículo: {movCodigos[i]}\nLote: {movLotes[i]}\nSerie: {movSeries[i]}\nUnidades: {movUnidades[i]}\n===================");
    }
}
