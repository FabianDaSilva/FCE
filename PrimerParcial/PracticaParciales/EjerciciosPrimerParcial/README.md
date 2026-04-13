# Ejercicios Primer Parcial

Ejercicios de práctica estilo parcial para repasar arrays, funciones, menús y algoritmos.

---

**Ejercicio 1 — Stock de productos**
Una ferretería necesita registrar código, descripción y precio de sus productos. El sistema debe permitir:
- Alta de productos
- Buscar producto por código y mostrar sus datos
- Mostrar el producto más caro y el más barato

---

**Ejercicio 2 — Registro de empleados**
Una empresa necesita registrar legajo, nombre y sueldo de empleados. El sistema debe:
- Cargar empleados hasta que el usuario no quiera continuar
- Mostrar los empleados que cobran más que el promedio
- Mostrar el empleado con mayor y menor sueldo

---

**Ejercicio 3 — Votación**
Un sistema de votación permite registrar el nombre del votante y el candidato elegido (A, B o C). Al finalizar mostrar:
- Cuántos votos obtuvo cada candidato
- Cuál ganó
- Porcentaje de votos de cada uno

---

**Ejercicio 4 — Estilo parcial real**
Una biblioteca registra código, título y autor de libros. El sistema debe tener menú con:
- Alta de libro
- Buscar por título
- Listar todos ordenados alfabéticamente por título
- Salir

---

**Ejercicio 5 — Modelo parcial: Teatro (CRONOMETRADO)**
Una empresa de organización de eventos reserva asientos en un teatro con 20 filas (primeras 20 letras del abecedario sin ñ ni ch) y 10 hileras (1 al 10). Puede haber hasta 200 reservas. Cada reserva almacena nombre y email de quien reservó. El sistema debe tener menú con:
- Alta de reserva: verifica espacio, solicita nombre y email (no vacíos), muestra asientos disponibles, solicita asiento (válido y disponible), asigna número de reserva (máximo + 1 o 1 si es la primera)
- Listar reservas: muestra número, nombre, email y asiento
- Salir

Estructura de arrays obligatoria:
```csharp
int[] numeroReserva = new int[200];
string[] nombreReserva = new string[200];
string[] emailReserva = new string[200];
string[] asientoReserva = new string[200];
```
