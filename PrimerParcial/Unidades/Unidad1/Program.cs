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

    case "9":
        Ejercicio9(); break;

    case "10":
        Ejercicio10(); break;

    case "11":
        Ejercicio11(); break;

    case "12":
        Ejercicio12(); break;

    case "13":
        Ejercicio13(); break;

    case "14":
        Ejercicio14(); break;

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

static void Ejercicio9()
{
    /* 
    1. Ingresar:
    -nombre
    -jornal por hora
    -jornal por cantindad de horas trabajas
    -sueldo bruto
    2. A cada empleado se le retiene:
    -11% para jubilacion
    -7% por otros conceptos
     */

    string nombre;
    double jornalPorHora, jornalHoraTrabajadas, sueldoBruto, retencionJubilacion, retencionOtrosConceptos, totalRetenciones, sueldoNeto;

    static void pedirDatos(out string nombre, out double jornalPorHora, out double jornalHoraTrabajadas)
    {
        /* Nombre */
        nombre = "";
        System.Console.WriteLine("Por favor tu nombre: ");
        while (string.IsNullOrEmpty(nombre))
        {
            nombre = Console.ReadLine();
            if (string.IsNullOrEmpty(nombre))
            {
                System.Console.WriteLine("Por favor ingresa un nombre valido: ");
            }
        }

        /* Jornal */
        jornalPorHora = 0;
        System.Console.WriteLine("Ingresa tu horario de jornada: ");

        while (jornalPorHora <= 0)
        {
            double.TryParse(Console.ReadLine(), out jornalPorHora);
            if (jornalPorHora <= 0)
            {
                System.Console.WriteLine("Ingresa una jornada laboral valida: ");
            }

        }


        /* Jornal trabajadas */
        jornalHoraTrabajadas = 0;
        System.Console.WriteLine("Ingresa horas trabajadas: ");

        while (jornalHoraTrabajadas <= 0)
        {
            double.TryParse(Console.ReadLine(), out jornalHoraTrabajadas);
            if (jornalHoraTrabajadas <= 0)
            {
                System.Console.WriteLine("Horas trabajadas valida: ");

            }

        }

    }


    pedirDatos(out nombre, out jornalPorHora, out jornalHoraTrabajadas);

    static void calculoLogico(string nombre, double jornalPorHora, double jornalHoraTrabajadas)
    {
        double sueldoBruto = jornalPorHora * jornalHoraTrabajadas;
        double retencionJubilacion = sueldoBruto * 0.11;
        double retencionOtrosConceptos = sueldoBruto * 0.7;
        double totalRetenciones = retencionJubilacion + retencionOtrosConceptos;
        double sueldoNeto = sueldoBruto - totalRetenciones;

        System.Console.WriteLine($"\n--- Liquidación de {nombre} ---");
        System.Console.WriteLine($"Sueldo bruto:              ${sueldoBruto}");
        System.Console.WriteLine($"Retención jubilación:      ${retencionJubilacion}");
        System.Console.WriteLine($"Retención otros conceptos: ${retencionOtrosConceptos}");
        System.Console.WriteLine($"Total retenciones:         ${totalRetenciones}");
        System.Console.WriteLine($"Neto a cobrar:             ${sueldoNeto}");
    }
    calculoLogico(nombre, jornalPorHora, jornalHoraTrabajadas);
}

static void Ejercicio10()
{
    string registro = "", registroMax = "", registroMin = "";
    double nota, notaMax = 0, notaMin = 0;
    string continuar = "";
    bool primero = true;

    do
    {
        System.Console.WriteLine("Ingresa el registro del alumno: ");
        registro = Console.ReadLine();

        do
        {
            System.Console.WriteLine("Ingresa la nota (0-10): ");
        } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10);

        if (nota >= 7)
            System.Console.WriteLine("Promocionado");
        else if (nota >= 4)
            System.Console.WriteLine("Regularizado");
        else
            System.Console.WriteLine("Reprobado");

        if (primero)
        {
            notaMax = nota;
            notaMin = nota;
            registroMax = registro;
            registroMin = registro;
            primero = false;
        }
        else
        {
            if (nota > notaMax) { notaMax = nota; registroMax = registro; }
            if (nota < notaMin) { notaMin = nota; registroMin = registro; }
        }

        System.Console.WriteLine("Desea continuar? S/N: ");
        continuar = Console.ReadLine();

    } while (continuar.ToUpper() == "S");

    System.Console.WriteLine($"Nota maxima: Registro {registroMax} - Nota {notaMax}");
    System.Console.WriteLine($"Nota minima: Registro {registroMin} - Nota {notaMin}");
}

