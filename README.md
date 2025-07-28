# Chain of Responsibility Pattern

## 🧩 Definition

The **Chain of Responsibility** is a **behavioral design pattern** that allows an object to pass a request along a chain of potential handlers until one of them handles it. This pattern decouples the sender of a request from its receivers by giving multiple objects a chance to handle the request.

---

## 🔧 Key Concepts

- **Handler**: An interface or abstract class defining a method to handle a request and a reference to the next handler.
- **Concrete Handler**: Implements the handler interface and either handles the request or passes it to the next handler.
- **Client**: Initiates the request to the first handler in the chain.

---

## ✅ Benefits

- ✅ Reduces coupling between sender and receiver.
- 🔄 Adds flexibility in assigning responsibilities.
- 🧩 Allows dynamic changes to the handler chain.
- ♻️ Promotes single responsibility by dividing processing steps into separate classes.

---

## ❌ Drawbacks

- 🧪 Can be hard to debug if many handlers are involved.
- ⚠️ Risk of a request going unhandled if no handler takes responsibility.
- 🧱 Handlers must follow a consistent protocol or interface, which adds design overhead.

---

## 🧠 Use Cases

- 🖱 GUI event handling (e.g., clicking buttons, keyboard input).
- 🧾 Logging frameworks where different levels (info, warning, error) are processed separately.
- 🧹 Request validation or preprocessing pipelines (e.g., API request filters).
- 🌐 Middleware chains in web framework
