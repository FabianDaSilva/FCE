// MODELO 4 — Veterinaria "PATITAS"
//
// Una veterinaria necesita un sistema para gestionar sus turnos.
// Tiene hasta 80 turnos.
// Cada turno almacena:
// - Número de turno: int (se asigna automáticamente: máximo + 1, o 1 si es el primero)
// - Nombre del dueño: string
// - Nombre de la mascota: string
// - Especie: string ("PERRO", "GATO" u "OTRO") — validar con do/while + ToUpper
// - Fecha del turno: string (ej: "12/04/2026")
//
// ARRAYS OBLIGATORIOS:
// int[]    numeros     = new int[80];
// string[] duenos      = new string[80];
// string[] mascotas    = new string[80];
// string[] especies    = new string[80];
// string[] fechas      = new string[80];
// int      totalTurnos = 0;
//
// MENÚ:
// 1 - Registrar turno
//     - Verificar que haya espacio. Si no → error
//     - Pedir nombre del dueño (no vacío)
//     - Pedir nombre de la mascota (no vacío)
//     - Pedir especie: solo acepta "PERRO", "GATO" u "OTRO" (validar con do/while + ToUpper)
//     - Pedir fecha (no vacía)
//     - Asignar número de turno (máximo + 1, o 1 si es el primero)
// 2 - Listar turnos (número, dueño, mascota, especie, fecha)
// 3 - Buscar turnos por especie → mostrar todos los de esa especie. Si no hay → mensaje
// 4 - Cancelar turno por número → buscar y borrar (poner null/0 en todos sus campos)
// 5 - Salir
