# 05 - Interfaces

## 📘 Theory / Teoría

### 🇺🇸 English

An **interface** defines a contract that classes can implement. It only contains method signatures and properties, without implementation.  
Classes that implement the interface must provide concrete implementations for all its members.

**Key concepts:**
- `interface` keyword
- Classes implement interfaces using `:`
- Multiple interfaces can be implemented by the same class
- Promotes decoupling and flexibility

---

### 🇪🇸 Español

Una **interfaz** define un contrato que las clases pueden implementar. Solo contiene firmas de métodos y propiedades, sin implementación.  
Las clases que implementan la interfaz deben definir concretamente todos sus miembros.

**Conceptos clave:**
- Palabra clave `interface`
- Las clases implementan interfaces con `:`
- Se pueden implementar múltiples interfaces
- Promueve el desacoplamiento y la flexibilidad

---

## 📁 Example Summary / Resumen del Ejemplo

We define an interface `IPlayable` with a method `Play()`.  
Two classes, `Guitar` and `Piano`, implement this interface with their own logic.
Using a list of type `IPlayable`, we can execute `Play()` on different instruments, demonstrating polymorphism through interfaces.

Definimos una interfaz `IPlayable` con un método `Play()`. Dos clases, `Guitarra` y `Piano`, implementan esta interfaz con su propia lógica. 
Mediante una lista de `IPlayable`, ejecutamos `Play()` en distintos instrumentos, demostrando polimorfismo por interfaces.

<<interface>> IPlayable
+----------------------+
|    + Play(): void    |
+----------------------+
      ^           ^
      |           |
+---------+   +---------+
|  Guitar |   |  Piano  |
+---------+   +---------+
| + Play()|   | + Play()|
+---------+   +---------+

---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run
