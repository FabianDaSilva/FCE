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

    default:
        Console.WriteLine("No hay mas ejercicios para ejecutar");
        break;
}

static void Ejercicio1()
{
    // Stock de productos
    // Una ferretería necesita registrar código, descripción y precio de sus productos.
    // - Alta de productos
    // - Buscar producto por código y mostrar sus datos
    // - Mostrar el producto más caro y el más barato

    string[] lista_codigo = new string[10];
    string[] lista_descripcion = new string[10];
    double[] lista_precio = new double[10];
    string menu;
    int totalProductos = 0;


    System.Console.WriteLine("====================");
    System.Console.WriteLine("Stock de productos");
    System.Console.WriteLine("====================");
    do
    {
        System.Console.WriteLine("Por favor selecciona una opcion");
        System.Console.WriteLine("1.Alta \n 2.Buscar \n 3.Mostrar producto más caro");
        menu = Console.ReadLine() ?? "";

        while (String.IsNullOrEmpty(menu))
        {
            System.Console.WriteLine("Selecciona una opcion valida: ");
            menu = Console.ReadLine() ?? "";
        }

        switch (menu)
        {
            case "1":
                Alta(lista_codigo, lista_descripcion, lista_precio, ref totalProductos);
                break;
            case "2":
                Buscar(lista_codigo, lista_descripcion, lista_precio, totalProductos);
                break;
            case "3":
                masCaroMasBarato(lista_precio, totalProductos, lista_codigo, lista_descripcion);
                break;
            default: break;
        }
    } while (menu != "4");



    static void Alta(string[] lista_codigo, string[] lista_descripcion, double[] lista_precio, ref int totalProductos)
    {
        string continuar;
        System.Console.WriteLine("Siga las instruccion para cargar los productos.");


        do
        {
            string codigo, descripcion;
            double precio;

            System.Console.WriteLine("Por favor ingresa el codigo: ");
            codigo = Console.ReadLine() ?? "";
            while (string.IsNullOrEmpty(codigo))
            {
                System.Console.WriteLine("Ingresar codigo: ");
            }
            lista_codigo[totalProductos] = codigo;

            System.Console.WriteLine("Por favor ingresa la descripcion: ");
            descripcion = Console.ReadLine() ?? "";
            while (string.IsNullOrEmpty(descripcion))
            {
                System.Console.WriteLine("Ingresar descripcion: ");
            }
            lista_descripcion[totalProductos] = descripcion;

            do
            {
                System.Console.WriteLine("Por favor ingresa un precio: ");
            } while (!double.TryParse(Console.ReadLine(), out precio) || precio < 0);

            lista_precio[totalProductos] = precio;

            totalProductos++;

            System.Console.WriteLine("Desea continuar?:\n S(Si)\nN(no)");
            continuar = Console.ReadLine()?.ToUpper() ?? "";
        } while (continuar == "S");

    }

    static void Buscar(string[] lista_codigo, string[] lista_descripcion, double[] lista_precio, int totalProductos)
    {
        System.Console.WriteLine("Por favor ingresa el codigo para buscar: ");
        string buscarPalabra;
        buscarPalabra = Console.ReadLine() ?? "";

        while (string.IsNullOrEmpty(buscarPalabra))
        {
            System.Console.WriteLine("Ingresa un codigo: ");
            buscarPalabra = Console.ReadLine() ?? "";

        }


        for (int i = 0; i < totalProductos; i++)
        {
            if (lista_codigo[i] == buscarPalabra)
            {
                System.Console.WriteLine($"\n =================================\nProducto encontrado: \nCodigo: {lista_codigo[i]}\nDescripcion: {lista_descripcion[i]}\nPrecio: {lista_precio[i]}\n=================================");
            }

        }
        System.Console.WriteLine("No hay resultados..");


    }

    static void masCaroMasBarato(double[] lista_precio, int totalProductos, string[] lista_codigo, string[] lista_descripcion)
    {
        double precioCaro = lista_precio[0];
        double precioBarato = lista_precio[0];
        int indiceCaro = 0;
        int indiceBarato = 0;

        for (int i = 1; i < totalProductos; i++)
        {
            if (lista_precio[i] > precioCaro)
            {
                precioCaro = lista_precio[i];
                indiceCaro = i;
            }
            if (lista_precio[i] < precioBarato)
            {
                precioBarato = lista_precio[i];
                indiceBarato = i;
            }
        }

        Console.WriteLine($"Más caro: {lista_codigo[indiceCaro]} - {lista_descripcion[indiceCaro]} - ${precioCaro}");
        Console.WriteLine($"Más barato: {lista_codigo[indiceBarato]} - {lista_descripcion[indiceBarato]} - ${precioBarato}");
    }

}

