int firstNumber, secondNumber, sum = 0;

Console.WriteLine("Please enter the first number");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number");
secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("\n The prime numbers between {0} and {1} is : \n", firstNumber, secondNumber);


for (int i = firstNumber; i <= secondNumber; i++)
{
    sum = 0;
    for (int k = 2; k <= i / 2; k++)
    {
        if (i % k == 0)
        {
            sum = sum + 1;
            break;
        }
    }
    if (sum == 0 && i != 1 && i != 0)
    {
        Console.WriteLine("\t {0}", i);
    }
}