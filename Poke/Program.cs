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
			Header (); //	Opening game header

			Player player = new Player (); 	//	New player instantiation: Runs Character set up : Holds Character stats.

			Pokemon.PokemonToCatch (player);

		}

		//______________________________________________________________________________________


		public static void Header()
		{
			Console.WriteLine ("\a_________ ( _______________ ) _________");
			Console.WriteLine ();
			Console.WriteLine ("-------------( PokeMon Sim ! )------------");
			Console.WriteLine ();
			Console.WriteLine ("___________ ( _______________ ) _________");
		}



		public static void GameMenu(Player player) // MENU
		{
			


			Console.WriteLine ("1.)  Create Character");
			Console.WriteLine ("2.)  New Game");
			Console.WriteLine ("3.)  Stats");

			switch (int.Parse(Console.ReadLine()))
			{

			case 1:
				NewPlayer (player);
				break;


			}

		}

		public static void NewPlayer(Player player)
		{
			Console.WriteLine ("Hello ! Erm... What should we call you ?");
			Console.WriteLine ();

			Console.WriteLine ("Please enter your characters name: ");
			player.CharacterName = Console.ReadLine ();

			//________________________________________

			Console.WriteLine ("How old is your Character?");
			player.Age = int.Parse (Console.ReadLine ());

			//________________________________________

			Console.WriteLine ("What is your Characters gender?");
			player.Gender = Console.ReadLine ();

		}

			

		}
	}

