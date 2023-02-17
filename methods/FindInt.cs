//Returns index of a number when it is found in a list
int FindInt(int x, List<int> list)
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
