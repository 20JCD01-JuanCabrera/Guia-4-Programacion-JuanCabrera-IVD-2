Algoritmo Act3_Lecc15_Inciso2
	Definir i , j , c, tp , sp Como Entero
	tp = 0
	sp = 0
	Para i = 300 Hasta 1 Con Paso -1 Hacer
		Si i Mod 2 = 0 Entonces
			sp = sp + i
		Fin Si
		c = 0
		Para j = 1 Hasta i Hacer
			Si i Mod j = 0 Entonces
				c = c + 1
			FinSi
		Fin Para
		Si c=2 Entonces
			tp = tp + 1
		FinSi
	Fin Para
	Escribir "Total numeros primos ",tp
	Escribir "Suma de los numero pares: ",sp
FinAlgoritmo