static void Ejercicio11()
{
    string nroFactura = "", facturaMax = "", facturaMin = "";
    double monto, montoMax = 0, montoMin = 0, totalVentas = 0;
    int cantFacturas = 0;
    string continuar = "";
    bool primero = true;

    do
    {
        System.Console.WriteLine("Ingresa el numero de factura: ");
        nroFactura = Console.ReadLine();

        do
        {
            System.Console.WriteLine("Ingresa el monto de venta: ");
        } while (!double.TryParse(Console.ReadLine(), out monto) || monto <= 0);

        totalVentas += monto;
        cantFacturas++;

        if (primero)
        {
            montoMax = monto;
            montoMin = monto;
            facturaMax = nroFactura;
            facturaMin = nroFactura;
            primero = false;
        }
        else
        {
            if (monto > montoMax) { montoMax = monto; facturaMax = nroFactura; }
            if (monto < montoMin) { montoMin = monto; facturaMin = nroFactura; }
        }

        System.Console.WriteLine("Desea continuar? S/N: ");
        continuar = Console.ReadLine();

    } while (continuar.ToUpper() == "S");

    System.Console.WriteLine($"Total de ventas: ${totalVentas}");
    System.Console.WriteLine($"Promedio por factura: ${totalVentas / cantFacturas}");
    System.Console.WriteLine($"Factura de mayor monto: {facturaMax} - ${montoMax}");
    System.Console.WriteLine($"Factura de menor monto: {facturaMin} - ${montoMin}");
}

static void Ejercicio12()
{
    const double IVA = 0.21;
    const double GASTOS_INDIRECTOS = 100000;

    string codigo = "", nombre = "", codigoMasCaro = "", codigoMasBarato = "", codigoMasRentable = "";
    double costKgMateria, gramos, porcGastosIndirectos, porcRentabilidad;
    double precioVentaMax = 0, precioVentaMin = 0, gananciaPesosMax = 0;
    string continuar = "";
    bool primero = true;

    do
    {
        System.Console.WriteLine("Codigo de articulo: ");
        codigo = Console.ReadLine();

        System.Console.WriteLine("Nombre del articulo: ");
        nombre = Console.ReadLine();

        do
        {
            System.Console.WriteLine("Costo por kilo de materia prima: ");
        } while (!double.TryParse(Console.ReadLine(), out costKgMateria) || costKgMateria <= 0);

        do
        {
            System.Console.WriteLine("Cantidad de gramos por unidad: ");
        } while (!double.TryParse(Console.ReadLine(), out gramos) || gramos <= 0);

        do
        {
            System.Console.WriteLine("Porcentaje de gastos indirectos (%): ");
        } while (!double.TryParse(Console.ReadLine(), out porcGastosIndirectos) || porcGastosIndirectos < 0);

        do
        {
            System.Console.WriteLine("Porcentaje de rentabilidad (%): ");
        } while (!double.TryParse(Console.ReadLine(), out porcRentabilidad) || porcRentabilidad < 0);

        double costoMateria = (costKgMateria / 1000) * gramos;
        double costoGastosIndirectos = GASTOS_INDIRECTOS * (porcGastosIndirectos / 100);
        double costoArticulo = costoMateria + costoGastosIndirectos;
        double ganancia = costoArticulo * (porcRentabilidad / 100);
        double precioVentaSinIVA = costoArticulo + ganancia;
        double precioVenta = precioVentaSinIVA * (1 + IVA);

        System.Console.WriteLine($"Costo del articulo: ${costoArticulo:F2}");
        System.Console.WriteLine($"Precio de venta (con IVA): ${precioVenta:F2}");

        if (primero)
        {
            precioVentaMax = precioVenta;
            precioVentaMin = precioVenta;
            gananciaPesosMax = ganancia;
            codigoMasCaro = codigo;
            codigoMasBarato = codigo;
            codigoMasRentable = codigo;
            primero = false;
        }
        else
        {
            if (precioVenta > precioVentaMax) { precioVentaMax = precioVenta; codigoMasCaro = codigo; }
            if (precioVenta < precioVentaMin) { precioVentaMin = precioVenta; codigoMasBarato = codigo; }
            if (ganancia > gananciaPesosMax) { gananciaPesosMax = ganancia; codigoMasRentable = codigo; }
        }

        System.Console.WriteLine("Desea continuar? S/N: ");
        continuar = Console.ReadLine();

    } while (continuar.ToUpper() == "S");

    System.Console.WriteLine($"Articulo mas caro: {codigoMasCaro} - ${precioVentaMax:F2}");
    System.Console.WriteLine($"Articulo mas barato: {codigoMasBarato} - ${precioVentaMin:F2}");
    System.Console.WriteLine($"Articulo mas rentable en pesos: {codigoMasRentable} - ${gananciaPesosMax:F2}");
}

