Algoritmo Act3_Lecc10_Inciso1
	Escribir "==== Suma de los numero primos ===="
	Definir a , b, c , d Como Entero
	d = 0
	Para a = 2 Hasta 22 Hacer
		c = 0
		Para b=1 Hasta a Hacer
			Si a Mod b = 0 Entonces
				c = c +1 
			Fin Si
		Fin Para
		Si c = 2 Entonces
			Escribir a , " Es primo"
			d = d +a
		Fin Si
	Fin Para
	Escribir "La suma de los primos es: ",d
	
FinAlgoritmo
