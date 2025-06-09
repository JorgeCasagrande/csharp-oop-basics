# 04 - Polymorphism / Polimorfismo

## 📘 Theory / Teoría

### 🇺🇸 English

**Polymorphism** is the ability of different classes to provide a different implementation of methods that are defined in a shared base class or interface.  
It allows objects to be treated as instances of their base type while still executing their overridden behavior.

**Key concepts:**
- `virtual` and `override` keywords
- Base class references pointing to derived objects
- Dynamic method binding at runtime

---

### 🇪🇸 Español

El **polimorfismo** es la capacidad de diferentes clases para proporcionar distintas implementaciones de métodos definidos en una clase base o interfaz común.  
Permite tratar objetos como instancias del tipo base, ejecutando sin embargo su comportamiento específico.

**Conceptos clave:**
- Palabras clave `virtual` y `override`
- Referencias de clase base apuntando a objetos derivados
- Enlace dinámico de métodos en tiempo de ejecución

---

## 📁 Example Summary / Resumen del Ejemplo

The base class `Shape` defines a `Draw()` method. The derived classes `Circle` and `Square` override that method.  
La clase base `Shape` define un método `Draw()`. Las clases derivadas `Circle` y `Square` sobrescriben ese método.

Using polymorphism, we can store all shapes in a list of type `Shape` and call `Draw()` on
