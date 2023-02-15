//Returns the index of an integer if it is found in a List, -1 is returned otherwise.

int findInt(int x, List<int> list)
{
	for (int i = 0; i < list.Count; i++)
	{
		if (list[i] == x)
		{
			return i;
		}
		
		
	}
	return -1;
}

Console.WriteLine(findInt(7, new List<int> { 0, 1, 2, 3 }));
