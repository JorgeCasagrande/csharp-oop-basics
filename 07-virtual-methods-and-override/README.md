# 07 - Virtual Methods and Override / Métodos Virtuales y Override

## 📘 Theory / Teoría

### 🇺🇸 English

**Virtual methods** in a base class allow derived classes to provide their own specific implementation using the `override` keyword.  
This is a key part of runtime polymorphism and enables extensibility.

**Key concepts:**
- `virtual`: allows a method to be overridden in derived classes
- `override`: replaces the base implementation
- Polymorphism using method overrides

---

### 🇪🇸 Español

Los **métodos virtuales** en una clase base permiten que las clases derivadas proporcionen su propia implementación usando la palabra clave `override`.  
Esto es fundamental para el polimorfismo en tiempo de ejecución y la extensibilidad del código.

**Conceptos clave:**
- `virtual`: permite que un método sea sobrescrito
- `override`: reemplaza la implementación base
- Polimorfismo mediante sobrescritura de métodos

---

## 📁 Example Summary / Resumen del Ejemplo

We define a base class `Printer` with a `Print()` method marked as `virtual`.  
Two derived classes (`PDFPrinter` and `ImagePrinter`) override this method to print different formats.

Definimos una clase base `Printer` con un método `Print()` marcado como `virtual`.  
Dos clases derivadas (`PDFPrinter` e `ImagePrinter`) sobrescriben ese método con comportamientos distintos.

---

## ▶️ How to Run / Cómo Ejecutar

```bash
dotnet run