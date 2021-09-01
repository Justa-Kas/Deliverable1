using System;

namespace Deliverable1
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool doWeDoIt = true;
			while (doWeDoIt == true)
			{
				Console.Write("Please enter the temperature (numbers only): ");
				double temp = double.Parse(Console.ReadLine());
				Console.Write("Please enter the measurement type: ");
				string measurementType = Console.ReadLine();

				if (measurementType.ToLower() == "inches")
				{
					Console.WriteLine("That converts to " + temp * 3.5 + " fidget spinners.");
				}
				else if (measurementType.ToLower() == "inch")
				{
					Console.WriteLine("That converts to " + temp * 3.5 + " fidget spinners.");

				}
				else if (measurementType.ToLower() == "fidget spinners")
				{
					Console.WriteLine("That converts to " + temp / 3.5 + " inches.");
				}
				else if (measurementType.ToLower() == "fidget spinner")
				{
					Console.WriteLine("That converts to " + temp / 3.5 + " inches.");


				}
				else if (measurementType.ToLower() == "feet")
				{
					Console.WriteLine("That converts to " + temp * 5 + " memes.");
				}
				else if (measurementType.ToLower() == "foot")
				{
					Console.WriteLine("That converts to " + temp * 5 + " memes.");


				}
				else if (measurementType.ToLower() == "memes")
				{
					Console.WriteLine("That converts to " + temp / 5 + " feet.");
				}
				else if (measurementType.ToLower() == "meme")
				{
					Console.WriteLine("That converts to " + temp / 5 + " feet.");
				}

				Console.Write("Do you wish to do another calculation?: ");
				string doesItLoop = Console.ReadLine();
				if (doesItLoop.ToLower() != "yes")
				{
					doWeDoIt = false;
				}
			}
		}
	}
}
