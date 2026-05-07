Algoritmo Act3_Lecc24_Inciso2
	Definir a , b , c , d, e Como entero
	
	Escribir "Ingrese un numero: "
	leer a
	
	Si a <=1 Entonces
		Escribir "Ingrese un valor mayor a 1"
	SiNo
		Para b=a Hasta 1 Con Paso -1 Hacer
			Escribir b
			d = b + 1
			e = e + b
		Fin Para
		Escribir "La suma es: ",e
	Fin Si
	
FinAlgoritmo
