<Query Kind="Program" />

void Main()
{
	//1 - Un programa que sume todos los números del 1 al 10
	
	int numero = 0;
	
	for (int i = 1; i <= 10; i++)
	{
		int suma = numero + i;
		numero = suma;
	}
	
	//Console.WriteLine(numero);

	//2- Un Programa que guarde todos los números del 1 al 10 y los muestre

	int [] numeros = new int[10];

	for (int i = 1; i <= 10; i++)
	{
		numeros[i-1] = i;
	}

	Console.WriteLine(numeros);
}
