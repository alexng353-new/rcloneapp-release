using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using functions;
using System.Threading;


/*
Yes, it's not very optimized, yes, someone else can do it better
Make sure the configs are the same or else it doesn't look as pretty
*/

namespace Global
{
	class Variables
	{
		public static string[] configs = { "configs", "you", "want", "to", "mount" };
	}
}

namespace Run
{
	class Default
	{
		class ConfigNames
		{
			public string Config { get; set; }
			public string Letter { get; set; }
		}

		public static void Mount()
		{
			var configs = new Dictionary<int, ConfigNames>()
			{
				{ 111, new ConfigNames { Config="configs", Letter="Z" } },
				{ 112, new ConfigNames { Config="you", Letter="X" } },
				{ 113, new ConfigNames { Config="want", Letter="R" } },
				{ 114, new ConfigNames { Config="to", Letter="K"} },
				{ 115, new ConfigNames { Config="mount", Letter="P"} },
			};

			foreach (var index in Enumerable.Range(111, 7))
			{
				functions.functions.Mount(configs[index].Config, configs[index].Letter);
			}

			Thread.Sleep(1000);
			Console.WriteLine("\nOk finished\n");
		}
	}
}
