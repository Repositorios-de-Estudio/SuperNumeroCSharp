# SuperNumeroCSharp
 El supernumero de x (donde x es un entero mayor o igual a cero)


Supernumero El supernumero de x (donde x es un entero mayor o igual a cero) se define como:

	• x, si x es inferior a 10.
	• x más el supernumero de la suma de los dígitos de x, si x es igual o superior a 10.

Ejemplo: El supernumero de 317 es

	```
	Supernumero(317) = 317 + Supernumero(3+1+7) 
					 = 317 + Supernumero(11)
					 = 317 + 11 + Supernumero(2)
					 = 317 + 11 + 2
					 = 330
	```