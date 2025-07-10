# Calculadora Web con Blazor

Este proyecto es una calculadora web desarrollada con Blazor WebAssembly en .NET. Permite realizar operaciones matemáticas básicas reutilizando la lógica de negocio de una clase Calculadora en C#.

## ¿Cómo ejecutar?

1. Abre la terminal en la raíz del proyecto.
2. Ejecuta:
   ```
   dotnet run
   ```
3. Abre el navegador en la URL que aparece en la terminal (por defecto http://localhost:5000 o similar).

## Estructura recomendada
- La lógica de la calculadora debe estar en una biblioteca de clases (Class Library) para poder reutilizarla.
- El frontend Blazor WebAssembly consume esa lógica para mostrar la interfaz y los resultados.

## Personalización
Puedes modificar la interfaz en los archivos `.razor` dentro de la carpeta `Pages`.

---

Este proyecto sigue buenas prácticas de separación de lógica y presentación.
