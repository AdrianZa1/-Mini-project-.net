# Script PowerShell para limpiar, compilar y preparar el proyecto Blazor para Render

Write-Host "Limpiando carpetas anteriores..."
Remove-Item -Recurse -Force bin, obj, out, site -ErrorAction SilentlyContinue
dotnet clean

Write-Host "Publicando en modo Release..."
dotnet publish -c Release -o out

Write-Host "Copiando archivos a la carpeta site/..."
mkdir site -ErrorAction SilentlyContinue
Copy-Item -Recurse out\wwwroot\* site\

Write-Host "Listo. Ahora haz git add, commit y push para Render."
