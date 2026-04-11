// MODELO 2 — Videoclub "BLOCKBUSTER"
//
// Un videoclub necesita un sistema para gestionar sus alquileres.
// Tiene hasta 100 alquileres simultáneos.
// Cada alquiler almacena:
// - DNI del cliente: string (puede alquilar más de una vez)
// - Nombre del cliente: string
// - Título de la película: string
// - Fecha de devolución: string (ej: "15/04/2026")
//
// ARRAYS OBLIGATORIOS:
// string[] dnis            = new string[100];
// string[] nombres         = new string[100];
// string[] titulos         = new string[100];
// string[] fechas          = new string[100];
// int      totalAlquileres = 0;
//
// MENÚ:
// 1 - Registrar alquiler
//     - Verificar que haya espacio. Si no → error
//     - Pedir DNI (no vacío)
//     - Pedir nombre (no vacío)
//     - Pedir título de película (no vacío)
//     - Pedir fecha de devolución (no vacía)
//     - Confirmar registro exitoso
// 2 - Listar todos los alquileres (DNI, nombre, título, fecha)
// 3 - Buscar por DNI → listar todos los alquileres de ese cliente. Si no existe → error
// 4 - Mostrar el alquiler con la fecha de devolución más próxima (el primero alfabéticamente por fecha)
// 5 - Salir
