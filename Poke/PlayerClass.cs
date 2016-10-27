using System;
using System.Collections.Generic;
namespace Poke
{
	
		public class Items  

	// Items
	// Add Item functionality - Increment / Decrement when used or found. LATER
	// Healing property to potions
	{
				
				
		public int PokeBalls { get; set;} = 3;

				
		public int Potions { get; set;}
				
		List <string> pokemon = new List <string>();  // List to hold caught Pokemon 0
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

		string newCharacter;

		Console.WriteLine ("Hello ! Erm... What should we call you ?");
		Console.WriteLine ();


		Console.WriteLine ("Press (1) to create a New Player Profile: ");

		Console.WriteLine ("1.)Create Character");
		newCharacter = int.Parse (Console.ReadLine ());

		switch (newCharacter)
		{

		case 1:
					
			Console.WriteLine ("Please enter your characters name: ");
			this.CharacterName = Console.ReadLine ();

				//________________________________________

			Console.WriteLine ("How old is your Character?");
			this.Age = int.Parse (Console.ReadLine ());
					
				//________________________________________
					
			Console.WriteLine ("What is your Characters gender?");
			this.Gender = Console.ReadLine ();

			break;

			
		}

			Console.WriteLine ("Press Enter to continue: ");

			Console.ReadKey ();

			Console.Clear ();

	}
	
}
