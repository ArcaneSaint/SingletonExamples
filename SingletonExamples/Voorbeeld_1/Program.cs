using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExamples.Voorbeeld_1
{
	/// <summary>
	/// Eerste voorbeeld.
	/// Deze implementatie van Singleton is niet threadsafe.
	/// </summary>
	public class Program
	{
		public static void run()
		{
			Console.Out.WriteLine("=====vb1=====");
			Singleton singleton = Singleton.Instance();
			Singleton theSame = Singleton.Instance();
			Singleton third = Singleton.Instance();

			singleton.SingletonData += "Hello";
			theSame.SingletonData += " World!";
			
			Console.Out.WriteLine(third.SingletonData);
		}
	}
}
