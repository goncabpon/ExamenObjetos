# ExamenObjetos
Examen Objetos
## Nombre: Gonzalo Jose 
## Apellidos: Caballero Ponce
## DNI: 15402396D
## URL: https://github.com/goncabpon/ExamenObjetos.git

## Pregunta 1
## Pregunta 2
He creado un enum con los colores que pueden tener las formas, y después he creado la clase shape con el método Draw y el color. El método Draw es virtual
para que las demás clases puedan heredarlo. Luego he creado las demás clases que extienden de Shape y tienen el color y Draw. Dentro de estas clases
el método Draw tiene override porque se tiene que sobreescribir. 
## Pregunta 3
Al código de antes he añadido la interfaz IShape, y después he creado la variable shapes del tipo IShape con el método Draw.
Además ahora la clase Shape extiende de IShape.

##La variable shapes es una lista de formas y contiene los cuatro objetos que indica el ejemplo. Cada objeto viene de una clase distinta, aunque todas las clases con las que están hechos estos objetos heredan de la interfaz Ishape. 
##Cada objeto tiene un color distinto. Este color se lo da la propiedad color dentro de cada una de las clases (la propiedad color se comporta de manera distinta según la clase en la que está funcionando).
##Una vez explicada que es la variable shapes y qué objetos contiene, con un foreach que dibuja cada una d elas formas que hay en la lista shapes.

##La técnica que se está usando es el polimorfismo. Lo estoy usando porque al usar varias clases que heredan de una misma clase, los métodos de la clase Figura funcionan en las demás clases, pero en cada una de ellas se comportan de una manera distinta.
##El polimorfismo consiste en que una acción puede dar más de un resultado según lo que queramosl Se utiliza cuando una clase hereda a otra sus atributos y métodos. Cuando esto sucede, las subclases pueden tener los mismos atributos y métodos y dar resultados distintos.
##Para que se den estos resultados distintos hay que hacer sobreescritura del método, override.

## Pregunta 4
##Se puede hacer con la interfaz IDisposable. Esta interfaz proporciona un mecanismo para liberar recursos no administrados. Para liberar estos recursos hay que usar el método dispose, y eso se consigue usando using en el objeto donde queremos que salte el método Dispose.
##Cómo se implementa: Para implementarlo hay que hacer que la clase que nos interese extienda de IDisposable, y crear un método Dispose dentro de ella public void Dispose(){}
##Después al objeto que nos interese de la clase a la que le hemos puesto el Dispose le hacemos el using (nombre_del_objeto){}. De esta manera saltará el método Dispose y se podrán eliminar recursos.

De manera que lo que se ha hecho es a la clase Shape poner que extiende de IDisposable, e implementar la interfaz IDisposable con el método
Dispose. También se le ha hecho using a var shapes, que es el objeto donde queremos que salte el Dispose.

## Pregunta 5
##El principio SOLID que se está cumpliendo es la I. Este principio se denomina “Principio de segregación de interfaz” y establece que es mejor utilizar varias interfaces con una función específica cada una que una sola interfaz general.
##El objetivo de que haya muchas interfaces específicas es que solo se usen aquellas que tengan los métodos que realmente se necesitan, ignorando a las demás.


