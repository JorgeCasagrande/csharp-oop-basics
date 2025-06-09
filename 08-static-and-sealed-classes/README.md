# 08 - Static and Sealed Classes / Clases Estáticas y Selladas

## 📘 Theory / Teoría

### 🇺🇸 English

**Static classes** cannot be instantiated and contain only static members.  
They are commonly used to group utility functions or constants.

**Sealed classes** cannot be inherited. This restriction enforces design constraints and can improve performance by preventing further subclassing.

**Key concepts:**

- `static` class:
  - Cannot be instantiated
  - All members must be static
  - Useful for utility or helper methods

- `sealed` class:
  - Cannot be inherited
  - Useful to restrict inheritance and optimize performance

---

### 🇪🇸 Español

Las **clases estáticas** no se pueden instanciar y contienen solo miembros estáticos.  
Se utilizan comúnmente para agrupar funciones utilitarias o constantes.

Las **clases selladas (sealed)** no pueden ser heredadas. Esta restricción aplica reglas de diseño y puede mejorar el rendimiento evitando herencias adicionales.

**Conceptos clave:**

- Clase `static`:
  - No se puede instanciar
  - Todos los miembros deben ser estáticos
  - Útil para métodos utilitarios o helpers

- Clase `sealed`:
  - No puede ser heredada
  - Útil para restringir la herencia y optimizar rendimiento

---

## 📁 Example Summary / Resumen del Ejemplo

- `MathUtilities`: static class with a method to calculate the square of a number.  
- `BaseLogger`: sealed class that defines a simple logging method and cannot be inherited.

---

## ▶️ Code Example / Ejemplo de Código

See the file `StaticAndSealedExample.cs`

---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run
