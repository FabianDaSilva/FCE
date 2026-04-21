# Ejercicio 05 — Cuenta Bancaria

## Enunciado

Crear un sistema de cajero automático con las clases `CajaAhorro` y `Cajero`.

### Requerimientos de la clase `CajaAhorro`
- Propiedad `NumeroCuenta` (solo lectura, se asigna en el constructor)
- Propiedad `Titular` (nombre del titular)
- Propiedad `Saldo` (solo lectura desde afuera)
- Método `Depositar(double monto)` → valida monto > 0, suma al saldo. Retorna mensaje de éxito o error.
- Método `Extraer(double monto)` → valida monto > 0 y que haya saldo suficiente. Retorna mensaje de éxito o error.

### Requerimientos de la clase `Cajero`
- Atributo privado de tipo `CajaAhorro`
- Constructor que recibe y asigna la cuenta
- Método `Ejecutar()` con menú:
  - `1` — Depositar
  - `2` — Extraer
  - `3` — Ver saldo
  - `0` — Salir

### Program.cs
Crear una `CajaAhorro`, crear un `Cajero` con esa cuenta, llamar a `Ejecutar()`.

---

## Conceptos que se practican
- **Constructor** con parámetros
- Propiedad de solo lectura asignada en constructor
- Método que retorna `string` (mensaje de resultado)
- Una clase que contiene a otra como atributo
- Validaciones de negocio en métodos