static void Ejercicio2()
{
    // Registro de empleados
    // Una empresa necesita registrar legajo, nombre y sueldo de empleados.
    // - Cargar empleados hasta que el usuario no quiera continuar
    // - Mostrar los empleados que cobran más que el promedio
    // - Mostrar el empleado con mayor y menor sueldo
}

static void Ejercicio3()
{
    // Votación
    // Registrar nombre del votante y candidato elegido (A, B o C).
    // - Cuántos votos obtuvo cada candidato
    // - Cuál ganó
    // - Porcentaje de votos de cada uno
}

static void Ejercicio4()
{
    // Biblioteca - Estilo parcial real
    // Registrar código, título y autor de libros. Menú con:
    // - Alta de libro
    // - Buscar por título
    // - Listar todos ordenados alfabéticamente por título
    // - Salir

    string[] lista_codigo = new string[10];
    string[] lista_titulo = new string[10];
    string[] lista_autor = new string[10];
    string menu;
    int totalLibros = 0;

    System.Console.WriteLine("================================");
    System.Console.WriteLine("Biblioteca");
    System.Console.WriteLine("================================");

    do
    {
        System.Console.WriteLine("Por favor selecciona una opcion");
        System.Console.WriteLine("1.Alta de libro\n2.Buscar por título\n3.Listar todos ordenados alfabéticamente por título\n4.Salir");
        menu = Console.ReadLine() ?? "";

        switch (menu)
        {
            case "1":
                Alta(lista_codigo, lista_titulo, lista_autor, ref totalLibros); break;
            case "2":
                Buscar(lista_codigo, lista_titulo, lista_autor, ref totalLibros); break;
            case "3":
                ListarAlfabeticamente(lista_codigo, lista_titulo, lista_autor, ref totalLibros); break;
            default: break;
        }

    } while (menu != "4");

    static void Alta(string[] lista_codigo, string[] lista_titulo, string[] lista_autor, ref int totalLibros)
    {
        string codigo, titulo, autor, continuar;
        do
        {
            System.Console.WriteLine("Por favor ingresa el codigo: ");
            codigo = Console.ReadLine() ?? "";
            while (string.IsNullOrEmpty(codigo))
            {
                System.Console.WriteLine("Ingresa un codigo.");
                codigo = Console.ReadLine() ?? "";
            }
            lista_codigo[totalLibros] = codigo;


            System.Console.WriteLine("Por favor ingresa el titulo: ");
            titulo = Console.ReadLine() ?? "";
            while (string.IsNullOrEmpty(titulo))
            {
                System.Console.WriteLine("Ingresa un titulo.");
                titulo = Console.ReadLine() ?? "";
            }
            lista_titulo[totalLibros] = titulo;


            System.Console.WriteLine("Por favor ingresa el autor: ");
            autor = Console.ReadLine() ?? "";
            while (string.IsNullOrEmpty(autor))
            {
                System.Console.WriteLine("Ingresa un autor.");
                autor = Console.ReadLine() ?? "";
            }
            lista_autor[totalLibros] = autor;
            totalLibros++;

            System.Console.WriteLine("Desea seguir cargando?\nS(Si)\nN(No)");
            continuar = Console.ReadLine()?.ToUpper() ?? "";

        } while (continuar == "S");

    }

    static void Buscar(string[] lista_codigo, string[] lista_titulo, string[] lista_autor, ref int totalLibros)
    {
        string palabra;

        System.Console.WriteLine("Ingresá el titulo a buscar: ");
        palabra = Console.ReadLine() ?? "";

        for (int i = 0; i < totalLibros; i++)
        {
            if (palabra == lista_titulo[i])
            {
                System.Console.WriteLine($"\n==================================\nHay coincidencias:\ncodigo: {lista_codigo[i]}\ntitulo: {lista_titulo[i]}\nautor: {lista_autor[i]}\n==================================");
            }
        }
    }

    static void ListarAlfabeticamente(string[] lista_codigo, string[] lista_titulo, string[] lista_autor, ref int totalLibros)
    {
        for (int i = 0; i < totalLibros; i++)
        {
            for (int j = 0; j < totalLibros - 1; j++)
            {
                if (String.Compare(lista_titulo[j], lista_titulo[j + 1]) > 0)
                {
                    string auxTitulo = lista_titulo[j];
                    lista_titulo[j] = lista_titulo[j + 1];
                    lista_titulo[j + 1] = auxTitulo;

                    string auxAutor = lista_autor[j];
                    lista_autor[j] = lista_autor[j + 1];
                    lista_autor[j + 1] = auxAutor;

                    string auxCodigo = lista_codigo[j];
                    lista_codigo[j] = lista_codigo[j + 1];
                    lista_codigo[j + 1] = auxCodigo;
                }
            }

        }
        for (int i = 0; i < totalLibros; i++)
        {
            System.Console.WriteLine($"==================================\nOrdenados alfabeticamente:\ncodigo: {lista_codigo[i]}\ntitulo: {lista_titulo[i]}\nautor: {lista_autor[i]}\n==================================");
        }

    }
}

