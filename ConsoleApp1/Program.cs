using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ciao");

			int num1 = 0;
			int num2 = 0;
			int somma = 0;
			Console.WriteLine("inserisci il primo numero");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("inserisci il secondo numero");
			num2 = Convert.ToInt32(Console.ReadLine());

            somma = num1 + num2;

			Console.WriteLine("La somma è{0}", somma);


			Console.ReadLine();


		}
	}
}
