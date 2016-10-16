using System;

namespace Poke
{
	
			public class ReceivePokemon
			{

				string pokeName;
				public string PokeName { get; set;}

				public ReceivePokemon(string pokeName)
				{
					this.PokeName = pokeName;
				}

				public static string namePokemon()					//NAME POKEMON METHOD
				{
					Console.WriteLine ("Select the number of the pokemon you'd like to recieve:");

					string squirtle = "Squirtle";
					string charmander = "Charmander";
					string bulbasaur = "Bulbasuar";

					string pokeName = "";

					Console.WriteLine("1.\tSquirtle");
					Console.WriteLine("2.\tCharmander");
					Console.WriteLine("3.\tBulbasaur");




					int userPokeSelection = int.Parse (Console.ReadLine ());

					Console.Clear ();

					switch (userPokeSelection) 
					{
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



					Console.WriteLine ();
					Console.WriteLine("Press enter to continue:");
					Console.WriteLine ();

					Console.ReadKey ();
					Console.Clear ();

					Console.WriteLine ();

					Console.WriteLine ("Now it's time to start your adventure and catch Pokemon!");
					Console.WriteLine ();
					Console.WriteLine ("To catch pokemon, you'll need Poke Balls. Here!");
					Console.WriteLine ("\aYou received 3 pokeballs!");
					Console.WriteLine ();

					Console.WriteLine ();
					Console.WriteLine ();
					Console.WriteLine ("You need to move around to find Pokemon.");
					Console.WriteLine ("To start moving in a direction:");

					Pokemon.catchPokemon ();



					return pokeName;




				}
		}
	}


