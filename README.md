# Actividad — OOP + Estructuras de Datos · C#

| Campo | Dato |
|---|---|
| Nombre | Steve Lopez Deolarte  |
| Grupo | 6 "A" |
| Materia |  PROGRAMACIÓN ORIENTADA A OBJETOS |
| Fecha | 2026-05-28 |

## Puntaje opción múltiple
**12 / 12** (100%)

## Etapa 01 — Calentamiento

**1. Después de ejecutar las líneas A, B, C y D ¿cuántos elementos tiene la pila?**
Respuesta: 4 — ✔ Correcto

**2. ¿Qué imprime la línea E? (historial.Peek())**
Respuesta: Jugo naranja — ✔ Correcto

**3. ¿Cuántos elementos quedan en la pila después de la línea F? (historial.Pop())**
Respuesta: 3 — ✔ Correcto

**4. ¿Qué imprime la línea G? (historial.Count)**
Respuesta: 3 — ✔ Correcto

**5. ¿Qué imprime la línea H? (historial.Peek() después del Pop)**
Respuesta: Torta de jamón — ✔ Correcto

**6. Si declaras Stack<string> y llamas Push(42), ¿qué ocurre?**
Respuesta: Error de compilación — Stack<string> solo acepta textos — ✔ Correcto

## Etapa 02 — Stack en vivo

**1. Tienes una pila con: Torta (tope) → Agua → Tacos (fondo). Llamas Pop() dos veces. ¿Qué queda en la pila?**
Respuesta: Solo Tacos — ✔ Correcto

**2. ¿En qué orden imprime el foreach una pila con: A (tope) → B → C (fondo)?**
Respuesta: A, B, C — ✔ Correcto

**3. ¿Cuál es la DIFERENCIA real entre Peek() y Pop()?**
Respuesta: Peek() mira el tope sin quitarlo; Pop() lo quita y lo devuelve — ✔ Correcto

**4. ¿Qué error lanza C# si llamas Pop() en una pila vacía?**
Respuesta: InvalidOperationException — ✔ Correcto

**5. ¿Por qué Stack<T> es la estructura ideal para implementar Ctrl+Z?**
Respuesta: Porque siempre expone el último elemento agregado — LIFO coincide con 'deshacer lo más reciente' — ✔ Correcto

**6. ¿Cuál de estas declaraciones es correcta para una pila de números enteros?**
Respuesta: Stack<int> pila = new Stack<int>(); — ✔ Correcto

## Etapa 03 — Bugs

**Bug #1:**
Se esta usando POP cuando debe usar peek 


**Bug #2:**
Esta usando string y los datos son numeros entonces deberia ocupar int 

**Bug #3:**
El error es que las pilas estan vacias 

## Etapa 04 — Diseño

**Reto elegido:** 🎵 App de música — Lista de reproducción LIFO

**Solución:**
﻿using System ;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> Musica= new Stack<string>();

        Musica.Push("Cuando el agua esta hirviendo");
        Musica.Push("Recorde");
        Musica.Push("Ama De Mi Sol");
        Musica.Push("Gil");
        Musica.Push("Olimpo");

        string actual = Musica.Peek();
        Console.WriteLine($"Tope actual de cancion : {actual}");
        Console.WriteLine(Musica.Count);

        string retirado = Musica.Pop();
        Console.WriteLine($"Se retiro: {retirado}");
        Console.WriteLine(Musica.Count);

        Console.WriteLine(Musica.Peek());
        // los cambios para guardar
    }
}

**Reflexión:**
Elegi esta estructura ya que siento que es en la que mejor me acomodo para programarla ya que es muy facil entenderlo , la operacion mas frecuente es la de Musica.Push(""); ya que hay van los datos y si usaria otra seria la de List ya que tambien creo que es muy facil 
# Dinamica-
