using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

			Singleton s1;
			Singleton s2;

			Thread thread1 = new Thread(() =>
			{
				s1 = Singleton.Instance(); 
				s1.SingletonData += "thread1";
				Console.Out.WriteLine(s1.SingletonData);
			});
			Thread thread2 = new Thread(() =>
			{
				s2 = Singleton.Instance(); 
				s2.SingletonData += "thread2";
				Console.Out.WriteLine(s2.SingletonData);
			});

			thread1.Start();
			thread2.Start();

			thread1.Join();
			thread2.Join();
		}
	}
}
