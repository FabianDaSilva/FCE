# Ejercicio 04 — AppRunner (Fase 3)

## Enunciado

Extender el AppRunner de la Fase 2 separando la lógica del menú en una clase aparte.

### Cambios respecto a Fase 2
- Crear una clase `AppRunner` que contenga toda la lógica del menú (los `Console.WriteLine`, `Console.ReadLine`, el `do-while`)
- `Program.cs` solo instancia `AppRunner` y llama a un método `Ejecutar()`
- La clase `Runner` no cambia

### Estructura de clases
- `Runner` — datos y lógica de negocio (igual que Fase 2)
- `AppRunner` — controlador del menú e interacción con el usuario
- `Program.cs` — solo punto de entrada

---

## Conceptos que se practican
- Separación de responsabilidades (SRP)
- Una clase que usa a otra clase como atributo
- Constructor de `AppRunner` que inicializa un `Runner`
