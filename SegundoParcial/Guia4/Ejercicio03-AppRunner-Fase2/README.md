# Ejercicio 03 — AppRunner (Fase 2)

## Enunciado

Extender el AppRunner de la Fase 1 agregando historial de sesiones.

### Cambios respecto a Fase 1
- La clase `Runner` ahora guarda cada sesión individualmente en un arreglo (máximo 50 sesiones)
- Nuevo método `ObtenerSesion(int indice)` → retorna los km de esa sesión
- Propiedad `CantidadSesiones` → cantidad de sesiones registradas

### Nuevo ítem de menú
- `4` — Listar sesiones (mostrar número de sesión y km de cada una)

---

## Conceptos que se practican
- Arreglo de datos dentro de una clase (encapsulado)
- Gestión del índice de carga dentro de la clase
- Exposición controlada de datos internos mediante métodos/propiedades
