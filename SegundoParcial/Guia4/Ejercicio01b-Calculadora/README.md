# Ejercicio 01b — Calculadora

## Enunciado

Crear una clase `Operaciones` con métodos para las 4 operaciones aritméticas básicas, y un `Program.cs` con menú que las use.

### Requerimientos de la clase `Operaciones`
- Método `Sumar(double a, double b)` → retorna la suma
- Método `Restar(double a, double b)` → retorna la resta
- Método `Multiplicar(double a, double b)` → retorna el producto
- Método `Dividir(double a, double b)` → retorna el cociente (validar que b no sea 0)

### Requerimientos del programa (menú)
- `1` — Sumar
- `2` — Restar
- `3` — Multiplicar
- `4` — Dividir
- `0` — Salir

Para cada operación: pedir los dos números, mostrar el resultado.

---

## Conceptos que se practican
- Métodos **estáticos** en una clase
- Separación de lógica de negocio vs. interfaz
- Validación de entrada (división por cero)
