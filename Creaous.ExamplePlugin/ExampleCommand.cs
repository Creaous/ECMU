using ECMU.Plugins; // Plugin DLL needed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creaous.ExamplePlugin
{
    class ExampleCommand : IPlugin // YOU NEED THIS TO PROBABLY USE THE PLUGIN
    {
		public string Explanation // Description of the command.
		{
			get
			{
				return "Just an example command that prints text out."; // Description, just read the other comment.
			}
		}

		public string Name // Name of the command.
		{
			get
			{
				return "examplecommand"; // Make the command 'examplecommand'.
			}
		}

		public void Go(string parameter1, string parameter2, string parameter3, string parameter4, string parameter5, string parameter6, string parameter7, string parameter8) // Action that is taken after it is ran.
		{
			Console.WriteLine("This is an example command sent from the ExamplePlugin!"); // Write a line to the command line.
		}
    }
}
