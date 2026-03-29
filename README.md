# FCE - Programación en C#

Ejercicios organizados por unidad.

## Unidades

- [Unidad 1](Unidad1/README.md)

## Agregar una nueva unidad

Desde la terminal, en la carpeta raíz del proyecto:

```powershell
./add-unidad.ps1 -Numero 2
```

Esto crea automáticamente:
- `Unidad2/Unidad2.csproj` — proyecto de consola listo para compilar
- `Unidad2/Program.cs` — archivo principal vacío
- `Unidad2/README.md` — plantilla para pegar los enunciados
- Agrega el proyecto a `FCE.sln`

Después acordarse de agregar el link a la nueva unidad en la sección **Unidades** de este README.

### Cómo funciona "agregar a FCE.sln"

El script ejecuta internamente:

```powershell
dotnet sln add "Unidad2/Unidad2.csproj"
```

Eso edita el archivo `FCE.sln` y agrega una línea que referencia al nuevo proyecto:

```
Project("{FAE04EC0-...}") = "Unidad2", "Unidad2\Unidad2.csproj", "{GUID}"
EndProject
```

Visual Studio lee ese archivo al abrir la solución para saber qué proyectos cargar. No hace falta editarlo a mano.
