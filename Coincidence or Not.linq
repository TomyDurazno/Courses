<Query Kind="Program" />

void Main()
{
	/*
	Coincidence or Not:	
	*/
	
	//1- Primero hay que ingresar una palabra por teclado
	string palabra = Console.ReadLine();
	
	/*
	Como lo que debemos hacer es sumar el valor numérico de cada letra,
	hay que separar la palabra, osea sería transformar
	
		string -> char []
		
	una palabra en la colección de sus letras. Para eso, podemos acceder a cada una de las letras
	de nuestra string accediendo por indice, tal como si fuera un array 
	Por ejemplo:
	
		string nombre = "Juan";
		
		char letra = nombre[0]; //letra ahora vale 'J'
		
	vamos a hacer una función que reciba una palabra y devuelva un array de letras	
	y además devuelve cada letra en mayúscula (ya que el cartel trabaja todo con mayúsculas)
	para convertir una letra minúscula en mayúscula, vamos a usar la función 'char.ToUpper'
	
		char c = 'J';
		char.ToUpper(c);
	
	Se va a llamar 'StringToCharArray' (ver abajo)
			
	*/
	
	char[] letras = StringToCharArray(palabra);

	/*
	Una vez que tengamos la palabra separada en letras, debemos tener una forma de saber cuál es su valor numérico,
	sabiendo que:
	
		A es 1, B es 2, C es 3, D es 4 y así
	
	para eso vamos a armar un array con todas las letras, poniendo a la A en la posición 0, (la inicial),
	B en la posición 1 y así, sabiendo que el valor que le corresponde a cada letra es de su posición + 1	
	Para eso vamos a hacer una función que recibe un abecedario y una letra, y devuelve
	el valor numérico de la misma.
	Se va a llamar 'ValorDeLaLetra' (ver abajo)
	*/

	char [] abecedario = new char[] { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
	
	/*
	Ahora, lo que debemos hacer es recorrer el array de letras, y de cada letra sacar:
	su valor numérico, para poder mostrar el porcentaje total y a la vez el de cada letra.	
	
	Vamos a crear una variable int para tener el valor de la suma, un string que va a representar 
	la suma de todos los números (como si fueran una palabra, ej: "1+2+3")
	y otro string para representar la suma de todas las letras 	
	*/

	int cantidadDeLetras = letras.Length;
	int contador = 0;
	int sumaTotal = 0;
	string sumadeLetras =  ""; //Valor inicial un string vacío
	string sumaDeNumerosComoLetras = "";

	/*En cada vuelta del loop se va a sumar

		- a 'sumaTotal' el valor numérico
		- a 'sumaDeLetras' la letra como mayúscula
		- a 'sumaDeNumerosComoLetras' el número como letra
		
		las 2 últimas sumas necesitan tener el símbolo '+' adelante de cada letra,
		menos en el primer caso. Ejemplo:
		
			"Juan" -> "J+U+A+N"
			
		Entonces se va a usar un 'if' para sumarlo en todas las vueltas menos la primera
	*/
		
	while(cantidadDeLetras > contador)
	{	
		char letra = char.ToUpper(letras[contador]); 		

		int valor = ValorDeLaLetra(abecedario, letra);

		if(contador == 0) //Significa que es la primera vuelta del loop
		{
			sumadeLetras = sumadeLetras + letra;
			sumaDeNumerosComoLetras = sumaDeNumerosComoLetras + valor;
		}
		else
		{
			sumadeLetras = sumadeLetras + "+" + letra;
			sumaDeNumerosComoLetras = sumaDeNumerosComoLetras + "+" + valor;
		}
		
		sumaTotal = sumaTotal + valor;
		
		contador++;
	}
	
	//Ahora, mostrar por consola los valores
	
	Console.WriteLine(sumadeLetras);
	Console.WriteLine(sumaDeNumerosComoLetras + " = " + sumaTotal + "%");
}

int ValorDeLaLetra(char [] abecedario, char letra)
{
	int contador = 0;
	while(abecedario.Length > contador)
	{
		if(abecedario[contador] == char.ToUpper(letra))
		{
			return contador + 1;	
		}
		
		contador++;
	}
	
	//Este caso nunca debería darse, significa que la letra no está en el abecedario
	return 0;
}

char [] StringToCharArray(string palabra)
{
	int cantidadDeLetras =  palabra.Length; //cantidad de veces que debe 'iterarse'
	int contador = 0; // posición inicial
	char [] letras = new char[cantidadDeLetras]; //array acumulador de letras
	
	while (cantidadDeLetras > contador)
	{
		letras[contador] = palabra[contador];
		contador++; //acumentar el contador +1 cada vuelta del 'while loop'
	}
	
	return letras;
}
