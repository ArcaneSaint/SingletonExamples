using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using SingletonExamples.Voorbeeld_2;

namespace UnitTestSingleton
{
	[TestClass]
	public class UnitTestVoorbeeld2
	{
		[TestMethod]
		public void TestMultithreadFail()
		{
			Singleton s1 = null;
			Singleton s2 = null;
			Thread thread1 = new Thread(() =>
			{
				s1 = Singleton.Instance();
				s1.SingletonData += "thread1";
			});
			Thread thread2 = new Thread(() =>
			{
				s2 = Singleton.Instance();
				s2.SingletonData += "thread2";
			});
			thread1.Start();
			thread2.Start();

			thread1.Join();
			thread2.Join();

			Assert.AreNotEqual(s1.SingletonData, s2.SingletonData);
		}
	}
}
