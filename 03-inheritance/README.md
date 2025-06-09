# 03 - Inheritance / Herencia

## 📘 Theory / Teoría

### 🇺🇸 English

**Inheritance** allows a class (child or derived class) to acquire properties and behaviors (fields and methods) from another class (parent or base class).  
It promotes code reusability and logical hierarchy.

**Key concepts:**
- `base` class
- `derived` class using `:`
- `virtual` and `override` for method extension

---

### 🇪🇸 Español

La **herencia** permite que una clase (hija o derivada) adquiera atributos y comportamientos (campos y métodos) de otra clase (padre o base).  
Esto promueve la reutilización de código y jerarquías lógicas.

**Conceptos clave:**
- Clase `base`
- Clase derivada con `:`
- Uso de `virtual` y `override` para extender métodos

---

## 📁 Example Summary / Resumen del Ejemplo

The `Animal` class defines a base structure with a method `MakeSound()`. The `Dog` class inherits from `Animal` and overrides that method.  
La clase `Animal` define una estructura base con un método `MakeSound()`. La clase `Dog` hereda de `Animal` y sobrescribe ese método.

+-----------------+           +------------------------+
|   Animal        |<----------|           Dog          |
+-----------------+           +------------------------+
| + Name          |           |                        |
| + MakeSound()   |           | + MakeSound() override |
+-----------------+           +------------------------+


---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run