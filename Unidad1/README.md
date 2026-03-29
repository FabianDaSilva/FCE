# Ejercicios

## Parte 1

---

**1.** Escribir y ejecutar un programa que pida un nombre y una dirección, y los muestre en pantalla.

> **Recomendación:** Recordar incluir el mensaje "Presionar una tecla para salir", y la correspondiente instrucción para que el programa espere una tecla. Así será posible ver el resultado antes de que el programa se cierre instantáneamente.

---

**2.** Escribir y ejecutar un programa que pida un nombre y una dirección, y los muestre en pantalla. El programa debe validar que los datos se completen.

> **Recomendación:** Al momento de validar, volver a solicitar el dato hasta tanto esté correcto (un tipo de bucle que evalúe salir al final de cada ciclo, e incluirle un `if` anidado para presentar el mensaje de error si no completó el dato).

---

**3.** Realizar un programa que muestre el promedio entre 2 números ingresados por el usuario. Validar que los números ingresados sean mayores a 0 y no mayores a 10.

> **Recomendación:** Lo que se ingresa por consola es texto por más que se escriban números. (usar un `if` con `!tipoDeDatoNumerico.TryParse...`)

---

**4.** Realizar un programa que permita el ingreso de una hora (cantidad de horas, minutos y segundos) y muestre en pantalla a cuántos segundos corresponde (total en segundos).

> **Recomendación:** Se busca que el número total no supere las 23:59:59 horas. Validar esto al momento del ingreso de cada dato. Lo mismo para valores negativos.

---

**5.** Escribir un programa que permita ingresar el valor de 2 variables string (no es necesario validar lo que se ingrese). Luego, el programa deberá:

- Mostrar su contenido indicando a qué variable corresponde.
  - Por ejemplo: `"variable1: abc – variable2: def"`
- Intercambiar los valores ingresados entre las dos variables.
- Mostrarlos nuevamente.
  - Por ejemplo: `"variable1: def – variable2: abc"`

> **Recomendación:** Puede ser útil pensar antes cómo se haría el intercambio de valores si cada variable fuera una celda de una planilla de cálculo, y sólo pudiéramos copiar y pegar el valor de una celda a otra (en lugar de memorizarlo y escribirlo manualmente).

---

**6.** Realizar un programa que permita ingresar los lados de un triángulo. El programa deberá determinar si se trata de un triángulo isósceles, escaleno o equilátero y presentar el resultado en pantalla.

> **Recomendación:** El escaleno tiene sus 3 lados distintos, el isósceles 2 lados iguales y uno distinto, y el equilátero los 3 iguales.

---

**7.** Realizar un programa que muestre en pantalla los múltiplos de 10 mayores a 0 y menores que 100.

> **Recomendación:** Usar un tipo de bucle que valide la condición antes de correr las instrucciones que contiene (`FOR`).

---

**8.** Realizar un programa que permita el ingreso de importes de facturas en forma sucesiva, mostrando un cartel al usuario si desea continuar con la carga de facturas. En caso negativo, mostrar un cartel con el importe total de las facturas ingresadas.

> **Recomendación:** Debe permitir hacer (`DO`) mientras (`WHILE`) el usuario indique que quiere seguir cargando. Recordar además que las comparaciones de texto son sensibles a mayúsculas y minúsculas: `"S"` es distinto de `"s"`.

---

**9.** Realizar un programa que permita ingresar el nombre, jornal por hora y cantidad de horas trabajadas de cada empleado. Sabiendo que se le retiene 11% para jubilación y 7% por otros conceptos, mostrar como resultado cada liquidación de haberes:

- Sueldo bruto
- Retención jubilación
- Retención otros conceptos
- Total de retenciones
- Neto a cobrar

> **Recomendación:** Se debe solicitar el ingreso de cada dato hasta tanto se encuentre dentro de los parámetros esperados. Luego imprimir línea por línea la liquidación.

---

**10.** Realizar un programa que permita ingresar el registro y la nota de alumnos indicando para cada uno si está promocionado, regularizado o reprobado. Luego del ingreso de cada alumno, el programa deberá consultar al usuario si desea continuar. Al finalizar la carga, deberá presentar en pantalla:

- El registro del alumno con la nota máxima y su nota.
- El registro del alumno con la nota mínima y su nota.

> **Recomendación:** La primera nota ingresada será siempre la más alta y la más baja en el momento inmediato de la carga. Luego, si se ingresa otra más alta, reemplazará a la registrada como más alta (y algo similar con la nota más baja).  
> **Supuesto:** Si hay dos alumnos con la misma nota, sólo se mostrará al primero que se ingrese.

---

**11.** Realizar un programa que permita ingresar número de factura y monto de venta de un período determinado. Mostrar como resultado:

- El total de ventas.
- El monto de venta promedio por factura.
- Cuáles fueron las facturas de mayor monto y de menor monto.

> **Recomendación:** Debe permitir hacer (`DO`) mientras (`WHILE`) el usuario indique que quiere seguir cargando. Recordar que las comparaciones de texto son sensibles a mayúsculas y minúsculas: `"S"` es distinto de `"s"`. Para calcular máximos y mínimos, repasar las recomendaciones del ejercicio 10.

---

**12.** Realizar un programa que pida código de artículo, nombre del artículo, costo del kilo de materia prima, cantidad de gramos que lleva cada unidad, porcentaje sobre los gastos indirectos de la empresa y porcentaje de rentabilidad. El programa debe:

- Mostrar el costo del artículo y precio de venta.
- Obtener el artículo más caro y el más barato.
- Determinar cuál es el artículo que da más rentabilidad en pesos.

**Datos:**
- IVA: 21%
- Gastos indirectos mensuales de la empresa: $100.000
- La operatoria debe hacerse para toda la línea de productos de la empresa.

> **Recomendación:** Recordar el uso de constantes. Pensar el circuito como una repetición de pasos individuales: mientras el usuario desee continuar, se le solicita el código, luego el nombre del artículo, etc. Para la identificación de los productos más caros, baratos y/o rentables, es posible usar una estructura `if/else`.

---

**13.** Realizar un programa que permita calcular el costo del desarrollo de los siguientes sistemas: ventas, sueldos, contabilidad, consultas gerenciales. En un proyecto existen horas de junior, de senior y de líder de proyecto. Cada hora tiene un valor de venta (que incluye el costo más un porcentaje de rentabilidad).

Calcular:
- El costo de cada sistema.
- El costo promedio de los sistemas.
- Cuál dejó más pesos de ganancia y cuál dejó menos.

> **Recomendación:** Para el menú principal, un `switch` es una buena alternativa.

---

**14.** Crear un programa que presente un menú en pantalla con las siguientes opciones:

| Opción | Descripción |
|--------|-------------|
| `1` | Establecer valor *(pide el valor de una variable numérica)* |
| `2` | Visualizar valor actual *(muestra el valor actual de la variable)* |
| `3` | Realizar una operación |
| `4` | Salir |

Al seleccionar **Realizar una operación**, se muestra el siguiente submenú:

| Opción | Descripción |
|--------|-------------|
| `S` | Sumar 1 *(suma 1 a la variable numérica)* |
| `R` | Restar 1 *(resta 1 a la variable numérica)* |
| `V` | Volver al menú principal |