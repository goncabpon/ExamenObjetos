# ExamenObjetos
Examen Objetos
##Nombre: Gonzalo Jose 
##Apellidos: Caballero Ponce
##DNI: 15402396D
## Pregunta 1
## Pregunta 2
## Pregunta 3
## La variable shapes es una lista de formas y contiene los cuatro objetos que indica el ejemplo. Cada objeto viene de una clase distinta, aunque todas las clases con las que est�n hechos estos objetos heredan de la interfaz Ishape. 
##Cada objeto tiene un color distinto. Este color se lo da la propiedad color dentro de cada una de las clases (la propiedad color se comporta de manera distinta seg�n la clase en la que est� funcionando).
##Una vez explicada que es la variable shapes y qu� objetos contiene, con un foreach que dibuja cada una d elas formas que hay en la lista shapes.

##La t�cnica que se est� usando es el polimorfismo. Lo estoy usando porque al usar varias clases que heredan de una misma clase, los m�todos de la clase Figura funcionan en las dem�s clases, pero en cada una de ellas se comportan de una manera distinta.
##El polimorfismo consiste en que una acci�n puede dar m�s de un resultado seg�n lo que queramosl Se utiliza cuando una clase hereda a otra sus atributos y m�todos. Cuando esto sucede, las subclases pueden tener los mismos atributos y m�todos y dar resultados distintos.
##Para que se den estos resultados distintos hay que hacer sobreescritura del m�todo, override.

## Pregunta 4
##Se puede hacer con la interfaz IDisposable. Esta interfaz proporciona un mecanismo para liberar recursos no administrados. Para liberar estos recursos hay que usar el m�todo dispose, y eso se consigue usando using en el objeto donde queremos que salte el m�todo Dispose.
##C�mo se implementa: Para implementarlo hay que hacer que la clase que nos interese extienda de IDisposable, y crear un m�todo Dispose dentro de ella public void Dispose(){}
##Despu�s al objeto que nos interese de la clase a la que le hemos puesto el Dispose le hacemos el using (nombre_del_objeto){}. De esta manera saltar� el m�todo Dispose y se podr�n eliminar recursos.

## Pregunta 5
## El principio SOLID que se est� cumpliendo es la I. Este principio se denomina �Principio de segregaci�n de interfaz� y establece que es mejor utilizar varias interfaces con una funci�n espec�fica cada una que una sola interfaz general.
## El objetivo de que haya muchas interfaces espec�ficas es que solo se usen aquellas que tengan los m�todos que realmente se necesitan, ignorando a las dem�s.


