using System;
using System.Collections.Generic;
namespace Poke
{
	
			public class Items
		{
				
				
				public int PokeBalls { get; set;} = 3;

				
				public int Potions { get; set;}
				

	public Items ()
		{
			
		}
				

				

				List <string> pokemon = new List <string>();
		}


			
			
			public class Player
		{
				public int PokeBalls{ get; set;} = 3;
				
				public int Potions { get; set;}
				
				
				public string CharacterName { get; set;}

				
				public string Gender { get; set;}

				
				public int Age { get; set;}

				
				//________________________________________



				public Player()

				{
					Console.WriteLine ("Welcome to PokeMon Simulator!  Please enter your characters name: ");
					this.CharacterName = Console.ReadLine ();
					
				//________________________________________

					Console.WriteLine ("How old are you?");
					this.Age = int.Parse (Console.ReadLine ());
					
				//________________________________________
					
					Console.WriteLine ("What is your characters gender?");
					this.Gender = Console.ReadLine ();

					Console.Clear ();
					
			}




	}
	
}

