long Factorial(long number)
{
	if(number < 1)
	{
		return 0;
	}
	else if (number == 1)
	{
		return 1;
	}
	else
	{
		return number * Factorial(number - 1);
	}
}
