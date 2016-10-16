using System;
using System.Collections.Generic;

namespace pokePracticeWithMeww
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ReceivePokemon receivePokemon = new ReceivePokemon (ReceivePokemon.namePokemon());

		}

		public class Player
		{
			string gender;
			public string Gender { get; set;}

			int age;
			public int Age { get; set;}

			string characterName;
			public string CharacterName { get; set;}


			//________________________________________



		public Player (int age, string characterName, string gender)

			{
				this.Age = age;
				this.CharacterName = CharacterSetUp();
				this.Gender = gender;
			}



		}

		public class Items
		{
			int pokeBalls;
			public int PokeBalls;

			int potion;
			public int Potion;

			List <string> pokemon = new List <string>();

		}






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

				catchPokemon ();



				return pokeName;




			}

			public class Pokemon							//POKEMON OBJECTS_______________________________________________________________
			{
				
				string pidgey = "Pidgey";
				string jigglyPuff = "Jiggly Puff";
				string koffing = "Koffing";
				string evee = "Evee";
				string abra = "Abra";



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



				if (userDirection % 2 == 0) {

					PokemonToCatch ();
				} 



				else {
					Console.WriteLine ("Hmm... There doesn't seem to be anything here...Lets try a different direction. ");
					catchPokemon ();
				}



			}

			public static void PokemonToCatch()
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
					Console.WriteLine ("A wild " + koffing + " appeared!");
					appearedPokemon = koffing;
					CatchOrRun (appearedPokemon);

					break;

				case 4:
					Console.WriteLine ("A wild " + evee + " appeared!");
					appearedPokemon = evee;
					CatchOrRun (appearedPokemon);

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

			//_________________________________________________________________________________________________________________



			public string CharacterSetUp ()
			{
				Console.WriteLine ("Welcome ! Erm... What should we call you ?");
				return Console.ReadLine();
			}

		}
	}
}
