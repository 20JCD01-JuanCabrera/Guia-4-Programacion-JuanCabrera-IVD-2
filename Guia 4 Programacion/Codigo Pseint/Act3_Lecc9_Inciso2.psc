Algoritmo Act3_Lecc9_Inciso2
	Escribir "==== Numeros primos ===="
	Definir a , b,c como Entero
	Escribir "Digite un numero: "
	leer b
	
	a= 0
	c = 1
	
	Mientras c<= b Hacer
		Si b MOD c = 0 Entonces
			a = a+1
		FinSi
		c = c+1
	Fin Mientras
	Si a = 2 Entonces
		Escribir b, " Es primo"
	SiNo
		Escribir b, " No es primo"
	FinSi
	
	
	
	
FinAlgoritmo
