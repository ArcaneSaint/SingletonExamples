using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExamples.Voorbeeld_2
{
	public class Singleton
	{

		public static Singleton Instance(){
			if (instance == null)
			{
				for (int i = 0; i < 100000;++i)
				{
					instance = new Singleton();	
				}
			}
			return instance;
		}

		private Singleton()
		{
			SingletonData = "";
		}

		public string SingletonData { get; set; }

		private static Singleton instance;
	}
}
