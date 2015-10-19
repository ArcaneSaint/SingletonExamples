using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonExamples.Voorbeeld_1;



namespace UnitTestSingleton
{
	[TestClass]
	public class UnitTestVoorbeeld1
	{
		[TestMethod]
		public void TestNewSingletonDataNotEmpty()
		{
			Singleton singleton = Singleton.Instance();
			Assert.IsNotNull(singleton.SingletonData);
		}
		[TestMethod]
		public void TestNewSingletonDataIdentical()
		{
			Singleton singleton1 = Singleton.Instance();
			Singleton singleton2 = Singleton.Instance();
			Assert.AreSame(singleton1.SingletonData, singleton2.SingletonData);
		}
		[TestMethod]
		public void TestSingletonDataChangeIdentical()
		{
			Singleton singleton1 = Singleton.Instance();
			Singleton singleton2 = Singleton.Instance();
			singleton1.SingletonData += "Hello Test.";
			Assert.AreSame(singleton1.SingletonData, singleton2.SingletonData);
			singleton2.SingletonData += "\nIt's a beautiful day!";
			Assert.AreSame(singleton1.SingletonData, singleton2.SingletonData);
		}
		[TestMethod]
		public void TestSingletonInstancesIdentical()
		{
			Singleton singleton1 = Singleton.Instance();
			Singleton singleton2 = Singleton.Instance();
			Assert.AreSame(singleton1, singleton2);
		}
	}
}
