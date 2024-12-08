# HPA3-Proyecto
Repositorio que contiene el proyecto final de la materia HPA3.


## Configuracion del Proyecto
1. Clona el repositorio en tu máquina local.
   
2. Configura la cadena de conexión a la base de datos en el archivo `appsettings.json`. Cambia `(local)` por la cadena que te proporciona SQL Management Studio:

3. En el archivo `appsettings.json` cambia el (local) por lo que te da el SQLManagementStudio
   ![Image](https://i.sstatic.net/TCILp.png)

   
Ejemplo:

    "ConnectionStrings": {
    "DefaultConnection": "Data Source=[NombreDeTuServer\\SQLEXPRESS];Database=[nombreDeTuBaseDatos];Trusted_Connection=true;TrustServerCertificate=true;"
    }

## Ejecución del Proyecto
- Restarua las dependencias del proyecto
   ```
    dotnet restore
   ```

## restaura la base de datos 
- Asegúrate de ejecutar todos los scripts en tu **SQL Server Management Studio**
- El script de creación de la base de datos no está por lo que debes ejecutar un
  `create database [nombre de tu base de datos]`
  Y luego ejecutar los scripts en el folder `/SQL SCRIPTS` dentro de la base de datos que creaste.



