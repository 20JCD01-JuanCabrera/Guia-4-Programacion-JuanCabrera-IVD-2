Algoritmo Act2_Lecc11_Inciso3
	Definir a1 , b2 , mayo, meno, c Como Entero
	
	Escribir "Digite un numero:  "
	leer a1
	Escribir "Digite un numero: "
	leer b1
	
	Si a1>b1 Entonces
		mayo = a1
		meno = b1
	SiNo
		mayo = b1
		meno = a1
	Fin Si
	c = meno
	Repetir
		Si c Mod 4 = 0 Entonces
			Escribir c
		Fin Si
		c = c + 1
	Hasta Que c > mayo
	
	
	
FinAlgoritmo
