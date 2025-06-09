# 02 - Encapsulation / Encapsulamiento

## 📘 Theory / Teoría

### 🇺🇸 English

**Encapsulation** is one of the four pillars of object-oriented programming. It refers to the concept of restricting direct access to some of an object's components, usually through private fields and public properties or methods.

This protects the internal state of the object and allows changes only through controlled interfaces.

**Key concepts:**
- `private` fields
- `public` properties (`get` / `set`)
- Validation logic inside setters
- Information hiding

---

### 🇪🇸 Español

El **encapsulamiento** es uno de los cuatro pilares de la programación orientada a objetos. Se refiere al concepto de restringir el acceso directo a los componentes internos de un objeto, utilizando campos privados y propiedades o métodos públicos.

Esto protege el estado interno del objeto y permite realizar cambios solo de forma controlada.

**Conceptos clave:**
- Campos `private`
- Propiedades `public` (`get` / `set`)
- Validaciones dentro de los setters
- Ocultamiento de información

---

## 📁 Example Summary / Resumen del Ejemplo

The `BankAccount` class stores a private balance. It can be read with a `Balance` property and updated only via the `Deposit()` method, which prevents invalid changes.  
La clase `BankAccount` guarda un saldo privado. Se puede leer mediante una propiedad `Balance` y actualizar solo mediante el método `Deposit()`, que evita modificaciones inválidas.

---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run
