using System;
using Poke;
using System.Collections.Generic;

namespace pokePracticeWithMeww
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Header (); 						//	Opening game header
			Player player = new Player (); 	//	New player instantiation: Runs Character set up : Holds Character stats.
			ReceivePokemon receivePokemon = new ReceivePokemon (ReceivePokemon.namePokemon ()); // Player picks starting pokemon
			Pokemon.PokemonToCatch (Player);




		}

		//______________________________________________________________________________________


		public void Header()
		{
			Console.WriteLine ("\a_________ ( __________________ ) _________");
			Console.WriteLine ();
			Console.WriteLine ("---------( Welcome to PokeMon Sim ! )--------");
			Console.WriteLine ();
			Console.WriteLine ("_________ ( __________________ ) _________");
		}

			

		}
	}

