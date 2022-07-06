# Bolsa_de_Empleados_MVC

### Tecnologias utilizadas
```
C# Asp.net Framework
Sql Server
Entity Framework
LinkQ
```

### Como correr el proyecto

```
Debe descargar el proyecto y abrirlo con Visual Studio Community, en las carpetas encontrara una llamada Base de datos, 
dicha carpeta contiene la base de datos del proyecto.

Corra la base de datos en Sql Server y ya le tendria lista para usarla. En el App.Config de las capas 
(Capa_Datos, Capa_Entidad, Capa_Negocio) encontrara una linea de conexion donde tendra que colocar el nombre de su servidor y 
en el Web.Config de la capa presentacion, colocar el mismo nombre del servidor.

Antes de realizar cualquier operacion, debe insertar el NUMERO_DE_PAGINACION desde la base de datos.

Ya con esos pasos solo tendria que correr su proyecto y estaria listo para correr.
```

### Video del Proyecto
[Link del Video](https://youtu.be/hEiFZ9QXn14).

### Descripción del Proyecto

```
El Proyecto consiste en un sitio web de una Bolsa de Empleos. Deberá incluirse un API para desarrolladores.
```

### Los Casos de Uso del Proyecto

```
Las secciones siguientes describen las características que queremos aplicar en la primera versión / iteración 
del proyecto con algunos Casos de Uso sencillos. 

El sitio web tiene tres tipos de usuarios: 

  • Administrador: Propietario del Sitio Web 
  • User: Visita la página web para buscar un puesto de trabajo y se postula para uno. 
  • Poster: Visita la página web para envíar/ofrecer un puesto de trabajo 

El proyecto tiene dos aplicaciones: el frontend (Casos de Uso F1 a F5, que están más abajo), donde los usuarios 
interactúan con el sitio web, y el backend (Casos de Uso B1 a B2), donde los administradores gestionan el sitio web.

La aplicación backend tiene seguridad y requiere de credenciales para acceder.
```

### Caso de Uso F1: 

#### En la página principal, los usuarios ven los últimos puestos de trabajo activos.

```
Cuando un usuario entra a la página web, ve una lista de los puestos de trabajo activos. Los puestos de trabajo se 
clasifican por categoría y a continuación, por fecha de publicación (los nuevos puestos de trabajo primero). Para 
cada puesto de trabajo, sólo la ubicación, la posición, y la empresa se muestran.

Para cada categoría, la lista sólo muestra los primeros 10 puestos de trabajo y un enlace permite 
listar todos los puestos de trabajo para una categoría determinada (Caso de Uso F2).

En la página principal, el usuario puede refinar la lista de puestos (Caso de Uso F2), 
o enviar un nuevo puesto de trabajo (Caso de Uso F5).
```

### Caso de Uso F2:
#### Un usuario puede solicitar todos los puestos de trabajo de una categoría determinada

```
Cuando un usuario hace clic en el nombre de una categoría o en un enlace “more jobs” (más trabajos) 
en la página de inicio, verá todos los puestos de trabajo para esta categoría ordenados por fecha.

La lista está paginada, con 20 puestos de trabajo por página.
```

### Caso de Uso F3:

#### Un usuario refina la lista con algunas palabras claves

```
El usuario puede introducir algunas palabras clave para refinar su búsqueda. Las palabras
clave pueden ser palabras se encuentra en los campos de la ubicación, la posición, la categoría, y de la compañía.
```

### Caso de Uso F4:

#### Un usuario hace clic en un puesto de trabajo para ver información más detallada

```
El usuario puede seleccionar un trabajo de la lista para ver información más detallada.
```

### Caso de Uso F5:

#### Un usuario envía un puesto de trabajo

```
Un usuario puede enviar un puesto de trabajo. Un puesto de trabajo está formado por varias partes de información:

    • Compañía 
    • Tipo (full-time, part-time, o freelance) 
    • Logo (opcional) 
    • URL (opcional) 
    • Posición
    • Ubicación 
    • Categoría (el usuario elige una de una lista de posibles categorías)
    • Descripción del trabajo (URL y correos electrónicos son enlazados de forma automática) 
    • Cómo aplicar (URL y correos electrónicos son enlazados de forma automática) 
    • Email (email del oferente)
    
Se debe de crear una cuenta para crear un puesto de trabajo. 

El proceso es sencillo con sólo dos pasos: en primer lugar, el usuario rellena el formulario con toda 
la información necesaria para describir el trabajo y, a continuación, se valida la información con una vista
previa de la página de empleo final.
```

### Caso de Uso B1:

#### Un administrador configura el sitio web

```
Un administrador puede modificar las categorías disponibles en el sitio web. 
También puede hacer algunos ajustes: 

    • El número máximo de puestos de trabajo que figura en la página de inicio
```

### Caso de Uso B2:

#### Un administrador gestiona los puestos de trabajo

```
Un administrador puede editar y eliminar cualquier puesto de trabajo publicado.
```



