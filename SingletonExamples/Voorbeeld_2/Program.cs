using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExamples.Voorbeeld_2
{
	public class Program
	{
		/// <summary>
		/// Thread Fail Example
		/// </summary>
		public static void run()
		{
			Console.Out.WriteLine("=====vb2=====");

			Singleton singleton = Singleton.Instance();
			Singleton theSame = Singleton.Instance();
			Singleton third = Singleton.Instance();

			singleton.SingletonData += "Hello";
			theSame.SingletonData += " World!";

			Console.Out.WriteLine(third.SingletonData);
		}
	}
}
