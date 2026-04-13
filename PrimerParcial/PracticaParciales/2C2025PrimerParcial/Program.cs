// 1er PARCIAL - 2do Cuatrimestre 2025
// Maternidad "JULITO"
//
// DATOS:
// - 500 camas, 20 quirófanos, hasta 500 pacientes
// - Cada paciente: DNI (string, único), Nombre, Apellido,
//   Quirófano asignado, Cama asignada, Estado
// - Estados: "Esperando quirófano" → "Esperando cama" → "Esperando alta" → "Alta"
//
// ARRAYS:
// - Quirófanos: hasta 20 (ej: "Q/02/002", "Q/02/003")
// - Camas: hasta 500 (ej: "901", "902", "1016")
//
// MENÚ:
// A - Alta de paciente
//     - Buscar fila vacía (DNI null/vacío). Si no hay → error
//     - Pedir DNI. Si ya existe → error
//     - Pedir nombre y apellido (no vacíos)
//     - Guardar datos, estado = "Esperando quirófano"
//
// B - Asignar quirófano
//     - Pedir DNI. Si no existe → error
//     - Si no está en "Esperando quirófano" → error
//     - Mostrar quirófanos, pedir uno. Si ya asignado a otro → error
//     - Guardar quirófano, estado = "Esperando cama"
//
// C - Asignar cama
//     - Pedir DNI. Si no existe → error
//     - Si no está en "Esperando cama" → error
//     - Mostrar camas, pedir una. Si ya asignada a otro → error
//     - Guardar cama, quirófano = null, estado = "Esperando alta"
//
// D - Alta (solo llamar, no desarrollar)
//     - Pedir DNI. Si no existe → error
//     - Si no está en "Esperando alta" → error
//     - Cama = null, estado = "Alta"
//
// E - Archivar (solo llamar, no desarrollar)
//     - Recorrer todos los pacientes
//     - Los que estén en "Alta" → poner null en todos sus datos
//
// S - Salir
//
// SE SOLICITA: desarrollar A, B, C, E y S. Llamar D sin desarrollar.
// VALIDAR TODOS LOS INGRESOS DE DATOS.

void MaternidadJulito()
{
    // DATOS:
    // - 500 camas, 20 quirófanos, hasta 500 pacientes
    // - Cada paciente: DNI (string, único), Nombre, Apellido,
    //   Quirófano asignado, Cama asignada, Estado
    // - Estados: "Esperando quirófano" → "Esperando cama" → "Esperando alta" → "Alta"
    //
    // ARRAYS:
    // - Quirófanos: hasta 20 (ej: "Q/02/002", "Q/02/003")
    // - Camas: hasta 500 (ej: "901", "902", "1016")
    //
    string menu;


    string[] pacientes_dni = new string[500];
    string[] pacientes_nombre = new string[500];
    string[] pacientes_apellido = new string[500];
    string[] pacientes_quirofano = new string[500];
    string[] pacientes_cama = new string[500];
    string[] pacientes_estado = new string[500];
    string[] quirofanos = new string[] { "Q/02/001", "Q/02/002", "Q/02/003", "Q/02/004", "Q/02/005" };
    string[] camas = new string[] { "901", "902", "903", "1016", "1017", "1018", "1020" };



    do
    {
        System.Console.WriteLine("A.Alta de paciente\nB.Asignar quirófano\nC.Asignar cama\nD.Alta\nE.Archivar\nS.Salir");
        menu = Console.ReadLine()?.ToUpper() ?? "";

        switch (menu)
        {
            case "A":
                AltaPaciente(pacientes_dni, pacientes_nombre, pacientes_apellido, pacientes_quirofano, pacientes_cama, pacientes_estado); break;
            case "B":
                AsignarQuirofano(pacientes_dni, pacientes_estado, quirofanos, pacientes_quirofano); break;
            case "C":
                AsignarCama(pacientes_dni, pacientes_estado, pacientes_quirofano, pacientes_cama, camas); break;
            case "D":
                Alta(pacientes_dni, pacientes_cama, pacientes_estado); break;
            case "E":
                Archivar(pacientes_dni, pacientes_nombre, pacientes_apellido, pacientes_quirofano, pacientes_cama, pacientes_estado); break;

        }

    } while (menu != "S");
}

