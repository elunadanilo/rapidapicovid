# rapidapicovid
El presente repositorio, se utiliza para albergar un proyecto que despliega casos por Covid19 en distintas regiones y provincias del mundo. Esto a partir de la información obtenida por Johns Hopkins CSSE.

## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._
_Solo debes descargar el proyecto, previa instalacion de los requisitos y ejecutar el proyecto._

### Pre-requisitos 📋

_Que cosas necesitas para instalar el software_

```
Visual Studio 2019
Net Core 3.1
Conexión a internet para ejecutar las librerias en CDN
```

### Instalación 🔧

_Para poder editar y ejecutar el proyecto deberás:_

_Instalar Visual Studio 2019 o Visual Studio Community 2019_
_Instalar NET Core 3.1_

### Forma de uso 🔧

_Para poder verificar los registros, solo debes ejecutar el proyecto y seleccionar en el navegador la pestaña de Regiones_
_Al desplegarse los registros puedes presionar los botones de CSV, XML y JSON para exportar los registros_
_También puedes validar los registros por provincia seleccionando en la lista desplegable la región y posteriormente presionar el botón de reporte_
## Ejecutando las pruebas ⚙️

_Para ejecutar las pruebas unitarias puedes dirigirte al proyecto PruebasUnitariasRapidApi, con el click derecho del mouse seleccionar ejecutar pruebas unitarias._

_https://docs.microsoft.com/es-es/visualstudio/test/getting-started-with-unit-testing?view=vs-2019&tabs=mstest_

### Analice las pruebas unitarias 🔩

_Las pruebas unitarias agregadas al proyecto sirven para validar que los dos servicios de Regiones y provincias funcionen correctamente_
_Si el servicio funciona correctamente se devolverá un número 1, de lo contrario mostrará el mensaje de error_

## Construido con 🛠️

* [AXIOS Por CDN](https://github.com/axios/axios) - Para peticiones como cliente Http
* [VUE por CDN](https://es.vuejs.org/v2/guide/installation.html) - Manejador de dependencias
* [Bootstrap](https://rometools.github.io/rome/) - Framework Front-End
* [C#] -Lenguaje de programación
* [Net Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1) -Framework para creación de aplicaciones

## Autores ✒️

* **Johns Hopkins CSSE** - *Como fuente principal de la información de casos de covid*
* **Danilo Estuardo Itzep Luna** - *Programación de aplicación* - [ceamsolutions.com]

