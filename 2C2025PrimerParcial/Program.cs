// 1er PARCIAL - 2do Cuatrimestre 2025
// Maternidad "JULITO"
//
// DATOS:
// - 500 camas, 20 quirófanos, hasta 500 pacientes
// - Cada paciente: DNI (string, único), Nombre, Apellido,
//   Quirófano asignado, Cama asignada, Estado
// - Estados: "Esperando quirófano" → "Esperando cama" → "Esperando alta" → "Alta"
//
// ARRAYS:
// - Quirófanos: hasta 20 (ej: "Q/02/002", "Q/02/003")
// - Camas: hasta 500 (ej: "901", "902", "1016")
//
// MENÚ:
// A - Alta de paciente
//     - Buscar fila vacía (DNI null/vacío). Si no hay → error
//     - Pedir DNI. Si ya existe → error
//     - Pedir nombre y apellido (no vacíos)
//     - Guardar datos, estado = "Esperando quirófano"
//
// B - Asignar quirófano
//     - Pedir DNI. Si no existe → error
//     - Si no está en "Esperando quirófano" → error
//     - Mostrar quirófanos, pedir uno. Si ya asignado a otro → error
//     - Guardar quirófano, estado = "Esperando cama"
//
// C - Asignar cama
//     - Pedir DNI. Si no existe → error
//     - Si no está en "Esperando cama" → error
//     - Mostrar camas, pedir una. Si ya asignada a otro → error
//     - Guardar cama, quirófano = null, estado = "Esperando alta"
//
// D - Alta (solo llamar, no desarrollar)
//     - Pedir DNI. Si no existe → error
//     - Si no está en "Esperando alta" → error
//     - Cama = null, estado = "Alta"
//
// E - Archivar (solo llamar, no desarrollar)
//     - Recorrer todos los pacientes
//     - Los que estén en "Alta" → poner null en todos sus datos
//
// S - Salir
//
// SE SOLICITA: desarrollar A, B, C, E y S. Llamar D sin desarrollar.
// VALIDAR TODOS LOS INGRESOS DE DATOS.

