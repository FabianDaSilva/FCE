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

static void Ejercicio4()
{
    int horas, minutos, segundos, total;

    do
    {
        System.Console.WriteLine("Por favor ingresa las horas (0-23): ");
    } while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0 || horas > 23);

    do
    {
        System.Console.WriteLine("Ingresa los minutos (0-59):");
    } while (!int.TryParse(Console.ReadLine(), out minutos) || minutos < 0 || minutos > 59);

    do
    {
        System.Console.WriteLine("Ingresa los segundos (0-60): ");
    } while (!int.TryParse(Console.ReadLine(), out segundos) || segundos < 0 || segundos > 60);

    total = horas * 3600 + minutos * 60 + segundos;

    System.Console.WriteLine($"El tiempo ingresado fue: {total}");
}

static void Ejercicio5()
{
    string variable1, variable2, aux = "";

    System.Console.WriteLine("Ingresa el primer valor");
    variable1 = Console.ReadLine();
    System.Console.WriteLine("Ingresa el segundo valor");
    variable2 = Console.ReadLine();
    System.Console.WriteLine($"Checkpoint Variable1: {variable1} Variable2: {variable2}");

    aux = variable1;
    variable1 = variable2;
    variable2 = aux;

    System.Console.WriteLine($"Checkpoint intercambi de valores. Variable1: {variable1} Variable2: {variable2}");


}

static void Ejercicio6()
{
    int ladoA, ladoB, ladoC;

    System.Console.WriteLine("Ingresa el primer lado: ");
    int.TryParse(Console.ReadLine(), out ladoA);

    System.Console.WriteLine("Ingresa el segundo lado: ");
    int.TryParse(Console.ReadLine(), out ladoB);

    System.Console.WriteLine("Ingresa el tercer lado: ");
    int.TryParse(Console.ReadLine(), out ladoC);

    if (ladoA == ladoB && ladoA == ladoC)
    {
        Console.WriteLine("Es un Equilátero");
    }
    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine("Es un Isósceles");
    }
    else
    {
        Console.WriteLine("Es Escaleno");
    }


}

static void Ejercicio7()
{
    System.Console.WriteLine("");
    for (int i = 0; i < 99; i++)
    {
        if (i % 10 == 0)
        {
            System.Console.WriteLine($"Valor {i}");
        }
    }
}

static void Ejercicio8()
{
    System.Console.WriteLine("==== Ejercicio 8 ====");

    int monto = 0, total = 0;
    string continuar = "";

    do
    {
        System.Console.WriteLine("Por favor ingresar el monto: ");
        int.TryParse(Console.ReadLine(), out monto);
        total += monto;

        System.Console.WriteLine("Desea continuar? S/N: ");
        continuar = System.Console.ReadLine();

    } while (continuar.ToUpper() == "S");

    System.Console.WriteLine($"Facturacion final es de: {total}");
}