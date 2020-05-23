using System;

public class Test
{

	interface Event
	{

		int sum(ref Day[] day2020);
		void dayMin(ref Day[] day2020);

	}

	class Exhibition : Event
	{

		public string nameExhibition = "none";
		public string surnameAuthor = "none";

		public Exhibition()
		{
			nameExhibition = "none";
			surnameAuthor = "none";
		}

		public Exhibition(string n, string s)
		{
			nameExhibition = n;
			surnameAuthor = s;
		}

		public int sum(ref Day[] day2020)
		{
			return 0;
		}
		public void dayMin(ref Day[] day2020)
		{

		}


	}

	class Day : Exhibition
	{

		public int number = 0;
		public string rem = "none";

		public Day()
		{
			number = 0;
			rem = "none";
		}

		public Day(int n, string r)
		{
			number = n;
			rem = r;
		}

		public int sum(ref Day[] day2020)
		{
			return 0;
		}
		public void dayMin(ref Day[] day2020)
		{

		}

	}

	static int sum(ref Day[] day2020)
	{

		int summa = 0;

		for (int i = 0; i < 5; i++)
		{

			summa = summa + day2020[i].number;

		}

		Console.WriteLine("Summa = " + summa);

		return summa;
	}

	static void dayMin(ref Day[] day2020)
	{

		int min = 0;

		for (int i = 0; i < 5; i++)
		{

			if (day2020[i].number < day2020[min].number)
			{
				min = i;
			}

		}

		Console.WriteLine("Day ( min ) = " + (min + 1));

	}

	static void find(ref Day[] day2020, string s)
	{


		for (int i = 0; i < 5; i++)
		{

			if (day2020[i].rem == s)
			{
				Console.WriteLine("Present: " + s);
			}

		}

	}

	static void testSum(int a)
	{

		Day[] day2020 = new Day[5];

		for (int i = 0; i < 5; i++)
		{
			day2020[i] = new Day();
			day2020[i].number = a;
			day2020[i].rem = "test";
		}

		int s = sum(ref day2020);

		if (s == (a * 5))
		{
			Console.WriteLine("Function Sum work correct.");
		}
		else
		{
			Console.WriteLine("Function Sum work uncorrect !!!");
		}

	}


	public static void Main()
	{

		Day[] day2020 = new Day[5];

		for (int i = 0; i < 5; i++)
		{
			day2020[i] = new Day();
			day2020[i].number = 24 + i;
			day2020[i].rem = "hi" + i;
		}

		string z = "";
		Console.WriteLine("Select punct menu:");
		Console.WriteLine("1. Find, press: f");
		Console.WriteLine("2. Found min, press: m");
		Console.WriteLine("3. Found sum, press: s");
		Console.WriteLine("4. Exit, press: x");
		Console.WriteLine("5. Test function Sum, press: u");
		z = Console.ReadLine();

		switch (z)
		{

			case "f":
				find(ref day2020, "hi2");
				break;
			case "m":
				dayMin(ref day2020);
				break;
			case "s":
				sum(ref day2020);
				break;
			case "x":
				Console.WriteLine("Exit");
				break;
			case "u":
				testSum(20);
				break;
			default:
				Console.WriteLine("Select carent punct menu!");
				break;
		}

	}
}