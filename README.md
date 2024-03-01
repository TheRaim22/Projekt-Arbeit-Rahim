# Projekt-Arbeit-Rahim
### UML:
```mermaid
classDiagram
  class ConsoleProgram {
    +run(): void
  }

  class ItemDatabase {
    -itemNames: List<String>

    +addItemName(name: String): void
    +getItemName(index: Number): String
  }

  class ItemInfoDatabase {
    -itemInfo: Map<String, String>

    +addInfo(name: String, info: String): void
    +getInfo(name: String): String
  }

  ConsoleProgram --> ItemDatabase: contains
  ConsoleProgram --> ItemInfoDatabase: contains

  ConsoleProgram --> ItemDatabase: uses
  ConsoleProgram --> ItemInfoDatabase: uses
```