static void Ejercicio5()
{
    int[] numeroReserva = new int[200];
    string[] nombreReserva = new string[200];
    string[] emailReserva = new string[200];
    string[] asientoReserva = new string[200];

    string[] lista_filas = new string[20];
    lista_filas = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
    int[] lista_hileras = new int[10];
    int totalReservas = 0;

    string menu;
    System.Console.WriteLine("Por favor seleccione una opcion: ");


    do
    {
        Console.WriteLine("1.Alta de reserva\n2.Listar reserva\n3.Salir");
        menu = Console.ReadLine() ?? "";
        switch (menu)
        {
            case "1":
                AltaDeReserva(lista_filas, lista_hileras, asientoReserva, numeroReserva, nombreReserva, emailReserva, ref totalReservas);
                break;
            case "2":
                ListarReservas(totalReservas, nombreReserva, emailReserva, asientoReserva, numeroReserva); break;
            default: break;
        }



        System.Console.WriteLine("");
    } while (menu != "3");


    void AltaDeReserva(string[] lista_filas, int[] lista_hileras, string[] asientoReserva, int[] numeroReserva, string[] nombreReserva, string[] emailReserva, ref int totalReservas)

    {
        string nombre, email, asientoIngresado;

        void GenerarAsientos(string[] lista_filas, int[] lista_hilera, string[] asientoReserva)
        {
            int totalReserva = 0;
            for (int i = 0; i < lista_filas.Length; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    bool ocupado = false;
                    string asiento = $"{lista_filas[i]}{j}";

                    for (int k = 0; k < totalReserva; k++)
                    {
                        if (asientoReserva[k] == $"{lista_filas[i]}{j}")
                        {
                            ocupado = true;
                        }

                    }
                    if (!ocupado)
                    {
                        System.Console.WriteLine($"Asiento disponible: {asiento}");
                    }
                }
            }
        }


        if (totalReservas >= 200)
        {
            System.Console.WriteLine("No hay espacio disponible");
            return;
        }

        System.Console.WriteLine("Por favor ingresa tu nombre: ");
        nombre = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(nombre))
        {
            System.Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine() ?? "";

        }

        System.Console.WriteLine("Por favor ingresa tu email: ");
        email = Console.ReadLine() ?? "";
        while (string.IsNullOrEmpty(email))
        {
            System.Console.WriteLine("Ingresa tu email: ");
            email = Console.ReadLine() ?? "";

        }

        GenerarAsientos(lista_filas, lista_hileras, asientoReserva);

        bool asientoOcupado = false;

        do
        {
            Console.WriteLine("Ingresá un asiento: ");
            asientoIngresado = Console.ReadLine()?.ToUpper() ?? "";
            asientoOcupado = false;
            for (int k = 0; k < totalReservas; k++)
            {
                if (asientoReserva[k] == asientoIngresado)
                {
                    asientoOcupado = true;
                    break;
                }
            }
            if (asientoOcupado)
            {
                System.Console.WriteLine("Asiento ocupado, ingresa otro: ");
            }
        } while (asientoOcupado || string.IsNullOrEmpty(asientoIngresado));



        int nroReserva = 1;
        for (int k = 0; k < totalReservas; k++)
        {
            if (numeroReserva[k] > nroReserva)
                nroReserva = numeroReserva[k];
        }
        if (totalReservas > 0)
            nroReserva++;


        numeroReserva[totalReservas] = nroReserva;
        nombreReserva[totalReservas] = nombre;
        emailReserva[totalReservas] = email;
        asientoReserva[totalReservas] = asientoIngresado;
        totalReservas++;



    }

    void ListarReservas(int totalReservas, string[] nombreReserva, string[] emailReserva, string[] asientoReserva, int[] numeroReserva)
    {
        for (int reservados = 0; reservados < totalReservas; reservados++)
        {
            System.Console.WriteLine($"Asientos reservados: \n=========================\nNombre:{nombreReserva[reservados]}\n Email: {emailReserva[reservados]}\nAsiento:{asientoReserva[reservados]}\nNumero de reserva: {numeroReserva[reservados]}\n=========================");
        }
    }

}