using System;
using Poke;
using System.Collections.Generic;

namespace pokePracticeWithMeww
{
	class MainClass
	{
		//Get the mother fucker working.
		//Create a menu function for user to check player stats.
		//Add  player starting pokemon to Player Class
		//Create List to hold caught pokemon


		public static void Main (string[] args)
		{
			Header (); 						//	Opening game header
			Player player = new Player (); 	//	New player instantiation: Runs Character set up : Holds Character stats.
			ReceivePokemon receivePokemon = new ReceivePokemon (ReceivePokemon.namePokemon()); // Player picks starting pokemon
			Pokemon.PokemonToCatch (Player);

		}

		//______________________________________________________________________________________


		public void Header()
		{
			Console.WriteLine ("\a_________ ( _______________ ) _________");
			Console.WriteLine ();
			Console.WriteLine ("-------------( PokeMon Sim ! )------------");
			Console.WriteLine ();
			Console.WriteLine ("___________ ( _______________ ) _________");
		}

			

		}
	}

