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
}

string GetNombre(string nom, int age)
{	
	return nom +age;
}