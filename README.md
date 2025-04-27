# Gestión de Vikingos para el Valhalla

## Descripción
Sistema de gestión de vikingos para su ingreso al Valhalla, desarrollado con tecnologías modernas de Microsoft. La aplicación permite realizar operaciones CRUD (Crear, Leer, Actualizar, Borrar) para los vikingos seleccionados, clasificándolos según sus méritos en categorías como Guerreros de Thor, Guerreros de Freyja, o Guerreros de Odín.

## Stack Tecnológico

### Frontend
- **Blazor WebAssembly**: Framework de Microsoft para construir aplicaciones web interactivas usando C#
- **.NET 9.0**: Última versión del framework de Microsoft
- **Bootstrap 5.1.3**: Framework CSS para el diseño responsivo
- **HTML5/CSS3**: Estándares web modernos

### Backend
- **ASP.NET Core Web API**: Framework para construir APIs RESTful
- **.NET 9.0**: Última versión del framework de Microsoft
- **Swagger/OpenAPI**: Documentación automática de la API
- **CORS**: Configurado para permitir peticiones desde el cliente Blazor

### Arquitectura
- **Arquitectura en Capas**:
  - Presentación (Blazor WebAssembly)
  - API (ASP.NET Core Web API)
  - Servicios (Lógica de Negocio)
  - Modelos (Entidades de Datos)
- **Patrón de Diseño**:
  - Repository Pattern
  - Service Pattern
  - State Management Pattern

### Características Principales
- Gestión completa de vikingos (CRUD)
- Clasificación automática de guerreros
- Cálculo de Valhalla Points
- Validación de datos en tiempo real
- Interfaz responsiva y moderna
- Manejo de errores robusto
- Documentación de API con Swagger

### Requisitos del Sistema
- .NET 9.0 SDK
- Visual Studio 2022 o Visual Studio Code
- Navegador web moderno

### Configuración del Entorno
1. Clonar el repositorio
2. Restaurar los paquetes NuGet
3. Configurar las URLs en los archivos de configuración
4. Ejecutar el proyecto API (puerto 7002)
5. Ejecutar el proyecto Blazor (puerto 5001)

### Estructura del Proyecto
```
GestionVikingos/
├── src/
│   ├── GestionVikingos.API/           # Proyecto Web API
│   │   ├── Controllers/
│   │   ├── Models/
│   │   ├── Services/
│   │   └── Program.cs
│   │
│   └── GestionVikingos.Client/        # Proyecto Blazor WebAssembly
│       ├── Components/
│       │   ├── Pages/
│       │   └── Shared/
│       ├── Models/
│       ├── Services/
│       └── Program.cs
│
└── GestionVikingos.sln
```

### Manejo de Errores
- Validación de datos en el frontend
- Manejo de excepciones en el backend
- Mensajes de error amigables para el usuario

### Seguridad
- CORS configurado para permitir solo orígenes específicos
- Validación de datos en ambos lados

## Licencia
Este proyecto está licenciado bajo la [Licencia MIT](LICENSE). Consulta el archivo [LICENSE](LICENSE) para obtener más detalles.
