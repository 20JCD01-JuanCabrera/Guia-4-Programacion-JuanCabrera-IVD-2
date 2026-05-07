Algoritmo Act3_Lecc15_Inciso1
	Definir a , b , c, d Como Entero
	
	a = 0
	b = 0
	
	Para c=1 Hasta 20  Hacer
		d = 7 * c
		a = a + d
		Si d Mod 2 = 0 Entonces
			b = b + 1
		Fin Si
		Escribir "7 x ",c ," = ",d
	Fin Para
	Escribir "Suma total: ",a
	Escribir "Multiplos pares: ",b
	
FinAlgoritmo
