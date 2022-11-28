// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(linearSearch(new int[] { 10, 20, 30 }, 10));


int linearSearch(int[] arr, int val)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] == val)
			return i;
	}
	return -1;
}
