# Node JS

Tenemos que instalar el node js pero para ver si ya lo tenemos, ponemos el comando 
````
node -v
````
Para crear un json para inicializar un proyecto, ejecutamos:
````
npm init -y
````

### Variables
````js
cont a = 200 //valor contante, no cambia nunca
let b = 10 //valor que puede ser modificado, tiene alcance dentro de su bloque de código
var c = 30 // es igual que la anterior pero es global, ya no se usa mucho
````

### Funciones
````js
funcion sumar(a,b) {} //Este tipo de funcion tiene nombre
(a,b)=>{} //Esta es función es anónima, por lo tanto no la puedo llamar para reutilizar después
````

### Notas
- Versión de nodejs != versión de npm
- Instalamos el paquete [express](https://www.npmjs.com/package/express)
````
npm i express
````
- Instalar extensión de ThunderClient para poder hacer lo que no se puede desde el navegador.

- Watch es para ejecutar cuando agreguemos algo al código sin tener que cortarlo y volver a ejecutar.
````
 node --watch app.js
 ````