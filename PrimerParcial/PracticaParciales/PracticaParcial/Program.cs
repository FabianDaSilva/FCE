// PRACTICA PARCIAL - Sistema de reservas de teatro
//
// ENUNCIADO:
// Una empresa de organización de eventos reserva asientos en un teatro con:
// - 20 filas (letras A-T, sin ñ ni ch)
// - 10 hileras (1 al 10)
// - Hasta 200 reservas
// Cada reserva almacena nombre y email de quien reservó.
//
// MENU:
// 1 - Alta de reserva
//     - Verificar si hay espacio
//     - Pedir nombre y email (no vacíos)
//     - Mostrar asientos disponibles
//     - Pedir asiento (válido y no ocupado)
//     - Asignar número de reserva (máximo + 1, o 1 si es la primera)
//     - Confirmar carga exitosa
// 2 - Listar reservas (número, nombre, email, asiento)
// 3 - Salir
//
// ARRAYS OBLIGATORIOS:
// int[] numeroReserva = new int[200];
// string[] nombreReserva = new string[200];
// string[] emailReserva = new string[200];
// string[] asientoReserva = new string[200];

void ParcialTeatro()
{
    int[] numeroReserva = new int[200];
    string[] nombreReserva = new string[200];
    string[] emailReserva = new string[200];
    string[] asientoReserva = new string[200];
    string menu;

    string[] lista_filas = new string[20];
    lista_filas = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
    int[] lista_hileras = new int[10];

    int reservaTotal = 0;

    do
    {
        System.Console.WriteLine("Selecciona una opcion\n1.Alta de reserva\n2.Listar reserva\n3.Salir");
        menu = Console.ReadLine() ?? "";

        switch (menu)
        {
            case "1":
                Alta(ref reservaTotal, numeroReserva, nombreReserva, emailReserva, asientoReserva, lista_filas); break;

            case "2":
                Listar(reservaTotal, nombreReserva, emailReserva, asientoReserva, numeroReserva); break;
        }
    } while (menu != "3");
}
ParcialTeatro();

void Alta(ref int reservaTotal, int[] numeroReserva, string[] nombreReserva, string[] emailReserva, string[] asientoReserva, string[] lista_filas)
{
    string nombre, email;


    if (reservaTotal >= 200)
    {
        System.Console.WriteLine("No hay espacio disponible");
        return;
    }

    System.Console.WriteLine("Por favor ingresa tu nombre: ");
    nombre = Console.ReadLine() ?? "";

    while (string.IsNullOrEmpty(nombre))
    {
        System.Console.WriteLine("Ingresa tu nombre");
        nombre = Console.ReadLine() ?? "";
    }
    nombreReserva[reservaTotal] = nombre;

    System.Console.WriteLine("Por favor ingresa tu email: ");
    email = Console.ReadLine() ?? "";

    while (string.IsNullOrEmpty(email))
    {
        System.Console.WriteLine("Ingresa tu email");
        email = Console.ReadLine() ?? "";
    }
    emailReserva[reservaTotal] = email;

    static void GenerarAsientos(string[] lista_filas, int reservaTotal, string[] asientoReserva)
    {
        for (int i = 0; i < lista_filas.Length; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                string asiento = $"{lista_filas[i]}{j}";
                bool ocupado = false;

                for (int k = 0; k < reservaTotal; k++)
                {
                    if (asiento == asientoReserva[k])
                    {
                        System.Console.WriteLine("Asiento no disponible");
                        ocupado = true;
                        break;

                    }
                }
                if (!ocupado)
                {
                    System.Console.WriteLine($"Asiento disponible: {asiento}");
                }
            }
        }
    }
    GenerarAsientos(lista_filas, reservaTotal, asientoReserva);

    string pedirAsiento;
    bool ocupado = false;

    do
    {
        ocupado = false;
        System.Console.WriteLine("Ingresa un asiento");
        pedirAsiento = Console.ReadLine() ?? "";

        for (int k = 0; k < reservaTotal; k++)
        {
            if (pedirAsiento == asientoReserva[k])
            {
                ocupado = true;
                System.Console.WriteLine("Asiento no disponible");
            }
        }

    } while (ocupado || string.IsNullOrEmpty(pedirAsiento));

    int nroReserva = 1;
    for (int k = 0; k < reservaTotal; k++)
    {
        if (numeroReserva[k] > nroReserva)
        {
            nroReserva = numeroReserva[k];
        }
    }
    if (reservaTotal > 0)
        nroReserva++;

    numeroReserva[reservaTotal] = nroReserva;
    asientoReserva[reservaTotal] = pedirAsiento;
    reservaTotal++;


}
void Listar(int reservaTotal, string[] nombreReserva, string[] emailReserva, string[] asientoReserva, int[] numeroReserva)
{
    for (int reservas = 0; reservas < reservaTotal; reservas++)
    {
        System.Console.WriteLine($"============\nNombre: {nombreReserva[reservas]}\nCorreo: {emailReserva[reservas]}\nReserva: {asientoReserva[reservas]}\nNumero de reserva: {numeroReserva[reservas]}\n============");
    }
}
