using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExamples.Voorbeeld_3
{
	public class Singleton
	{

		private static readonly object _lock = new object();

		public static Singleton Instance(){
			lock (_lock)
			{
				if (instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			}
		}

		private Singleton()
		{
			Thread.Sleep(5000);//Zware initialisatie-code, duurt 5 seconden voor SingletonData bestaat.
			SingletonData = "";
		}

		public string SingletonData { get; set; }

		private static Singleton instance = new Singleton();
	}
}
