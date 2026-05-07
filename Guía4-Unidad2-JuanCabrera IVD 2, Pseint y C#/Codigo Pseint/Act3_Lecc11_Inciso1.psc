Algoritmo Act3_Lecc11_Inciso1
	Definir a , b , meno , mayo , c, suma Como Entero
	
	Escribir "Digite un numero: "
	leer a
	Escribir "Digite otro numero: "
	Leer b
	
	Si a>b Entonces
		mayo = a
		meno = b
	SiNo
		mayo = b
		meno = a
	Fin Si
	suma = 0
	c = meno
	Repetir
		suma = suma + c
		c = c + 1
	Hasta Que c > mayo
	
	Escribir "La suma de los numero entre ",meno, " y ",mayo " es " ,suma
	
FinAlgoritmo
