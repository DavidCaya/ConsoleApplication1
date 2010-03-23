using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApplication1.Library;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Your name?");
			string name = Console.ReadLine();

			while (!name.Validate())
			{
				Console.WriteLine("A name must not have any number. Retry.");
				name = Console.ReadLine();
			}

			Console.WriteLine("Hello " + name);

			Console.ReadLine();
		}
	}
}
