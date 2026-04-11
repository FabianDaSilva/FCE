// MODELO 3 — Gimnasio "FIT TOTAL"
//
// Un gimnasio necesita un sistema para gestionar sus socios.
// Tiene hasta 150 socios.
// Cada socio almacena:
// - DNI: string (único)
// - Nombre: string
// - Apellido: string
// - Plan: string ("BÁSICO" o "PREMIUM")
// - Cuotas pagas: int (empieza en 0)
//
// ARRAYS OBLIGATORIOS:
// string[] dnis        = new string[150];
// string[] nombres     = new string[150];
// string[] apellidos   = new string[150];
// string[] planes      = new string[150];
// int[]    cuotas      = new int[150];
// int      totalSocios = 0;
//
// MENÚ:
// 1 - Registrar socio
//     - Verificar que haya espacio. Si no → error
//     - Pedir DNI (no vacío). Si ya existe → error
//     - Pedir nombre y apellido (no vacíos)
//     - Pedir plan: solo acepta "BASICO" o "PREMIUM" (validar con do/while + ToUpper)
//     - Cuotas pagas arranca en 0
// 2 - Registrar pago de cuota
//     - Pedir DNI. Si no existe → error
//     - Incrementar cuotas en 1. Confirmar pago
// 3 - Listar socios ordenados alfabéticamente por apellido (Bubble Sort con String.Compare)
// 4 - Mostrar el socio con más cuotas pagas
// 5 - Salir