static void Ejercicio13()
{
    const double VALOR_JUNIOR = 50;
    const double VALOR_SENIOR = 100;
    const double VALOR_LIDER = 150;

    double costoVentas = 0, costoSueldos = 0, costoContabilidad = 0, costoConsultas = 0;
    double gananciaVentas = 0, gananciaSueldos = 0, gananciaContabilidad = 0, gananciaConsultas = 0;
    bool cargado = false;
    string opcion = "";

    do
    {
        System.Console.WriteLine("\n=== Ejercicio 13 ===");
        System.Console.WriteLine("1. Ventas");
        System.Console.WriteLine("2. Sueldos");
        System.Console.WriteLine("3. Contabilidad");
        System.Console.WriteLine("4. Consultas gerenciales");
        System.Console.WriteLine("5. Ver resultados");
        System.Console.WriteLine("6. Salir");
        System.Console.WriteLine("Opcion: ");
        opcion = Console.ReadLine();

        if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
        {
            double horasJunior, horasSenior, horasLider, porcRentabilidad;

            do { System.Console.WriteLine("Horas junior: "); } while (!double.TryParse(Console.ReadLine(), out horasJunior) || horasJunior < 0);
            do { System.Console.WriteLine("Horas senior: "); } while (!double.TryParse(Console.ReadLine(), out horasSenior) || horasSenior < 0);
            do { System.Console.WriteLine("Horas lider: "); } while (!double.TryParse(Console.ReadLine(), out horasLider) || horasLider < 0);
            do { System.Console.WriteLine("Porcentaje de rentabilidad (%): "); } while (!double.TryParse(Console.ReadLine(), out porcRentabilidad) || porcRentabilidad < 0);

            double costo = horasJunior * VALOR_JUNIOR + horasSenior * VALOR_SENIOR + horasLider * VALOR_LIDER;
            double ganancia = costo * (porcRentabilidad / 100);

            System.Console.WriteLine($"Costo: ${costo:F2} | Ganancia: ${ganancia:F2}");

            if (opcion == "1") { costoVentas = costo; gananciaVentas = ganancia; }
            else if (opcion == "2") { costoSueldos = costo; gananciaSueldos = ganancia; }
            else if (opcion == "3") { costoContabilidad = costo; gananciaContabilidad = ganancia; }
            else { costoConsultas = costo; gananciaConsultas = ganancia; }

            cargado = true;
        }
        else if (opcion == "5" && cargado)
        {
            double totalCostos = costoVentas + costoSueldos + costoContabilidad + costoConsultas;
            double promedio = totalCostos / 4;

            string sistemaMaxGanancia = "Ventas";
            double maxGanancia = gananciaVentas;
            string sistemaMinGanancia = "Ventas";
            double minGanancia = gananciaVentas;

            if (gananciaSueldos > maxGanancia) { maxGanancia = gananciaSueldos; sistemaMaxGanancia = "Sueldos"; }
            if (gananciaContabilidad > maxGanancia) { maxGanancia = gananciaContabilidad; sistemaMaxGanancia = "Contabilidad"; }
            if (gananciaConsultas > maxGanancia) { maxGanancia = gananciaConsultas; sistemaMaxGanancia = "Consultas gerenciales"; }

            if (gananciaSueldos < minGanancia) { minGanancia = gananciaSueldos; sistemaMinGanancia = "Sueldos"; }
            if (gananciaContabilidad < minGanancia) { minGanancia = gananciaContabilidad; sistemaMinGanancia = "Contabilidad"; }
            if (gananciaConsultas < minGanancia) { minGanancia = gananciaConsultas; sistemaMinGanancia = "Consultas gerenciales"; }

            System.Console.WriteLine($"Costo ventas: ${costoVentas:F2}");
            System.Console.WriteLine($"Costo sueldos: ${costoSueldos:F2}");
            System.Console.WriteLine($"Costo contabilidad: ${costoContabilidad:F2}");
            System.Console.WriteLine($"Costo consultas gerenciales: ${costoConsultas:F2}");
            System.Console.WriteLine($"Costo promedio: ${promedio:F2}");
            System.Console.WriteLine($"Mayor ganancia: {sistemaMaxGanancia} - ${maxGanancia:F2}");
            System.Console.WriteLine($"Menor ganancia: {sistemaMinGanancia} - ${minGanancia:F2}");
        }

    } while (opcion != "6");
}

static void Ejercicio14()
{
    double valor = 0;
    string opcion = "";

    do
    {
        System.Console.WriteLine("\n=== Menu principal ===");
        System.Console.WriteLine("1. Establecer valor");
        System.Console.WriteLine("2. Visualizar valor actual");
        System.Console.WriteLine("3. Realizar una operacion");
        System.Console.WriteLine("4. Salir");
        System.Console.WriteLine("Opcion: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                do { System.Console.WriteLine("Ingresa el valor: "); } while (!double.TryParse(Console.ReadLine(), out valor));
                break;
            case "2":
                System.Console.WriteLine($"Valor actual: {valor}");
                break;
            case "3":
                string subOpcion = "";
                do
                {
                    System.Console.WriteLine("\n=== Operaciones ===");
                    System.Console.WriteLine("S. Sumar 1");
                    System.Console.WriteLine("R. Restar 1");
                    System.Console.WriteLine("V. Volver al menu principal");
                    System.Console.WriteLine("Opcion: ");
                    subOpcion = Console.ReadLine().ToUpper();

                    if (subOpcion == "S") { valor++; System.Console.WriteLine($"Valor: {valor}"); }
                    else if (subOpcion == "R") { valor--; System.Console.WriteLine($"Valor: {valor}"); }

                } while (subOpcion != "V");
                break;
        }

    } while (opcion != "4");
}
