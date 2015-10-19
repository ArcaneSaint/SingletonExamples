using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace SingletonExamples.Voorbeeld_2
{
	public class Singleton
	{

		public static Singleton Instance(){
			if (instance == null)
			{
					instance = new Singleton();
			}
			return instance;
		}

		
		private Singleton()
		{
			Thread.Sleep(5000);//Zware initialisatie-code, duurt 5 seconden voor SingletonData bestaat.
			SingletonData = "";
		}

		public string SingletonData { get; set; }

		private static Singleton instance;
	}
}
