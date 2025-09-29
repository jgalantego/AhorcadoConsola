# Juego del Ahorcado en C#

Este es un proyecto de consola en C# que implementa el clásico juego del **Ahorcado**.  
El programa permite al usuario adivinar palabras letra por letra, mostrando el progreso y controlando el número de intentos fallidos.

---

## Cómo funciona

1. **Bienvenida**
   - Al iniciar, el programa muestra un mensaje de bienvenida y explica el número máximo de intentos.

2. **Selección de palabra**
   - El juego selecciona aleatoriamente una palabra de un array predefinido:  
     ```csharp
     string[] arrayPalabras = { "ordenador", "tecnologias", "moviles", "practicas" };
     ```
   - La palabra se convierte a mayúsculas para simplificar la comparación de letras.

3. **Inicialización**
   - Se crea un array de caracteres (`char[]`) llamado `palabraAdivinada` con guiones bajos `_` que representan las letras aún no adivinadas.
   - Se inicializan las variables:
     - `intentosFallidos`: contador de errores.
     - `palabraCompleta`: indica si la palabra ha sido adivinada.
     - `letrasUsadas`: lista de letras que el jugador ya ha probado.

4. **Bucle principal del juego**
   - Mientras el jugador no haya agotado los intentos y no haya adivinado la palabra:
     - Se muestra en consola:
       - La palabra con letras adivinadas y guiones para las no adivinadas.
       - Número de intentos fallidos.
       - Letras usadas hasta el momento.
     - Se solicita al usuario que introduzca una letra.
     - El programa valida la entrada:
       - Debe ser **una sola letra**.
       - No debe haber sido usada previamente.
     - Si la letra está en la palabra, se actualiza `palabraAdivinada`.
     - Si la letra no está, se incrementa `intentosFallidos`.
     - Se comprueba si la palabra ya está completa:
       ```csharp
       palabraCompleta = !new string(palabraAdivinada).Contains('_');
       ```

5. **Fin de la partida**
   - Si el jugador adivina la palabra, se muestra un mensaje de felicitación.
   - Si se agotan los intentos, se muestra la palabra correcta.
   - Se pregunta si quiere jugar de nuevo (`S` para sí, cualquier otra para salir).

---

## Características adicionales

- Control de **entrada válida**: solo se acepta una letra por turno.
- Registro de **letras usadas** para evitar repetir intentos.
- Conversión a **mayúsculas** para simplificar las comparaciones.
- Juego repetible hasta que el usuario decida salir.

---

## Cómo ejecutar

1. Clona el repositorio o descarga el código.
2. Abre la terminal en la carpeta del proyecto.
3. Ejecuta: dotnet run

---

## Requisitos

- Para poder ejecutar este código será necesario tener instalado el .NET SDK en la máquina.

---
