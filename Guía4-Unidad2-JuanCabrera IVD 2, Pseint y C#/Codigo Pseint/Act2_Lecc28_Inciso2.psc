Algoritmo Act2_Lecc28_Inciso2
		
		Definir tipo, boletosAdulto, boletosNino, totalBoletos Como Entero
		Definir totalDinero Como Real
		
		boletosAdulto <- 0
		boletosNino <- 0
		totalDinero <- 0
		totalBoletos <- 0
		
		Repetir
			Escribir "¿Es niño o adulto? (1=Adulto / 2=Niño / 0=Terminar):"
			Leer tipo
			
			Si tipo = 1 Entonces
				boletosAdulto <- boletosAdulto + 1
				totalDinero <- totalDinero + 15
				Escribir "Boletos vendidos: ", boletosAdulto + boletosNino, " | Total: $", totalDinero
			FinSi
			
			Si tipo = 2 Entonces
				boletosNino <- boletosNino + 1
				totalDinero <- totalDinero + 10
				Escribir "Boletos vendidos: ", boletosAdulto + boletosNino, " | Total: $", totalDinero
			FinSi
			
		Hasta Que tipo = 0
		
		totalBoletos <- boletosAdulto + boletosNino
		Escribir "===== REPORTE FINAL ====="
		Escribir "Boletos adulto: ", boletosAdulto
		Escribir "Boletos niño: ", boletosNino
		Escribir "Total boletos vendidos: ", totalBoletos
		Escribir "Total cobrado: $", totalDinero
		
FinAlgoritmo

