<Query Kind="Program" />

void Main()
{
	/*
	FizzBuzz Challenge:
	
	Write a program that outputs the string representation of numbers from 1 to n. 
	But for multiples of three it should output "Fizz" instead of the number
	and for the multiples of five output "Buzz". 
	For numbers which are multiples of both three and five output "FizzBuzz". 
	
	Example: 
	
	n = 15, 
	
	Return: 
	[ 
		"1" 
		"2" 
		"Fizz", 
		"4" 
		"Buzz" 
		"Fizz" 
		"7" 
		"8" 
		"Fizz" 
		"Buzz", 
		"11", 
		"Fizz" 
		"13" 
		"14" 
		"FizzBuzz" 
	]
	*/
	
	EjecutarChallenge(15);
}

void EjecutarChallenge(int numero)
{	
	int contador = 1;
	
	while(numero >= contador)
	{
		Console.WriteLine(RunFizzBuzz(contador));
		contador = contador + 1;
	}
}

string RunFizzBuzz(int numero)
{
	if(EsFizzBuzz(numero))
		return "FizzBuzz";
		
	if(EsFizz(numero))
		return "Fizz";
		
	if(EsBuzz(numero))
		return "Buzz";
		
	return numero.ToString();
}

bool EsFizz(int numero)
{
	return numero % 3 == 0;	
}

bool EsBuzz(int numero)
{
	return numero % 5 == 0;
}

bool EsFizzBuzz(int numero)
{
	return EsFizz(numero) && EsBuzz(numero);
}

