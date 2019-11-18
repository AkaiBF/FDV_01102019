# Práctica GIT LFS
- Echeverría González, Ernesto
- Hernández Padrón, Manuel
- Pescador Barreto, Germán Andrés

## Informe de documentación del proceso
Primeramente se creó un repositorio en GitHub desde la web.

Seguidamente el administrador del repositorio (Ernesto) creó una carpeta desde el ordenador usando el comando:
- git init

y accedió a ella desde la consola de git con los comandos:
- cd

Los colaboradores (Germán y Manuel) crearon una carpeta contenedora de todos los documentos de los futuros proyectos ligada al repositorio previamente creado en GitHub. Para ello se utilizó el comando: 
- mkdir "nombre_de_la_carpeta"

y para acceder a la carpeta:
- cd "nombre_de_la_carpeta"

Los colaboradores clonaron un repositorio github a la carpeta creada por ellos. Para ello fue necesario ir al repositorio github, copiar el enlace en clone/download y pegarlo seguido al siguiente comando: 
- git clone https://github.com/AkaiBF/FDV_01102019.git

Para archivos muy pesados (como imágenes, etc...) hay que usar git LFS. Para ello hay que descargarlo desde la página web, instalar el paquete abriendo el archivo ejecutable e instalarlo e inicializar desde la consola usando el comando:
- git lfs install

Es necesario instalar git lfs en la consola e inicializarlo si en el repositorio en sí no lo he hecho anteriormente (o incluso si lo he usado anteriormente, pero lo estoy utilizando desde otro ordenador).

Hecho esto, hubo que crear un fichero de texto y subirlo al repositorio. Para abrir y editar un fichero de texto se utilizó el siguiente comando:
- nano nombre_del_fichero

Hay que tener en cuenta que si se guarda vacío no se llega a crear. Si la intención es crearlo vacío habría que usar el comando:
- touch nombre_del_fichero

Los archivos de texto .gitignore sirven para ignorar ciertos archivos o carpetas a la hora de hacer un commit. Estos archivos se pueden modificar utilizando el comando VIM (vim .gitignore) en caso de Windows y Nano en caso de Linux. Una vez estamos dentro del archivo debemos escribir los nombres de las carpetas u archivos que queremos ignorar. Para salir hay que escribir en consola ":q" y presionar enter, o ":wq" para guardar los cambios y salir. 

Para añadir archivos se puede escribir el nombre de un fichero específico o usar un punto para añadirlos todos:
- git add .

Para guardar los cambios en una nueva versión (commit) se utilizó el siguiente comando, donde la “m” significa mensaje y sirve para poder escribir el nombre al commit:
- git commit -m "nombredelcommit"   

Para subir un commit a un repositorio de github se utiliza frecuentemente el siguiente comando:
- git commit -m "nombre_del_commit"

Origin es el nombre de la rama del github normalmente, pero puede tener el nombre que deseemos, y master es la rama a la que vamos a subir el archivo a github (lo normal es subirla a la rama master ya que es la que contendrá las versiones estables del proyecto).

Para descargar cambios usar:
- git pull

Para subir los cambios (como cambio puede entenderse arrastrar nuevos archivos a la carpeta):
-                            git push -u origin master

En definitiva, el orden para cualquier cambio en el repositorio es: 
1. git add 
2. git commit -m “nombredelcommit” 
3. git pull 
4. git push -u origin master



