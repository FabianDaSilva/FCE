static void Ejercicio01b()
{
    string menu;

    do
    {
        Console.WriteLine("==================\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n0.Salir\n==================");
        menu = Console.ReadLine() ?? "";

        if (menu == "0") break;

        Console.WriteLine("Ingresá el valor A:");
        double a;
        while (!double.TryParse(Console.ReadLine(), out a))
            Console.WriteLine("Valor inválido, ingresá de nuevo:");

        Console.WriteLine("Ingresá el valor B:");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b))
            Console.WriteLine("Valor inválido, ingresá de nuevo:");

        double resultado;

        switch (menu)
        {
            case "1":
                resultado = Operaciones.Sumar(a, b);
                Console.WriteLine($"Resultado: {resultado}");
                break;
                  case "2":
                      resultado = Operaciones.Restar(a, b);
                      Console.WriteLine($"Resultado: {resultado}");
                      break;
                  case "3":
                      resultado = Operaciones.Multiplicar(a, b);
                      Console.WriteLine($"Resultado: {resultado}");
                      break;
                  case "4":
                      resultado = Operaciones.Dividir(a, b);
                      Console.WriteLine($"Resultado: {resultado}");
                      break;
                  default:
                      Console.WriteLine("Opción inválida");
                      break;
        }

    } while (menu != "0");
}

Ejercicio01b();
