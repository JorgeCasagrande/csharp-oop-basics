# 01 - Classes and Objects / Clases y Objetos

## 📘 Theory / Teoría

### 🇺🇸 English

In object-oriented programming, a **class** is a template that defines the structure and behavior of objects. It describes what an object **has** (attributes or properties) and what it **can do** (methods).

An **object** is an instance of a class. It represents a real-world entity with a specific state and behavior.

Key concepts:
- **Class**: Definition of attributes and behaviors.
- **Object**: Concrete instance of a class.
- **Constructor**: Special method used to initialize objects.
- **Method**: Function defined inside a class to perform actions.

---

### 🇪🇸 Español

En la programación orientada a objetos, una **clase** es una plantilla que define la estructura y comportamiento de los objetos. Describe qué **tiene** un objeto (atributos o propiedades) y qué **puede hacer** (métodos).

Un **objeto** es una instancia concreta de una clase. Representa una entidad del mundo real con un estado y un comportamiento propios.

Conceptos clave:
- **Clase**: Define atributos y comportamientos.
- **Objeto**: Instancia concreta de una clase.
- **Constructor**: Método especial para inicializar objetos.
- **Método**: Función definida dentro de una clase para realizar acciones.

---

## 📁 Example Summary / Resumen del Ejemplo

This example defines a class `Person` with two properties: `Name` and `Age`, and two methods: `Greet()` and `HaveBirthday()`.  
Este ejemplo define una clase `Person` con dos propiedades: `Name` y `Age`, y dos métodos: `Greet()` y `HaveBirthday()`.

In `Main`, we create two objects (Alice and Bob), and we interact with them using their methods.  
En `Main`, creamos dos objetos (Alice y Bob) y usamos sus métodos para interactuar con ellos.

+----------------------+
|       Person         |
+----------------------+
| - Name: string       |
| - Age: int           |
+----------------------+
| + Person(name, age)  |
| + Greet(): void      |
| + HaveBirthday():void|
+----------------------+

---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run
