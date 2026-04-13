// MODELO 4 — Veterinaria "PATITAS" (VERSION CORTA)
//
// ARRAYS OBLIGATORIOS:
// int[]    numeros     = new int[80];
// string[] duenos      = new string[80];
// string[] mascotas    = new string[80];
// string[] especies    = new string[80];
// int      totalTurnos = 0;
//
// MENÚ:
// 1 - Registrar turno
//     - Verificar que haya espacio. Si no → error
//     - Pedir nombre del dueño (no vacío)
//     - Pedir nombre de la mascota (no vacío)
//     - Pedir especie: solo acepta "PERRO", "GATO" u "OTRO" (do/while + ToUpper)
//     - Asignar número de turno (máximo + 1, o 1 si es el primero)
// 2 - Cancelar turno por número → buscar y poner null/0 en todos sus campos
// 3 - Salir

static void Modelo4()
{
    int[] numeros = new int[80];
    string[] duenos = new string[80];
    string[] mascotas = new string[80];
    string[] especies = new string[80];
    int totalTurnos = 0;

    string menu;
    System.Console.WriteLine("=====================");
    System.Console.WriteLine("======MODELO TRES=====");
    System.Console.WriteLine("=====================");
    do
    {
        System.Console.WriteLine("==============\n1.Registrar\n2.Cancelar turno\n3.Salir\n==============");

        menu = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(menu))
        {
            System.Console.WriteLine("Elegi una opcion valida");
            menu = Console.ReadLine() ?? "";
        }

        switch (menu)
        {

            case "1":
                Registrar(ref totalTurnos, numeros, duenos, mascotas, especies); break;
            case "2":
                CancelarTurno(ref totalTurnos, numeros, duenos, mascotas, especies); break;

        }

    } while (menu != "5");
}


Modelo4();

static void Registrar(ref int totalTurnos, int[] numeros, string[] duenos, string[] mascotas, string[] especies)
{
    // 1 - Registrar turno
    //     - Verificar que haya espacio. Si no → error
    //     - Pedir nombre del dueño (no vacío)
    //     - Pedir nombre de la mascota (no vacío)
    //     - Pedir especie: solo acepta "PERRO", "GATO" u "OTRO" (do/while + ToUpper)
    //     - Asignar número de turno (máximo + 1, o 1 si es el primero)

    if (totalTurnos >= 80)
    {
        System.Console.WriteLine("No hay espacio: ");
        return;
    }

    string pedirNombre;
    System.Console.WriteLine("Ingresa tu Nombre");
    pedirNombre = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirNombre))
    {
        System.Console.WriteLine("Ingresa tu Nombre");
        pedirNombre = Console.ReadLine() ?? "";
    }
    duenos[totalTurnos] = pedirNombre;

    string pedirNombreMascota;
    System.Console.WriteLine("Ingresa tu Nombre");
    pedirNombreMascota = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirNombreMascota))
    {
        System.Console.WriteLine("Ingresa tu Nombre");
        pedirNombreMascota = Console.ReadLine() ?? "";
    }
    mascotas[totalTurnos] = pedirNombreMascota;

    string pedirEspecie;
    do
    {
        System.Console.WriteLine("Ingresa la especie:\nPERRO\nGATO\nOTRO");
        pedirEspecie = Console.ReadLine()?.ToUpper() ?? "";

    } while (pedirEspecie != "PERRO" && pedirEspecie != "GATO" && pedirEspecie != "OTRO");
    especies[totalTurnos] = pedirEspecie;

    int nroAsignado = 1;
    for (int i = 0; i < totalTurnos; i++)
    {
        if (numeros[i] > nroAsignado)
            nroAsignado = numeros[i];
    }
    if (totalTurnos > 0) nroAsignado++;
    totalTurnos++;
    System.Console.WriteLine("Registro completo");


}
static void CancelarTurno(ref int totalTurnos, int[] numeros, string[] duenos, string[] mascotas, string[] especies)
{
    string input;
    int nroBuscado;
    do
    {
        System.Console.WriteLine("Ingresa el número de turno: ");
        input = Console.ReadLine() ?? "";
    } while (!int.TryParse(input, out nroBuscado));


    for (int i = 0; i < totalTurnos; i++)
    {
        if (nroBuscado == numeros[i])
        {
            numeros[i] = 0;
            duenos[i] = null!;
            mascotas[i] = null!;
            especies[i] = null!;
            break;
        }
    }
}