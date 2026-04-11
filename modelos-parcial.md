# Modelos de Parcial - Práctica

---

## MODELO 1 — Estacionamiento "EL GARAJE"

Un estacionamiento necesita un sistema para gestionar sus vehículos.
Tiene capacidad para **50 autos** como máximo.
Cada auto almacena los siguientes datos:
- Patente: string (no puede repetirse)
- Nombre del titular: string
- Hora de entrada: string (ej: "14:30")
- Número de cochera: int (del 1 al 50, se asigna automáticamente: el próximo disponible)

### ARRAYS OBLIGATORIOS:
```
string[] patentes     = new string[50];
string[] titulares    = new string[50];
string[] horasEntrada = new string[50];
int[]    cocheras     = new int[50];
int      totalAutos   = 0;
```

### MENÚ:
1. Registrar ingreso
   - Verificar que haya espacio (totalAutos < 50). Si no → error
   - Pedir patente (no vacía). Si ya existe → error
   - Pedir nombre del titular (no vacío)
   - Pedir hora de entrada (no vacía)
   - Asignar número de cochera (máximo actual + 1, o 1 si es el primero)
   - Confirmar ingreso exitoso
2. Listar autos (cochera, patente, titular, hora de entrada)
3. Buscar auto por patente → mostrar todos sus datos. Si no existe → error
4. Salir

---

## MODELO 2 — Videoclub "BLOCKBUSTER"

Un videoclub necesita un sistema para gestionar sus alquileres.
Tiene hasta **100 alquileres** simultáneos.
Cada alquiler almacena:
- DNI del cliente: string (puede alquilar más de una vez)
- Nombre del cliente: string
- Título de la película: string
- Fecha de devolución: string (ej: "15/04/2026")

### ARRAYS OBLIGATORIOS:
```
string[] dnis          = new string[100];
string[] nombres       = new string[100];
string[] titulos       = new string[100];
string[] fechas        = new string[100];
int      totalAlquileres = 0;
```

### MENÚ:
1. Registrar alquiler
   - Verificar que haya espacio. Si no → error
   - Pedir DNI (no vacío)
   - Pedir nombre (no vacío)
   - Pedir título de película (no vacío)
   - Pedir fecha de devolución (no vacía)
   - Confirmar registro exitoso
2. Listar todos los alquileres (DNI, nombre, título, fecha)
3. Buscar por DNI → listar todos los alquileres de ese cliente. Si no existe → error
4. Mostrar el alquiler con la fecha de devolución más próxima (el primero alfabéticamente por fecha)
5. Salir

---

## MODELO 3 — Gimnasio "FIT TOTAL"

Un gimnasio necesita un sistema para gestionar sus socios.
Tiene hasta **150 socios**.
Cada socio almacena:
- DNI: string (único)
- Nombre: string
- Apellido: string
- Plan: string ("BÁSICO" o "PREMIUM")
- Cuotas pagas: int (empieza en 0)

### ARRAYS OBLIGATORIOS:
```
string[] dnis      = new string[150];
string[] nombres   = new string[150];
string[] apellidos = new string[150];
string[] planes    = new string[150];
int[]    cuotas    = new int[150];
int      totalSocios = 0;
```

### MENÚ:
1. Registrar socio
   - Verificar que haya espacio. Si no → error
   - Pedir DNI (no vacío). Si ya existe → error
   - Pedir nombre y apellido (no vacíos)
   - Pedir plan: solo acepta "BASICO" o "PREMIUM" (validar con do/while + ToUpper)
   - Cuotas pagas arranca en 0
2. Registrar pago de cuota → pedir DNI, buscar socio, incrementar cuotas en 1
3. Listar socios ordenados alfabéticamente por apellido (Bubble Sort)
4. Mostrar el socio con más cuotas pagas
5. Salir

---

## MODELO 4 — Veterinaria "PATITAS"

Una veterinaria necesita un sistema para gestionar sus turnos.
Tiene hasta **80 turnos**.
Cada turno almacena:
- Número de turno: int (se asigna automáticamente: máximo + 1)
- Nombre del dueño: string
- Nombre de la mascota: string
- Especie: string ("PERRO", "GATO" u "OTRO")
- Fecha del turno: string (ej: "12/04/2026")

### ARRAYS OBLIGATORIOS:
```
int[]    numeros   = new int[80];
string[] duenos    = new string[80];
string[] mascotas  = new string[80];
string[] especies  = new string[80];
string[] fechas    = new string[80];
int      totalTurnos = 0;
```

### MENÚ:
1. Registrar turno
   - Verificar que haya espacio. Si no → error
   - Pedir nombre del dueño (no vacío)
   - Pedir nombre de la mascota (no vacío)
   - Pedir especie: solo acepta "PERRO", "GATO" u "OTRO" (validar con do/while + ToUpper)
   - Pedir fecha (no vacía)
   - Asignar número de turno (máximo + 1, o 1 si es el primero)
2. Listar turnos (número, dueño, mascota, especie, fecha)
3. Buscar turnos por especie → mostrar todos los de esa especie. Si no hay → mensaje
4. Cancelar turno por número → buscar y borrar (poner null/0 en todos sus campos)
5. Salir
