Algoritmo Act1_Lecc15_Inciso1
	Definir tipo , badulto , bnino, totalb Como Entero
	Definir totald Como Real
	
	badulto = 0
	bnino = 0
	totald = 0
	
	Repetir
		Escribir "Tipo de boleto (1=Adulto, 2=Niñom 0=Terminar)"
		leer tipo
		Si tipo = 1 Entonces
			badulto = badulto + 1
			totald = totald + 15
		Fin Si
		Si tipo = 2 Entonces
			bnino = bnino + 1
			totald = totald + 10
		FinSi
	Hasta Que tipo = 0
	totalb = badulto + bnino
	
	Escribir "Boletos de adulto vendidos:  ",badulto
	Escribir "Boletos de niño vendidos: " ,bnino
	Escribir "Total de voletos vendidos: " ,totalb
	Escribir "Total de dinero vendido: Q.",totald
	
FinAlgoritmo
