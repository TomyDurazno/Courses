<Query Kind="Program" />

void Main()
{
	//Asignación de un booleano
	bool verdad = true;
	
	//Asignación de una variable del tipo string
	string nombre = "Juan";
	
	//Asignación de una letra
	char letra = 'C';
	
	//Asignación de un número
	int numero = 1;
	
	//If
	if(verdad)
	{
		
	}
	
	//While loop
	while(false)
	{
		
	}
	
	//Invocar una función
	Console.WriteLine(GetNombre(nombre, 12345));
	
	//For loop
	for(int i = 0 ; i > 10; i++)
	{
		
	}
	
	//Array de String
	string [] array = new string []{ "ABC", "DEF" };

	//1 - Un programa que sume todos los números del 1 al 10

	int numero2 = 0;

	for (int i = 1; i <= 10; i++)
	{
		int suma = numero2 + i;
		numero2 = suma;
	}

	Console.WriteLine(numero2);

	//2- Un Programa que guarde todas las decenas del 10 al 100 y las muestre

	int [] numeros = new int[10];

	for (int i = 0; i < 10; i++)
	{
		numeros[i] = (i + 1) * 10; 
	}

	Console.WriteLine(numeros);
}

string GetNombre(string nom, int age)
{	
	return nom + age;
}