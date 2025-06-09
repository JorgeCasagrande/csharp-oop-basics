# 06 - Abstraction / Abstracción

## 📘 Theory / Teoría

### 🇺🇸 English

**Abstraction** is the process of hiding complex internal details and showing only the essential features of an object.  
In C#, this is done using **abstract classes** and **interfaces**.

An **abstract class** can define both implemented and unimplemented (abstract) members.  
You cannot create instances of abstract classes directly.

**Key concepts:**
- `abstract` keyword
- Abstract methods (no implementation)
- Partial implementation at base level
- Enforced behavior for derived classes

---

### 🇪🇸 Español

La **abstracción** es el proceso de ocultar los detalles internos complejos y mostrar solo las características esenciales de un objeto.  
En C#, se logra mediante **clases abstractas** e **interfaces**.

Una **clase abstracta** puede contener miembros implementados y no implementados.  
No se pueden instanciar directamente.

**Conceptos clave:**
- Palabra clave `abstract`
- Métodos abstractos (sin implementación)
- Implementación parcial en la clase base
- Comportamiento obligatorio en clases derivadas

---

## 📁 Example Summary / Resumen del Ejemplo

We define an abstract class `Vehicle` with a concrete method `StartEngine()` and an abstract method `Drive()`.  
Then we implement `Car` and `Bike` classes that inherit from `Vehicle` and implement `Drive()`.

Definimos una clase abstracta `Vehicle` con un método concreto `StartEngine()` y uno abstracto `Drive()`.  
Luego implementamos las clases `Car` y `Bike`, que heredan de `Vehicle` y completan el método `Drive()`.

        <<abstract>> Vehicle
        +------------------------+
        |    + StartEngine()     |
        |    + Drive(): void     | (abstract)
        +------------------------+
         ^                      ^
         |                      |
   +-----------+          +-----------+     
   |   Car     |          |   Bike    |
   +-----------+          +-----------+
   | + Drive() |          | + Drive() |
   +-----------+          +-----------+


---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run
