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

    default:
        Console.WriteLine("No hay mas ejercicios para ejecutar");
        break;
}

static void Ejercicio1()


{
    string? nombre = "";
    Console.WriteLine("Ingrese su nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}!");
}

static void Ejercicio2()
{
    string? nombre = "", direccion = "";

    Console.WriteLine("Por favor ingresa tu nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine("Ahora ingresa tu dirección: ");
    direccion = Console.ReadLine();

    System.Console.WriteLine($"Hola {nombre}! tu dirección es: {direccion}");
}

static void Ejercicio3()
{
    int primero, segundo;

    Console.WriteLine("Bienvenido al sistema de promedio a continuacion te vamos a pedir dos números. Dichos números deben estar entre 1 y 10");

    if (!int.TryParse(Console.ReadLine(), out primero) && primero < 0 && primero > 10)
    {
        System.Console.WriteLine("Por favor ingresa uno dentro del rango");
    }

    Console.WriteLine("Ingresa el segundo numero: ");

    if (!int.TryParse(Console.ReadLine(), out segundo) && segundo < 0 && segundo > 10)
    {
        System.Console.WriteLine("Por favor ingresa uno dentro del rango");
    }

    int promedio = primero + segundo / 2;

    System.Console.WriteLine($"El promedio es de: {promedio}");



}