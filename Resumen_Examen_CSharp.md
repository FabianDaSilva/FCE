# Resumen Examen C#


## 1. Tipos de dato y variables

```csharp
int edad = 25;
double promedio = 7.5;
string nombre = "Ana";
bool aprobado = true;
char letra = 'A';
```

**Constante:**
```csharp
const double PI = 3.14159;
```

**Conversiones frecuentes:**
```csharp
int n;
int.TryParse(Console.ReadLine(), out n);      // string → int

double d;
double.TryParse(Console.ReadLine(), out d);   // string → double

string s = n.ToString();   // int → string
int x = (int)3.9;          // cast → resultado: 3 (trunca)
```

---

## 2. Entrada / Salida

```csharp
Console.Write("Ingrese nombre: ");       // sin salto de línea
Console.WriteLine("Hola " + nombre);    // con salto de línea
string entrada = Console.ReadLine();
```

---

## 3. Estructuras de decisión

```csharp
// if / else if / else
if (nota >= 6) {
    Console.WriteLine("Aprobado");
} else if (nota >= 4) {
    Console.WriteLine("Recuperatorio");
} else {
    Console.WriteLine("Desaprobado");
}

// switch
switch (opcion) {
    case 1:
        Console.WriteLine("Alta");
        break;
    case 2:
        Console.WriteLine("Consulta");
        break;
    default:
        Console.WriteLine("Opción inválida");
        break;
}
```

**Operadores lógicos:**
| Operador | Significado |
|----------|-------------|
| `&&`     | AND         |
| `\|\|`   | OR          |
| `!`      | NOT         |

---

## 4. Estructuras de repetición

```csharp
// for — cuando sabés cuántas veces
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}

// while — cuando no sabés cuántas veces
while (condicion) {
    // ...
}

// do-while — ejecuta al menos una vez (ideal para menús)
int opcion;
do {
    Console.Write("Opción: ");
    int.TryParse(Console.ReadLine(), out opcion);
} while (opcion != 0);
```

---

## 5. Menú — Planteo tipo

```csharp
int opcion;
do {
    Console.WriteLine("1. Alta");
    Console.WriteLine("2. Consulta");
    Console.WriteLine("0. Salir");
    Console.Write("Opción: ");
    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion) {
        case 1: Alta(); break;
        case 2: Consulta(); break;
        case 0: Console.WriteLine("Hasta luego"); break;
        default: Console.WriteLine("Opción inválida"); break;
    }
} while (opcion != 0);
```

---

## 6. Máximo y Mínimo — Planteo tipo

```csharp
int max = arr[0];  // inicializar con el primer elemento
int min = arr[0];

for (int i = 1; i < arr.Length; i++) {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

Console.WriteLine("Máximo: " + max);
Console.WriteLine("Mínimo: " + min);
```

> ⚠️ **Trampa común en papel:** recordá inicializar max/min con el primer elemento del arreglo, no con 0.

---

## 7. Arreglos (Arrays)

```csharp
// Declaración e inicialización
int[] numeros = new int[5];
string[] nombres = new string[10];

// Con valores
int[] datos = { 10, 20, 30, 40, 50 };

// Acceso
numeros[0] = 100;
Console.WriteLine(numeros[0]);

// Recorrer
for (int i = 0; i < numeros.Length; i++) {
    Console.WriteLine(numeros[i]);
}

// Largo del arreglo
int largo = numeros.Length;
```

### Carga de arreglo desde consola
```csharp
int[] notas = new int[5];
for (int i = 0; i < notas.Length; i++) {
    Console.Write("Nota " + (i + 1) + ": ");
    int.TryParse(Console.ReadLine(), out notas[i]);
}
```

### Arreglo 2D (Matriz)
```csharp
int[,] matriz = new int[5, 5];

// Recorrer
for (int i = 0; i < 5; i++) {
    for (int j = 0; j < 5; j++) {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
```

---

## 8. Métodos

```csharp
// Método sin retorno
static void Saludar(string nombre) {
    Console.WriteLine("Hola " + nombre);
}

// Método con retorno
static int Sumar(int a, int b) {
    return a + b;
}

// Llamada
Saludar("Ana");
int resultado = Sumar(3, 4);
```

> En papel: acordate de poner `static` porque todo vive dentro del contexto estático de `Main`.

---

## 9. Cadenas útiles

```csharp
string s = "Hola Mundo";
s.Length           // 10
s.ToUpper()        // "HOLA MUNDO"
s.ToLower()        // "hola mundo"
s.Contains("Hola") // true
s.Trim()           // saca espacios al inicio y fin
```

---

## 10. Planteo en papel — Estrategia

Cuando te den un enunciado, seguí este orden:

1. **Leer completo** antes de escribir una sola línea.
2. **Identificar:** ¿qué entra? ¿qué sale? ¿hay repetición? ¿hay condición?
3. **Elegir estructura:**
   - ¿Cantidad fija de iteraciones? → `for`
   - ¿Hasta que el usuario diga que para? → `while` o `do-while`
   - ¿Menú? → `do-while` + `switch`
   - ¿Guardar múltiples valores? → arreglo
4. **Escribir el esqueleto primero** (estructura vacía), después rellenar.
5. **Repasar bordes:** ¿qué pasa con el primer y último elemento? ¿y si el usuario ingresa 0?

### Esqueleto base de cualquier programa

```csharp
using System;

class Program {
    static void Main(string[] args) {
        // Tu código acá
    }

    // Métodos auxiliares acá abajo
    static void MiMetodo() {
        // ...
    }
}
```

---

## Checklist antes de entregar en papel

- [ ] `using System;` al inicio
- [ ] `class Program` y `static void Main`
- [ ] Llaves `{}` balanceadas
- [ ] Variables declaradas antes de usarse
- [ ] `int.TryParse()` / `double.TryParse()` en cada lectura de número
- [ ] `break` en cada `case` del `switch`
- [ ] Índices del arreglo desde `0` hasta `Length - 1`
- [ ] Max/min inicializados con `arr[0]`, no con `0`
