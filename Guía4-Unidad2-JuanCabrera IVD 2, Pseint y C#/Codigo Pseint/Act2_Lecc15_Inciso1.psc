Algoritmo Act2_Lecc15_Inciso1
	Definir a , b , c , d Como Entero
	c = 0
	Para a = 2 Hasta 100 Con Paso 1 Hacer
		d = 0
		Para b = 1 Hasta a Hacer
			Si a Mod b = 0 Entonces
				d = d +1
			Fin Si
		Fin Para
		Si d = 2 Entonces
			c = c + a
		Fin Si
	Fin Para
	Escribir "La suma de los numero primos entre 1 y 100 es: ",c
FinAlgoritmo
