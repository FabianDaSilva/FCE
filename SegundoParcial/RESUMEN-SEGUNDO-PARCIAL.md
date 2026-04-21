# RESUMEN SEGUNDO PARCIAL - POO en C#

---

## ESTRUCTURA DE UNA CLASE (esqueleto base)

```csharp
class NombreClase
{
    // 1. Constantes
    const int MAX_ALGO = 100;

    // 2. Atributos privados
    private int miDato;
    private string otrodato;

    // 3. Constructor
    public NombreClase(int dato, string otro)
    {
        miDato = dato;
        otrodato = otro;
    }

    // 4. Propiedades (solo si hace falta exponer datos)
    public int MiDato { get; private set; }

    // 5. Métodos públicos
    public void HacerAlgo()
    {
        // lógica acá
    }

    public string ObtenerInfo()
    {
        return $"Dato: {miDato}, Otro: {otrodat}";
    }
}
```

---

## REGLAS DE ORO

- Todo atributo va `private`
- El constructor inicializa los atributos
- Los métodos `public` son la única forma de interactuar con el objeto desde afuera
- Nunca hacer `Console.WriteLine` dentro de una clase de negocio (solo en Program o en la clase de menú)

---

## CONSTRUCTOR

```csharp
// Sin parámetros
public Contador()
{
    valor = 0;
}

// Con parámetros
public CajaAhorro(int nroCuenta, string titular)
{
    this.nroCuenta = nroCuenta;
    this.titular = titular;
    saldo = 0;
}
```

> Cuando un parámetro tiene el mismo nombre que el atributo, usá `this.atributo` para diferenciarlos.

---

## MÉTODOS ESTÁTICOS vs DE INSTANCIA

```csharp
// Estático: no necesita objeto, se llama desde la clase directamente
static double Sumar(double a, double b) => a + b;
double resultado = Operaciones.Sumar(3, 5);

// De instancia: necesita un objeto creado
miContador.Incrementar();
```

---

## foreach (MUY IMPORTANTE)

```csharp
// Recorrer una lista/colección
List<string> nombres = new List<string>();
nombres.Add("Ana");
nombres.Add("Luis");

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
```

```csharp
// foreach con objetos propios
List<Reparacion> reparaciones = new List<Reparacion>();

foreach (Reparacion rep in reparaciones)
{
    Console.WriteLine(rep.ObtenerInfo());
}
```

> No podés modificar la variable del foreach dentro del loop. Si necesitás modificar, usá `for` con índice.

---

## LIST vs ARRAY

| | `List<T>` | `array[]` |
|---|---|---|
| Tamaño | Dinámico (crece solo) | Fijo |
| Agregar | `.Add(item)` | `arr[i] = item; i++` |
| Cantidad | `.Count` | `.Length` / contador manual |
| Recorrer | `foreach` o `for` | `foreach` o `for` |
| Cuándo usar | Cuando no sabés cuántos hay | Cuando el máximo es fijo |

```csharp
// List básico
List<string> lista = new List<string>();
lista.Add("hola");
Console.WriteLine(lista.Count);   // cantidad
Console.WriteLine(lista[0]);      // acceso por índice
lista.Remove("hola");             // eliminar
```

---

## ESTRUCTURA TÍPICA DE UN PARCIAL POO

```
Program.cs          → crea los objetos y arranca el menú
ClaseNegocio.cs     → la entidad principal (ej: Reparacion, Runner, Pedido)
ClaseControlador.cs → el menú / UI (ej: Cajero, AppRunner)
```

```csharp
// Program.cs
List<Producto> productos = new List<Producto>();
Tienda tienda = new Tienda(productos);
tienda.Ejecutar();
```

---

## MANEJO DE EXCEPCIONES

```csharp
try
{
    int resultado = int.Parse(Console.ReadLine());
    // código que puede fallar
}
catch (FormatException)
{
    Console.WriteLine("Error: ingresá un número válido");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}
finally
{
    // se ejecuta siempre (opcional)
}
```

> Preferí `int.TryParse` para validar input del usuario. Reservá `try/catch` para errores que no podés predecir.

---

## PATRONES FRECUENTES EN PARCIALES

### Buscar en una lista
```csharp
Producto encontrado = null;
foreach (Producto p in productos)
{
    if (p.Codigo == codigoBuscado)
    {
        encontrado = p;
        break;
    }
}
if (encontrado != null)
    Console.WriteLine(encontrado.ObtenerInfo());
else
    Console.WriteLine("No encontrado");
```

### Máximo de una lista
```csharp
Producto elMayor = productos[0];
foreach (Producto p in productos)
{
    if (p.Precio > elMayor.Precio)
        elMayor = p;
}
```

### Filtrar e imprimir
```csharp
foreach (Pedido p in pedidos)
{
    if (p.Estado == "pendiente")
        Console.WriteLine(p.ObtenerInfo());
}
```
