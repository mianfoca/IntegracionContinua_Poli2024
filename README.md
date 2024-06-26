# IntegracionContinua_Poli2024

## Descripción
Proyecto de integración continua desarrollado en el contexto del curso de ingeniería de software en la Escuela Politécnica Nacional. Este proyecto implementa un pipeline de CI/CD usando diversas herramientas para asegurar la calidad y eficiencia del desarrollo.

## Estructura del Proyecto
El repositorio está organizado en las siguientes carpetas y archivos principales:

- **back-end/**: Contiene el código fuente del servidor.
- **front-end/**: Contiene el código fuente de la aplicación cliente.
- **.gitignore**: Especifica los archivos que deben ser ignorados por Git.
- **Jenkinsfile**: Define el pipeline de Jenkins para CI/CD.
- **docker-compose.yaml**: Configuración para desplegar la aplicación usando Docker.

## Tecnologías Utilizadas
- **Lenguajes de programación**: 
  - C# para el Backend
  - JavaScript para el Frontend
  - Otros lenguajes y tecnologías que se están utilizando en este proyecto.

## Instalación
Para ejecutar este proyecto localmente, sigue estos pasos:

1. Clona el repositorio:
    ```bash
    git clone https://github.com/mianfoca/IntegracionContinua_Poli2024.git
    ```
2. Navega a la carpeta del proyecto:
    ```bash
    cd IntegracionContinua_Poli2024
    ```
3. Construye y ejecuta los contenedores Docker:
    ```bash
    docker-compose up --build
    ```

## Uso
El proyecto implementa un pipeline de integración continua que automatiza las siguientes tareas:
- Construcción del proyecto
- Ejecución de pruebas
- Despliegue en un entorno de producción

## Contribuciones
Las contribuciones son bienvenidas. Por favor, sigue los siguientes pasos para contribuir:

1. Haz un fork del repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -am 'Agrega nueva funcionalidad'`).
4. Envía tus cambios a tu fork (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request.

## Licencia
Este proyecto está bajo la Licencia MIT. Para más información, consulta el archivo [LICENSE](LICENSE).

## Contacto
Para cualquier pregunta o sugerencia, por favor contacta a los mantenedores del proyecto.

