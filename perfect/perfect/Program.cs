int firstNumber, secondNumber, n, i, sum;

Console.WriteLine("Enter the first number");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number");
secondNumber = int.Parse(Console.ReadLine());

for ( n = firstNumber; n <= secondNumber; n++)
{
	 i = 1;
	sum = 0;
	while (i < n)
	{
        if (n % i == 0)
            sum = sum + i;
        i++;
    }
	if (sum == n && n !=0)
	{
		Console.WriteLine("{0} ", n);
	}
	
		
}