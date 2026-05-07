Algoritmo Act2_Lecc15_Inciso2
	Definir i , billete, b100 , td Como Entero
	b100 = 100
	td = 0
	
	Para i = 1 Hasta 1000  Hacer
		Escribir "Ingresa el valor del billete ", i , " (Q.20, Q.50, Q.100)"
		leer billete
		
		Si billete = 20 o billete = 50 o billete = 100 Entonces
			td = td + billete
			Si billete = 100 Entonces
				b100 = b100 + 1
			FinSi
		SiNo
			Escribir "Ingrese un billete valido porfa"
		Fin Si
	Fin Para
	Escribir "Billetes de 100: ",b100
	Escribir "Total de dinero: ",td
	
FinAlgoritmo
