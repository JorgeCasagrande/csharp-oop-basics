# 09 - Integrated Exercise / Ejercicio Integrado

## 📘 Theory / Teoría

### 🇺🇸 English

This integrated exercise combines all the fundamental object-oriented programming concepts studied in previous modules to build a simple yet functional system.

You will work with:

- **Classes and Objects:** Understand how to define and instantiate classes, encapsulate data with properties, and manage object state.
- **Encapsulation:** Protect class data by restricting direct access and providing controlled access via properties.
- **Inheritance:** Create a base class and derive specialized classes that inherit common behavior.
- **Polymorphism:** Use virtual methods and method overriding to enable dynamic behavior at runtime.
- **Interfaces:** Define contracts that different classes can implement to provide common functionality.
- **Abstraction:** Use abstract classes to define shared templates for derived classes.
- **Static Classes:** Implement utility functions that don't require instantiation.
- **Sealed Classes:** Restrict inheritance to maintain control over class behavior and enhance security or performance.

This exercise simulates a real-world scenario where different types of employees perform work and their actions are logged through various logging mechanisms, demonstrating the interplay of these OOP principles.

---

## 📁 Exercise Description 

In this exercise, you will build a system that manages different types of employees and logs their activities using various logging mechanisms.

### Steps to follow:

1. **Define an abstract class `Employee`:**  
   - With encapsulated properties such as `Name` and `ID`.  
   - A virtual method `Work()` which will be overridden by derived classes.

2. **Create derived classes `Developer` and `Manager`:**  
   - Each should override the `Work()` method to display the specific work performed by each employee type.

3. **Define an interface `ILogger`:**  
   - With a method `Log(string message)` that will be implemented by different logger types.

4. **Implement `ConsoleLogger` and `FileLogger` classes:**  
   - Both implement `ILogger` and simulate logging messages to the console and to a file respectively.

5. **Create a static class `LoggerHelper`:**  
   - That provides utility methods, for example formatting log messages with timestamps.

6. **Implement a sealed class `CriticalLogger`:**  
   - Which implements `ILogger` and handles critical logs with special formatting.  
   - Being sealed, it cannot be inherited to ensure controlled behavior.

7. **In the main program (`Main`):**  
   - Create lists of employees and loggers.  
   - Invoke each employee’s `Work()` method.  
   - Use all loggers to record the actions of each employee, applying the log formatting.

This exercise practices core concepts to build modular, extensible, and maintainable systems and represents a mini integrated project.

---

### 🇪🇸 Español

Este ejercicio integrado combina todos los conceptos fundamentales de programación orientada a objetos estudiados en los módulos anteriores para construir un sistema simple pero funcional.

Vas a trabajar con:

- **Clases y Objetos:** Definir y crear instancias de clases, encapsular datos con propiedades y manejar el estado de los objetos.
- **Encapsulación:** Proteger los datos de las clases restringiendo el acceso directo y proporcionando acceso controlado mediante propiedades.
- **Herencia:** Crear una clase base y derivar clases especializadas que heredan comportamiento común.
- **Polimorfismo:** Usar métodos virtuales y sobrescritura para permitir comportamiento dinámico en tiempo de ejecución.
- **Interfaces:** Definir contratos que diferentes clases pueden implementar para proveer funcionalidades comunes.
- **Abstracción:** Usar clases abstractas para definir plantillas compartidas para las clases derivadas.
- **Clases Estáticas:** Implementar funciones utilitarias que no requieren instanciación.
- **Clases Selladas:** Restringir la herencia para mantener control sobre el comportamiento de la clase y mejorar seguridad o rendimiento.

Este ejercicio simula un escenario real donde distintos tipos de empleados realizan tareas y sus acciones se registran mediante diversos mecanismos de logging, mostrando la interacción de estos principios de POO.

---

## 📁 Descripción del Ejercicio

En este ejercicio se debe construir un sistema que gestione diferentes tipos de empleados y registre sus actividades usando múltiples mecanismos de logging.

### Pasos a realizar:

1. **Definir una clase abstracta `Employee`:**  
   - Con propiedades encapsuladas como `Name` e `ID`.  
   - Un método virtual `Work()` que será sobrescrito por las clases derivadas.

2. **Crear clases derivadas `Developer` y `Manager`:**  
   - Cada una debe sobrescribir el método `Work()` para mostrar el trabajo específico que realiza cada tipo de empleado.

3. **Definir una interfaz `ILogger`:**  
   - Con un método `Log(string message)` que implementarán diferentes tipos de logger.

4. **Implementar clases `ConsoleLogger` y `FileLogger`:**  
   - Que implementan `ILogger` y simulan el registro de mensajes en consola y en archivo respectivamente.

5. **Crear una clase estática `LoggerHelper`:**  
   - Que provea métodos utilitarios, por ejemplo para formatear mensajes de log con timestamp.

6. **Implementar una clase sellada `CriticalLogger`:**  
   - Que implemente `ILogger` y maneje logs críticos con un formato especial.  
   - Al ser sellada, no podrá ser heredada para asegurar su comportamiento.

7. **En el programa principal (`Main`):**  
   - Crear listas de empleados y loggers.  
   - Invocar el método `Work()` de cada empleado.  
   - Usar todos los loggers para registrar las acciones de cada empleado, aplicando el formateo de logs.

Este ejercicio pone en práctica conceptos fundamentales para crear sistemas modulares, extensibles y mantenibles, y representa un mini proyecto integrador.

---

## ▶️ How to Run / Cómo Ejecutar

Para ejecutar el ejercicio, simplemente compila y ejecuta la aplicación usando:

```bash
dotnet run