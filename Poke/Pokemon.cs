﻿using System;

namespace Poke
{
	
	public class Pokemon	//___________________________________________POKEMON OBJECTS & STATS_________________________________________________________
			{
				

		Player player = new Player ();

		//Add to Player Class received Pokemon ?		


		//Need to Add: 10more Pokemon, Pokemon Stats: Health, Attack Dmg, Level.
		//Experience and lvl Gain.
		//Stat gain based on lvl gain.
				
			string pidgey = "Pidgey";					//Wild Pokemon
			string jigglyPuff = "Jiggly Puff";
			string koffing = "Koffing";
			string evee = "Evee";
			string abra = "Abra";



		//Took this from Receive pokemon class.
		public static string RecievePokemon ()
		{

			string pokeName;



				Console.WriteLine ("Select the number of the pokemon you'd like to recieve:");

				string squirtle = "Squirtle";
				string charmander = "Charmander";
				string bulbasaur = "Bulbasuar";

				pokeName = "";

				Console.WriteLine ("1.\tSquirtle");
				Console.WriteLine ("2.\tCharmander");
				Console.WriteLine ("3.\tBulbasaur");




				int userPokeSelection = int.Parse (Console.ReadLine ());

				Console.Clear ();

				switch (userPokeSelection) {
				case 1:

					Console.WriteLine ("You chose Squirtle! A water type pokemon.");
					pokeName = squirtle;
					break;


				case 2:

					Console.WriteLine ("You chose Charmander! A fire type pokemon.");
					pokeName = charmander;
					break;

				case 3:

					Console.WriteLine ("You chose Bulbasaur! A grass type pokemon.");
					pokeName = bulbasaur;

					break;

				}

			return pokeName;
		}
		


		public static void catchPokemon()
				{
					Console.WriteLine ();
					Console.WriteLine ("SELECT 1: Forward");
					Console.WriteLine ("SELECT 2: Backward");
					Console.WriteLine ("SELECT 3. Right");
					Console.WriteLine ("SELECT 4. Left");

					int userDirection = int.Parse (Console.ReadLine ());

					Console.Clear ();



					if (userDirection == 4) {

				Console.WriteLine ("Hmm... There doesn't seem to be anything here...Lets try a different direction. ");
				catchPokemon ();


				} 
				



			}

		public static string PokemonToCatch(Player player) //Ask mew mew to explain
			{
				
				Random random = new Random ();
				int num = random.Next (5);

				string appearedPokemon = "";

				string pidgey = "Pidgey";
				string jigglyPuff = "Jiggly Puff";
				string koffing = "Koffing";
				string evee = "Evee";
				string abra = "Abra";



				switch (num) 
				{
			case 1:
				Console.WriteLine ("A wild " + pidgey + " appeared!");
				appearedPokemon = pidgey;
				CatchOrRun(appearedPokemon);


				break;

			case 2:
				Console.WriteLine ("A wild " + jigglyPuff + " appeared!");
				appearedPokemon = jigglyPuff;
				CatchOrRun (appearedPokemon);

				break;

			case 3:
				Console.WriteLine ("What's this!? You found a Potion!" + player.CharacterName + " Received 1 Potion!");
				player.Potions += 1;
				catchPokemon ();

				break;

			case 4:
				Console.WriteLine ("Hmm.. There doesn't seem to be anything here... Lets try a different direction.");
					
				catchPokemon ();

					break;

			case 0:
				Console.WriteLine ("A wild " + abra + " appeared!");
				appearedPokemon = abra;
				CatchOrRun (appearedPokemon);

				break;

				}
				return appearedPokemon;


			}

			public static void CatchOrRun(string name)
			{
				Console.WriteLine ("Would you like to catch this pokemon? Or run away?");
				Console.WriteLine ();
				Console.WriteLine ("SELECT:");
				Console.WriteLine ("1: CATCH");
				Console.WriteLine ("2: RUN");

				int catchRunResponse = int.Parse(Console.ReadLine());
				Console.Clear ();


				if (catchRunResponse == 1) {
					Console.WriteLine ("You threw a Poke Ball at " + name + ". " + name + " was caught!");
				} else {
					catchPokemon ();
				}
			}
		}
	}


