Algoritmo Act3_Lecc24_Inciso1
	Definir a , b , c , d Como Entero
	d = 0
	
	Para a=1 Hasta 50 Con Paso 1 Hacer
		c = 0
		Para b = 1 Hasta a  Hacer
			Si a mod b = 0 Entonces
				c = c + 1
			FinSi
		Fin Para
		Si c = 2 Entonces
			d = d + a
		FinSi
		
	Fin Para
	Escribir d
	
FinAlgoritmo
