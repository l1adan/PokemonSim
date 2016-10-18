using System;

namespace Poke
{
	
	public class Pokemon							//POKEMON OBJECTS_______________________________________________________________
			{
		
				string pidgey = "Pidgey";
				string jigglyPuff = "Jiggly Puff";
				string koffing = "Koffing";
				string evee = "Evee";
				string abra = "Abra";



	

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

				//Pokemon.PokemonToCatch ();
				} 



				else {
					Console.WriteLine ("Hmm... There doesn't seem to be anything here...Lets try a different direction. ");
					catchPokemon ();
				}



			}

		public static void PokemonToCatch(Player player)
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
					CatchOrRun (appearedPokemon);


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
					
				catchPokemon()

					break;

				case 0:
					Console.WriteLine ("A wild " + abra + " appeared!");
					appearedPokemon = abra;
					CatchOrRun (appearedPokemon);

					break;

					//return appearedPokemon;
				}


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


