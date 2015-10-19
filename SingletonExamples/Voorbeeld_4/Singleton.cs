using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExamples.Voorbeeld_4
{
	public class Singleton
	{
		/// <summary>
		/// lazily creates a thread-safe instance of Singleton.
		/// </summary>
		private static Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());

		/// <summary>
		/// Returns the one and only existing instance of the singleton.
		/// </summary>
		public static Singleton Instance
		{
			get
			{
				return lazyInstance.Value;
			}
		}
		/// <summary>
		/// The data contained by this singleton. It is unique, so treat it with care ;)
		/// </summary>
		public object SingletonData { get; set; }
	}
}
