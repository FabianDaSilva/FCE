// Ejercicio 01 - Contador
// Completá el menú usando la clase Contador que vas a crear en Contador.cs

static void Ejercicio01()
{
    Contador miContador = new Contador();
    string menu;

    do
    {
        System.Console.WriteLine("==================\nI.Incrementar\nR.Restablecer\nS.Salir\n==================");
        menu = Console.ReadLine()?.ToUpper() ?? "";
        while (string.IsNullOrEmpty(menu))
        {
            System.Console.WriteLine("==================\nI.Incrementar\nR.Restablecer\nS.Salir\n==================");
            menu = Console.ReadLine()?.ToUpper() ?? "";
        }

        switch (menu)
        {
            case "I":
                miContador.Incrementar();
                Console.WriteLine($"Valor actual: {miContador.ValorActual}");
                break;
            case "R":
                miContador.Restablecer();
                Console.WriteLine($"Valor actual: {miContador.ValorActual}");
                break;
        }

    } while (menu != "S");
}

Ejercicio01();