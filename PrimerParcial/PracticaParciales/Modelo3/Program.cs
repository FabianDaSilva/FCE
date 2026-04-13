// MODELO 3 — Gimnasio "FIT TOTAL"
//
// Un gimnasio necesita un sistema para gestionar sus socios.
// Tiene hasta 150 socios.
// Cada socio almacena:
// - DNI: string (único)
// - Nombre: string
// - Apellido: string
// - Plan: string ("BÁSICO" o "PREMIUM")
// - Cuotas pagas: int (empieza en 0)
//
// ARRAYS OBLIGATORIOS:
// string[] dnis        = new string[150];
// string[] nombres     = new string[150];
// string[] apellidos   = new string[150];
// string[] planes      = new string[150];
// int[]    cuotas      = new int[150];
// int      totalSocios = 0;
//
// MENÚ:
// 1 - Registrar socio
//     - Verificar que haya espacio. Si no → error
//     - Pedir DNI (no vacío). Si ya existe → error
//     - Pedir nombre y apellido (no vacíos)
//     - Pedir plan: solo acepta "BASICO" o "PREMIUM" (validar con do/while + ToUpper)
//     - Cuotas pagas arranca en 0
// 2 - Registrar pago de cuota
//     - Pedir DNI. Si no existe → error
//     - Incrementar cuotas en 1. Confirmar pago
// 3 - Listar socios ordenados alfabéticamente por apellido (Bubble Sort con String.Compare)
// 4 - Mostrar el socio con más cuotas pagas
// 5 - Salir


static void Modelo3()
{
    string[] dnis = new string[150];
    string[] nombres = new string[150];
    string[] apellidos = new string[150];
    string[] planes = new string[150];
    int[] cuotas = new int[150];
    int totalSocios = 0;
    string menu;

    System.Console.WriteLine("=====================");
    System.Console.WriteLine("======MODELO TRES=====");
    System.Console.WriteLine("=====================");
    do
    {
        System.Console.WriteLine("==============\n1.Registrar socio\n2.Registrar pago de cuota\n3.Listar socios ordenados alfabéticamente por apellido\n4.Mostrar el socio con más cuotas pagas\n5.Salir\n==============");

        menu = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(menu))
        {
            System.Console.WriteLine("Elegi una opcion valida");
            menu = Console.ReadLine() ?? "";
        }

        switch (menu)
        {

            case "1":
                Registrar(ref totalSocios, dnis, nombres, apellidos, planes, cuotas); break;
            case "2":
                RegistrarPagoCuota(ref totalSocios, dnis, nombres, apellidos, planes, cuotas); break;
            case "3":
                SociosOrdenados(ref totalSocios, dnis, nombres, apellidos, planes, cuotas); break;
            case "4":
                SociosPagaMas(ref totalSocios, dnis, nombres, apellidos, planes, cuotas); break;
        }

    } while (menu != "5");
}

Modelo3();
static void Registrar(ref int totalSocios, string[] dnis, string[] nombres, string[] apellidos, string[] planes, int[] cuotas)
{
    //1 - Registrar socio
    //     - Verificar que haya espacio. Si no → error
    //     - Pedir DNI (no vacío). Si ya existe → error
    //     - Pedir nombre y apellido (no vacíos)
    //     - Pedir plan: solo acepta "BASICO" o "PREMIUM" (validar con do/while + ToUpper)
    //     - Cuotas pagas arranca en 0

    if (totalSocios >= 150)
    {
        System.Console.WriteLine("No hay espacio");
        return;
    }

    string pedirDni;
    System.Console.WriteLine("Ingresa tu DNI");
    pedirDni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirDni))
    {
        System.Console.WriteLine("Ingresa tu DNI");
        pedirDni = Console.ReadLine() ?? "";
    }
    for (int i = 0; i < totalSocios; i++)
    {
        if (dnis[i] == pedirDni)
        {
            System.Console.WriteLine("Este DNI ya existe");
            return;
        }
    }

    dnis[totalSocios] = pedirDni;


    string pedirNombre;
    System.Console.WriteLine("Ingresa tu nombre: ");
    pedirNombre = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirNombre))
    {
        System.Console.WriteLine("Ingresa tu nombre: ");
        pedirNombre = Console.ReadLine() ?? "";
    }
    nombres[totalSocios] = pedirNombre;


    string pedirApellido;
    System.Console.WriteLine("Ingresa tu Apellido: ");
    pedirApellido = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirApellido))
    {
        System.Console.WriteLine("Ingresa tu Apellido: ");
        pedirApellido = Console.ReadLine() ?? "";
    }
    apellidos[totalSocios] = pedirApellido;

    string pedirPlan;
    do
    {
        System.Console.WriteLine("Ingresa un plan: \nBASICO\nPREMIUM");
        pedirPlan = Console.ReadLine()?.ToUpper() ?? "";
        while (string.IsNullOrEmpty(pedirPlan))
        {
            System.Console.WriteLine("Ingresa un plan valido: \nBASICO\nPREMIUM");
            pedirPlan = Console.ReadLine() ?? "";
        }
    } while (pedirPlan != "BASICO" && pedirPlan != "PREMIUM");
    planes[totalSocios] = pedirPlan;

    cuotas[totalSocios] = 0;
    totalSocios++;
    System.Console.WriteLine("Ingreso confirmado exitosamente");


}

