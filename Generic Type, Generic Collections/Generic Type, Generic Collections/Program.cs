namespace Generic_Type__Generic_Collections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ListInt<int> listint = new ListInt<int>();
			listint.Add(5);
			listint.Add(24);
			listint.Add(63);
			listint.Add(1);
			listint.Add(7);

			Console.WriteLine($"Added elements : {listint}");

			listint.Remove(5);
			Console.WriteLine($"Removed elment(s) : {listint}");

			listint.AddRange(1, 2, 3, 4, 5);
			Console.WriteLine($"Added ranges : {listint}");

			Console.WriteLine(listint.Contains(5));

			listint.RemoveRange(1, 1, 3);
			Console.WriteLine($"Removed range : {listint}");

			listint.ToString();
		}
	}
}