MaternidadJulito();

void AltaPaciente(string[] pacientes_dni, string[] pacientes_nombre, string[] pacientes_apellido, string[] pacientes_quirofano, string[] pacientes_cama, string[] pacientes_estado)
{
    // 1. Buscar fila vacía → recorrer buscando string.IsNullOrEmpty(pacientes_dni[i])
    //    Si filaVacia == -1 al terminar → error y return
    int filaVacia = -1;
    for (int i = 0; i < 500; i++)
    {
        if (string.IsNullOrEmpty(pacientes_dni[i]))
        {
            filaVacia = i;
            break;
        }
    }
    if (filaVacia == -1)
    {
        System.Console.WriteLine("No hay espacio disponible");
        return;
    }

    // 2. Pedir DNI → buscar si ya existe en pacientes_dni
    //    Si existe → error y return

    string pedirDni;
    System.Console.WriteLine("Ingresa tu DNI: ");
    pedirDni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirDni))
    {
        System.Console.WriteLine("Por favor ingresa tu dni");
        pedirDni = Console.ReadLine() ?? "";

    }

    for (int i = 0; i < pacientes_dni.Length; i++)
    {
        if (pedirDni == pacientes_dni[i])
        {
            System.Console.WriteLine("Este DNI ya existe");
            return;
        }
    }
    pacientes_dni[filaVacia] = pedirDni;

    // 3. Pedir nombre (while IsNullOrEmpty)
    string pedirNombre;
    System.Console.WriteLine("Ingresa tu Nombre: ");
    pedirNombre = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirNombre))
    {
        System.Console.WriteLine("Por favor ingresa tu Nombre");
        pedirNombre = Console.ReadLine() ?? "";

    }
    pacientes_nombre[filaVacia] = pedirNombre;


    // 4. Pedir apellido (while IsNullOrEmpty)
    string pedirApellido;
    System.Console.WriteLine("Ingresa tu Apellido: ");
    pedirApellido = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirApellido))
    {
        System.Console.WriteLine("Por favor ingresa tu Apellido");
        pedirApellido = Console.ReadLine() ?? "";

    }
    pacientes_apellido[filaVacia] = pedirApellido;


    // 5. Guardar todo en filaVacia
    //    pacientes_estado[filaVacia] = "Esperando quirófano"
    pacientes_estado[filaVacia] = "Esperando quirófano";
}

void AsignarQuirofano(string[] pacientes_dni, string[] pacientes_estado, string[] quirofanos, string[] pacientes_quirofano)
{
    // Pedir DNI → buscar si existe. Si no → error y return
    string pedirDni;
    System.Console.WriteLine("Por favor ingresa tu DNI: ");
    pedirDni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirDni))
    {
        System.Console.WriteLine("Ingresa tu DNI: ");
        pedirDni = Console.ReadLine() ?? "";
    }

    int indicePaciente = -1;
    for (int i = 0; i < pacientes_dni.Length; i++)
    {
        if (pacientes_dni[i] == pedirDni)
        {
            indicePaciente = i;
            break;
        }
    }
    if (indicePaciente == -1)
    {
        System.Console.WriteLine("Este DNI no existe");
        return;
    }
    if (pacientes_estado[indicePaciente] != "Esperando quirófano")
    {
        System.Console.WriteLine("Estado inválido");
        return;
    }


    // Pedir quirófano → verificar que no esté asignado a otro paciente. Si está → error y volver a pedir
    string pedirQuirofano;
    bool quirofanoOcupado;
    do
    {
        quirofanoOcupado = false;

        // mostrar quirófanos
        for (int q = 0; q < quirofanos.Length; q++)
            System.Console.WriteLine(quirofanos[q]);

        System.Console.WriteLine("Ingresa un quirofano: ");
        pedirQuirofano = Console.ReadLine() ?? "";

        // validar que esté en la lista
        bool existe = false;
        for (int q = 0; q < quirofanos.Length; q++)
        {
            if (quirofanos[q] == pedirQuirofano) { existe = true; break; }
        }
        if (!existe) { Console.WriteLine("Quirófano inválido"); quirofanoOcupado = true; continue; }

        // validar que no esté asignado a otro paciente
        for (int k = 0; k < pacientes_quirofano.Length; k++)
        {
            if (pacientes_quirofano[k] == pedirQuirofano)
            {
                Console.WriteLine("Quirófano ya asignado");
                quirofanoOcupado = true;
                break;
            }
        }

    } while (string.IsNullOrEmpty(pedirQuirofano) || quirofanoOcupado);

    // Guardar quirófano en el paciente, cambiar estado a "Esperando cama"        
    pacientes_quirofano[indicePaciente] = pedirQuirofano;
    pacientes_estado[indicePaciente] = "Esperando cama";
}


