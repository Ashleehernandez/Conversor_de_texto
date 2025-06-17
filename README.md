# Conversor de Texto

Un proyecto en C# que implementa el patrón de diseño **Strategy** para convertir texto en diferentes formatos: mayúsculas, minúsculas y formato título.

## 📋 Descripción

Este proyecto demuestra la implementación del patrón Strategy a través de una aplicación de consola que permite al usuario convertir texto en diferentes formatos. El sistema está diseñado con una arquitectura modular que facilita la extensión y mantenimiento del código.

## 🏗️ Arquitectura del Proyecto

El proyecto está organizado en múltiples capas:

```
Conversor_de_texto/
├── Interface/           # Definición de contratos
├── Servicio/           # Implementaciones concretas
├── Strategy/           # Contexto del patrón Strategy
├── Usuario/            # Aplicación de consola principal
└── Factory/            # Patrón Factory (referenciado)
```

### Componentes Principales

- **Interface**: Define el contrato `IConversor_de_texto` que deben implementar todas las estrategias
- **Servicio**: Contiene las implementaciones concretas de conversión
- **Strategy**: Implementa el contexto del patrón Strategy
- **Usuario**: Aplicación de consola que interactúa con el usuario

## 🚀 Características

- ✅ Conversión a **mayúsculas**
- ✅ Conversión a **minúsculas** 
- ✅ Conversión a **formato título**
- ✅ Interfaz de consola interactiva
- ✅ Arquitectura extensible usando patrones de diseño

## 🛠️ Tecnologías Utilizadas

- **.NET 8.0**
- **C#**
- **Patrón Strategy**
- **Patrón Factory** (estructura preparada)

## 📦 Instalación y Configuración

### Prerrequisitos

- .NET 8.0 SDK instalado
- Visual Studio 2022 o Visual Studio Code

### Pasos de instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tu-usuario/conversor-de-texto.git
   cd conversor-de-texto
   ```

2. **Restaurar dependencias**
   ```bash
   dotnet restore
   ```

3. **Compilar el proyecto**
   ```bash
   dotnet build
   ```

4. **Ejecutar la aplicación**
   ```bash
   cd Usuario
   dotnet run
   ```

## 💻 Uso

Al ejecutar la aplicación, verás un menú interactivo:

```
==Convertir==
===MENU==
Ingrese el texto
> Hola Mundo

1 Mayusculas
2 Formato_titulo  
3 Minuscula
> 1
```

### Ejemplos de salida

- **Mayúsculas**: `HOLA MUNDO`
- **Minúsculas**: `hola mundo`
- **Formato título**: `Hola Mundo`

## 🏛️ Patrones de Diseño Implementados

### Strategy Pattern

El patrón Strategy permite cambiar el algoritmo de conversión en tiempo de ejecución:

```csharp
// Contexto
StrategyConversor conversor = new StrategyConversor(new Mayúsculas());

// Cambiar estrategia dinámicamente
conversor.CambiarStrategy(new Formato_título());
conversor.ConvertirTexto("hola mundo");
```

### Estructura de clases

```
IConversor_de_texto (Interface)
├── Mayúsculas (ConcreteStrategy)
├── Minúsculas (ConcreteStrategy)
└── Formato_título (ConcreteStrategy)

StrategyConversor (Context)
```

## 📁 Estructura de Archivos

```
├── Interface/
│   ├── IConversor_de_texto.cs
│   └── Interface.csproj
├── Servicio/
│   ├── Mayúsculas.cs
│   ├── Minúsculas.cs
│   ├── Formato_título.cs
│   └── Servicio.csproj
├── Strategy/
│   ├── StrategyConversor.cs
│   └── Strategy.csproj
├── Usuario/
│   ├── Program.cs
│   └── Usuario.csproj
├── Factory/
│   └── Factory.csproj
└── Conversor_de_texto.sln
```

## 🔧 Extensibilidad

Para agregar nuevos formatos de conversión:

1. **Crear nueva clase** que implemente `IConversor_de_texto`
2. **Implementar el método** `Conversor(string texto)`
3. **Agregar la opción** en el menú del `Program.cs`

Ejemplo:

```csharp
public class Invertir : IConversor_de_texto
{
    public void Conversor(string texto)
    {
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        Console.WriteLine("Texto invertido: " + new string(array));
    }
}
```

## 🤝 Contribuciones

Las contribuciones son bienvenidas. Por favor:

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📄 Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo `LICENSE` para más detalles.

## 👥 Autor

- **Tu Nombre** - *Desarrollo inicial* - [tu-usuario](https://github.com/tu-usuario)

## 🎯 Próximas Características

- [ ] Implementación completa del patrón Factory
- [ ] Conversión a formato camelCase
- [ ] Conversión a formato snake_case
- [ ] Interfaz gráfica de usuario
- [ ] Pruebas unitarias
- [ ] Soporte para archivos de texto

---

⭐ Si este proyecto te ha sido útil, ¡no olvides darle una estrella!
