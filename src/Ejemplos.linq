<Query Kind="Program" />

void Main()
{
	bool verdad = true;
	
	string nombre = "Juan";
	
	char letra = 'C';
	
	int numero = 1;
	
	//If
	if(verdad)
	{
		
	}
	
	//While loop
	while(false)
	{
		
	}
	
	Console.WriteLine(GetNombre(nombre, 12345));
	
	//For loop
	for(int i = 0 ; i > 10; i++)
	{
		
	}
	
	string [] array = new string []{ };

	//1 - Un programa que sume todos los números del 1 al 10

	int numero2 = 0;

	for (int i = 1; i <= 10; i++)
	{
		int suma = numero2 + i;
		numero2 = suma;
	}

	//Console.WriteLine(numero);

	//2- Un Programa que guarde todos los números del 1 al 10 y los muestre

	int[] numeros = new int[10];

	for (int i = 1; i <= 10; i++)
	{
		numeros[i - 1] = i; // i-1 porque los arrays empiezan en la posición 0
	}

	Console.WriteLine(numeros);
}

string GetNombre(string nom, int age)
{	
	return nom +age;
}