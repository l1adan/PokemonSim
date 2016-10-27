using System;

namespace Poke
{
	public class Adventure
	{
		Player player = new Player ();

		public static void StartingAdventure ()
		{
			Console.WriteLine ();
			Console.WriteLine ("Press enter to continue:");
			Console.WriteLine ();

			Console.ReadKey ();
			Console.Clear ();

			Console.WriteLine ();

			Console.WriteLine ("Now it's time to start your adventure and catch Pokemon !");
			Console.WriteLine ();
			Console.WriteLine ("To catch pokemon, you'll need Poke Balls. Here!");
			Console.WriteLine ("\a"+ player.CharacterName + " received 3 pokeballs!");       //CharacterName
			Console.WriteLine ();

			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ("You need to move around to find Pokemon.");
			Console.WriteLine ("To start moving in a direction:");






		}
	}
}

