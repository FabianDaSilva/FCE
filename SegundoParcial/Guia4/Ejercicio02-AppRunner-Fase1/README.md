# Ejercicio 02 — AppRunner (Fase 1)

## Enunciado

Un corredor quiere registrar sus sesiones de entrenamiento. Crear la clase `Runner` y un programa con menú.

### Requerimientos de la clase `Runner`
- Propiedad `Objetivo` (km a recorrer en total) — mínimo 1 km, máximo 100 km
- Propiedad `KmRecorridos` (acumulado de sesiones) — solo lectura desde afuera
- Método `AgregarSesion(double km)` — suma km al acumulado (validar que km > 0)
- Método `AlcanzoObjetivo()` → retorna `true` si KmRecorridos >= Objetivo

### Requerimientos del programa (menú)
- `1` — Establecer objetivo (pedir km, validar rango 1-100)
- `2` — Agregar sesión (pedir km recorridos)
- `3` — Ver estado (mostrar objetivo, km recorridos, si alcanzó el objetivo)
- `0` — Salir

---

## Conceptos que se practican
- Validación de valores en el **setter** de una propiedad
- Constantes para límites (`const`)
- Propiedad con `private set`
- Método que retorna `bool`
