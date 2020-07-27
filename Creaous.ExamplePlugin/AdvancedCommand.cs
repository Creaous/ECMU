using ECMU.Plugins; // Plugin DLL needed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creaous.ExamplePlugin
{
	class AdvancedCommand : IPlugin // YOU NEED THIS TO PROBABLY USE THE PLUGIN
	{
		string name = "ExamplePlugin by Creaous"; // Name for some functions.

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
				return "advancedcommand"; // Make the command 'advancedcommand'.
			}
		}

		public void Go(string parameter1, string parameter2, string parameter3, string parameter4, string parameter5, string parameter6, string parameter7, string parameter8) // Action that is taken after it is ran.
		{
			Console.WriteLine("-----> " + name + " <-----\n"); // Write a line to the command line.

			Console.ForegroundColor = ConsoleColor.Green; // Change the color to 'Green'.
			Console.WriteLine("This command isn't really that advanced though."); // Write a simple line.
			Console.ResetColor(); // Reset the color to default to avoid saving color.
		}
	}
}