static void RegistrarPagoCuota(ref int totalSocios, string[] dnis, string[] nombres, string[] apellidos, string[] planes, int[] cuotas)
{
    // 2 - Registrar pago de cuota
    //     - Pedir DNI. Si no existe → error
    //     - Incrementar cuotas en 1. Confirmar pago

    string pedirDni;
    System.Console.WriteLine("Por favor ingresa tu dni: ");
    pedirDni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirDni))
    {
        System.Console.WriteLine("Ingresa tu dni: ");
        pedirDni = Console.ReadLine() ?? "";
    }

    bool pagado = false;
    for (int i = 0; i < totalSocios; i++)
    {
        if (pedirDni == dnis[i])
        {
            pagado = true;
            cuotas[i]++;
            System.Console.WriteLine($"Se pago la cuota {cuotas[i]++}");
            break;
        }
    }
    if (!pagado)
    {
        System.Console.WriteLine("No se hay coincidencia con dni");
        return;
    }
}

static void SociosOrdenados(ref int totalSocios, string[] dnis, string[] nombres, string[] apellidos, string[] planes, int[] cuotas)
{
    // 3 - Listar socios ordenados alfabéticamente por apellido (Bubble Sort con String.Compare)
    for (int i = 0; i < totalSocios - 1; i++)
    {
        for (int j = 0; j < totalSocios - 1 - i; j++)
        {
            if (String.Compare(apellidos[j], apellidos[j + 1]) > 0)
            {
                string tempApellido = apellidos[j];
                apellidos[j] = apellidos[j + 1];
                apellidos[j + 1] = tempApellido;

                string tempNombre = nombres[j];
                nombres[j] = nombres[j + 1];
                nombres[j + 1] = tempNombre;

                string tempDni = dnis[j];
                dnis[j] = dnis[j + 1];
                dnis[j + 1] = tempDni;

                string tempPlan = planes[j];
                planes[j] = planes[j + 1];
                planes[j + 1] = tempPlan;

                int tempCuota = cuotas[j];
                cuotas[j] = cuotas[j + 1];
                cuotas[j + 1] = tempCuota;
            }
        }
    }

    // después del sort, listar
    for (int i = 0; i < totalSocios; i++)
    {
        Console.WriteLine($"{apellidos[i]}, {nombres[i]} - Plan: {planes[i]} - Cuotas: {cuotas[i]}");
    }


}

static void SociosPagaMas(ref int totalSocios, string[] dnis, string[] nombres, string[] apellidos, string[] planes, int[] cuotas)
{
    int indiceMax = 0;
    for (int i = 0; i < totalSocios; i++)
    {
        if (cuotas[i] > cuotas[indiceMax])
        {
            indiceMax = i;
        }
    }
    Console.WriteLine($"{apellidos[indiceMax]}, {nombres[indiceMax]} - Plan: {planes[indiceMax]} - Cuotas: {cuotas[indiceMax]}");

}