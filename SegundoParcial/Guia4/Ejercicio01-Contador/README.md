# Ejercicio 01 — Contador

## Enunciado

Crear una clase `Contador` que permita llevar la cuenta de incrementos y restablecerla a cero.

### Requerimientos de la clase `Contador`
- Propiedad `ValorActual` (solo lectura desde afuera, solo se modifica internamente)
- Método `Incrementar()` — suma 1 al valor actual
- Método `Restablecer()` — vuelve el valor a 0

### Requerimientos del programa (menú)
El programa debe mostrar un menú con las opciones:
- `I` — Incrementar (muestra el nuevo valor)
- `R` — Restablecer (muestra el nuevo valor)
- `S` — Salir

El menú se repite hasta que el usuario elija salir. Las opciones deben aceptarse en mayúsculas o minúsculas.

---

## Conceptos que se practican
- Clase con **propiedad auto-implementada** con `private set`
- **Encapsulamiento**: el estado solo se modifica a través de métodos de la clase
- Separación entre la clase (lógica) y el `Program.cs` (interfaz/menú)

---

## Estructura esperada

```
Ejercicio01-Contador/
├── README.md           ← este archivo
└── Contador/
    ├── Contador.csproj
    ├── Program.cs      ← menú principal
    └── Contador.cs     ← clase Contador (la tenés que crear vos)
```
