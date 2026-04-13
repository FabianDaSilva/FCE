// Parcial 1 - Sistema de reservas de teatro

int[] numeroReserva = new int[200];
string[] nombreReserva = new string[200];
string[] emailReserva = new string[200];
string[] asientoReserva = new string[200];

int totalReservas = 0;

char[] filas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' };

string opcion;

do
{
    Console.WriteLine("\n=== Sistema de Reservas ===");
    Console.WriteLine("1. Alta de reserva");
    Console.WriteLine("2. Listar reservas");
    Console.WriteLine("3. Salir");
    Console.Write("Opcion: ");
    opcion = Console.ReadLine() ?? "";

    switch (opcion)
    {
        case "1":
            AltaReserva();
            break;
        case "2":
            ListarReservas();
            break;
        case "3":
            Console.WriteLine("Hasta luego!");
            break;
        default:
            Console.WriteLine("Opcion invalida.");
            break;
    }

} while (opcion != "3");


string[] ObtenerAsientosDisponibles()
{
    string[] disponibles = new string[200];
    int count = 0;

    for (int f = 0; f < filas.Length; f++)
    {
        for (int h = 1; h <= 10; h++)
        {
            string asiento = $"{filas[f]}{h}";
            bool ocupado = false;

            for (int i = 0; i < totalReservas; i++)
            {
                if (asientoReserva[i] == asiento)
                {
                    ocupado = true;
                    break;
                }
            }

            if (!ocupado)
            {
                disponibles[count] = asiento;
                count++;
            }
        }
    }

    string[] resultado = new string[count];
    for (int i = 0; i < count; i++)
        resultado[i] = disponibles[i];

    return resultado;
}

void AltaReserva()
{
    if (totalReservas >= 200)
    {
        Console.WriteLine("Error: no hay espacio disponible.");
        return;
    }

    string nombre = "";
    while (string.IsNullOrEmpty(nombre))
    {
        Console.Write("Nombre: ");
        nombre = Console.ReadLine() ?? "";
        if (string.IsNullOrEmpty(nombre))
            Console.WriteLine("El nombre no puede estar vacio.");
    }

    string email = "";
    while (string.IsNullOrEmpty(email))
    {
        Console.Write("Email: ");
        email = Console.ReadLine() ?? "";
        if (string.IsNullOrEmpty(email))
            Console.WriteLine("El email no puede estar vacio.");
    }

    string[] disponibles = ObtenerAsientosDisponibles();

    Console.WriteLine("\nAsientos disponibles:");
    for (int i = 0; i < disponibles.Length; i++)
    {
        Console.Write($"{disponibles[i],4}");
        if ((i + 1) % 10 == 0) Console.WriteLine();
    }
    Console.WriteLine();

    string asientoElegido = "";
    bool asientoValido = false;

    while (!asientoValido)
    {
        Console.Write("Ingresa el asiento: ");
        asientoElegido = (Console.ReadLine() ?? "").ToUpper();

        for (int i = 0; i < disponibles.Length; i++)
        {
            if (disponibles[i] == asientoElegido)
            {
                asientoValido = true;
                break;
            }
        }

        if (!asientoValido)
            Console.WriteLine("Asiento invalido o no disponible. Reingresa.");
    }

    int maxNumero = 0;
    for (int i = 0; i < totalReservas; i++)
    {
        if (numeroReserva[i] > maxNumero)
            maxNumero = numeroReserva[i];
    }

    numeroReserva[totalReservas] = maxNumero + 1;
    nombreReserva[totalReservas] = nombre;
    emailReserva[totalReservas] = email;
    asientoReserva[totalReservas] = asientoElegido;
    totalReservas++;

    Console.WriteLine($"Reserva #{maxNumero + 1} cargada exitosamente.");
}

void ListarReservas()
{
    if (totalReservas == 0)
    {
        Console.WriteLine("No hay reservas registradas.");
        return;
    }

    Console.WriteLine($"\n{"NUMERO",-8} {"NOMBRE",-20} {"EMAIL",-30} {"ASIENTO",-8}");
    Console.WriteLine(new string('-', 70));

    for (int i = 0; i < totalReservas; i++)
    {
        Console.WriteLine($"{numeroReserva[i],-8} {nombreReserva[i],-20} {emailReserva[i],-30} {asientoReserva[i],-8}");
    }
}
