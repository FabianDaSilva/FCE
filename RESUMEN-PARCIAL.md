# RESUMEN PARCIAL - C#

---

## ESTRUCTURA BASE (siempre igual)

```csharp
void MiFuncion()
{
    // declarar arrays y contador
    string[] nombres = new string[200];
    int total = 0;
    string menu;

    do {
        Console.WriteLine("1.Alta\n2.Listar\n3.Salir");
        menu = Console.ReadLine() ?? "";
        switch (menu) {
            case "1": Alta(ref total, nombres); break;
            case "2": Listar(total, nombres); break;
        }
    } while (menu != "3");
}
MiFuncion();
```

---

## REGLAS DE ORO

| ❌ Error frecuente | ✅ Correcto |
|---|---|
| `if (total < 200)` para error | `if (total >= 200)` |
| `array[i] = variable` al revés | `array[indice] = variable` |
| Pasar `string nombre` como parámetro | Solo pasás arrays y `ref int` contador |
| `while (x != "A" \|\| x != "B")` | `while (x != "A" && x != "B")` |
| Olvidar `total++` al final | Siempre `total++` antes de cerrar Alta |
| Olvidar `break` en búsqueda | `return` o `break` cuando encontrás |

---

## FIRMA DE FUNCIONES

```csharp
// Solo arrays y ref contador — NUNCA variables sueltas
void Alta(ref int total, string[] nombres, string[] emails, int[] numeros) { }
void Listar(int total, string[] nombres, string[] emails) { }  // sin ref
void Buscar(int total, string[] nombres) { }                   // sin ref
```

---

## VALIDAR INPUT

```csharp
string dato;
Console.WriteLine("Ingresá dato:");
dato = Console.ReadLine() ?? "";
while (string.IsNullOrEmpty(dato))
{
    Console.WriteLine("Ingresá dato:");
    dato = Console.ReadLine() ?? "";
}
```

---

## VERIFICAR ESPACIO

```csharp
if (total >= 200)
{
    Console.WriteLine("No hay espacio");
    return;
}
```

---

## BUSCAR Y GUARDAR ÍNDICE

```csharp
int indice = -1;
for (int i = 0; i < total; i++)
{
    if (array[i] == buscado)
    {
        indice = i;
        break;
    }
}
if (indice == -1) { Console.WriteLine("No existe"); return; }
```

---

## NÚMERO AUTOMÁTICO (máximo + 1)

```csharp
int nro = 1;
for (int i = 0; i < total; i++)
{
    if (numeros[i] > nro)
        nro = numeros[i];
}
if (total > 0) nro++;
numeros[total] = nro;
```

---

## VALIDAR OPCIONES FIJAS (ej: plan)

```csharp
string plan;
do {
    Console.WriteLine("BASICO o PREMIUM:");
    plan = Console.ReadLine()?.ToUpper() ?? "";
} while (plan != "BASICO" && plan != "PREMIUM");
```

---

## BUBBLE SORT (ordenar por apellido)

```csharp
for (int i = 0; i < total - 1; i++)
{
    for (int j = 0; j < total - 1 - i; j++)
    {
        if (String.Compare(apellidos[j], apellidos[j+1]) > 0)
        {
            // intercambiar TODOS los arrays
            string temp = apellidos[j];
            apellidos[j] = apellidos[j+1];
            apellidos[j+1] = temp;
            // repetir para cada array
        }
    }
}
```

---

## MÁXIMO / MÍNIMO

```csharp
// Máximo
int indiceMax = 0;
for (int i = 1; i < total; i++)
{
    if (valores[i] > valores[indiceMax])
        indiceMax = i;
}
Console.WriteLine(nombres[indiceMax]);

// Mínimo alfabético (fecha más próxima)
int indiceMin = 0;
for (int i = 1; i < total; i++)
{
    if (String.Compare(fechas[i], fechas[indiceMin]) < 0)
        indiceMin = i;
}
```

---

## BUSCAR FILA VACÍA (cuando hay borrados)

```csharp
int filaVacia = -1;
for (int i = 0; i < 500; i++)
{
    if (string.IsNullOrEmpty(array[i]))
    {
        filaVacia = i;
        break;
    }
}
if (filaVacia == -1) { Console.WriteLine("No hay espacio"); return; }
```

---

## PEDIR INT CON TRYPARSE

```csharp
string input;
int numero;
do {
    Console.WriteLine("Ingresá un número:");
    input = Console.ReadLine() ?? "";
} while (!int.TryParse(input, out numero));
```

---

## BORRAR (poner null/0)

```csharp
nombres[i] = null!;
emails[i] = null!;
numeros[i] = 0;   // int no puede ser null
```

---

**Leé el enunciado COMPLETO antes de escribir una línea.**
**Revisá la condición de espacio antes de entregar.**
**`total++` siempre al final del Alta.**
