param(
    [Parameter(Mandatory, HelpMessage="Numero de unidad a crear (ej: 2)")]
    [int]$Numero
)

$nombre = "Unidad$Numero"

if (Test-Path $nombre) {
    Write-Error "Ya existe la carpeta '$nombre'."
    exit 1
}

# Crear proyecto de consola
dotnet new console -n $nombre -o $nombre

# Agregar a la solucion
dotnet sln add "$nombre/$nombre.csproj"

# Crear README template
@"
# Unidad $Numero - Ejercicios

## Parte 1

---

**1.**

---
"@ | Set-Content "$nombre/README.md" -Encoding UTF8

Write-Host ""
Write-Host "Unidad $Numero lista en '$nombre/'." -ForegroundColor Green