void AsignarCama(string[] pacientes_dni, string[] pacientes_estado, string[] pacientes_quirofano, string[] pacientes_cama, string[] camas)
{
    // 1. Pedir DNI (validar no vacío)
    string pedirDni;
    System.Console.WriteLine("Por favor ingresa tu dni: ");
    pedirDni = Console.ReadLine() ?? "";
    while (string.IsNullOrEmpty(pedirDni))
    {
        System.Console.WriteLine("Ingresa tu dni: ");
        pedirDni = Console.ReadLine() ?? "";
    }

    // 2. Buscar DNI en pacientes_dni → guardar indicePaciente
    //    Si indicePaciente == -1 → error y return
    int indicePaciente = -1;
    for (int i = 0; i < pacientes_dni.Length; i++)
    {
        if (pacientes_dni[i] == pedirDni)
        {
            indicePaciente = i;
            break;
        }
    }
    if (indicePaciente == -1)
    {
        System.Console.WriteLine("Este DNI no existe");
        return;
    }
    // 3. Si pacientes_estado[indicePaciente] != "Esperando cama" → error y return   
    if (pacientes_estado[indicePaciente] != "Esperando cama")
    {
        System.Console.WriteLine("Estado inválido");
        return;
    }
    // 4. do/while para pedir cama:
    //    - Mostrar todas las camas disponibles
    //    - Pedir cama (validar no vacía)
    //    - Validar que exista en el array camas
    //    - Validar que no esté asignada a otro paciente (buscar en pacientes_cama)
    //    - Si alguna validación falla → camaOcupada = true
    string pedirCama;
    bool camaOcupada;
    do
    {
        camaOcupada = false;

        for (int c = 0; c < camas.Length; c++)
            System.Console.WriteLine($"Camas disponibles: {camas[c]}");

        System.Console.WriteLine("Por favor ingresa una cama: ");
        pedirCama = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(pedirCama))
        {
            System.Console.WriteLine("Ingresa una cama: ");
            pedirCama = Console.ReadLine() ?? "";
        }

        // validar que exista en la lista
        bool existe = false;
        for (int c = 0; c < camas.Length; c++)
        {
            if (camas[c] == pedirCama) { existe = true; break; }
        }
        if (!existe) { Console.WriteLine("Cama inválida"); camaOcupada = true; continue; }

        // validar que no esté asignada a otro paciente
        for (int k = 0; k < pacientes_cama.Length; k++)
        {
            if (pacientes_cama[k] == pedirCama)
            {
                Console.WriteLine("Cama ya asignada");
                camaOcupada = true;
                break;
            }
        }

    } while (camaOcupada);

    // 5. Guardar
    pacientes_cama[indicePaciente] = pedirCama;
    pacientes_quirofano[indicePaciente] = null!;
    pacientes_estado[indicePaciente] = "Esperando alta";
}
void Alta(string[] pacientes_dni, string[] pacientes_cama, string[] pacientes_estado) { }
void Archivar(string[] pacientes_dni, string[] pacientes_nombre, string[] pacientes_apellido, string[] pacientes_quirofano, string[] pacientes_cama, string[] pacientes_estado)
{
    for (int i = 0; i < pacientes_dni.Length; i++)
    {
        if (pacientes_estado[i] == "Alta")
        {
            pacientes_dni[i] = null!;
            pacientes_nombre[i] = null!;
            pacientes_apellido[i] = null!;
            pacientes_quirofano[i] = null!;
            pacientes_cama[i] = null!;
            pacientes_estado[i] = null!;
        }
    }
}