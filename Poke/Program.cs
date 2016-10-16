using System;
using Poke;
using System.Collections.Generic;

namespace pokePracticeWithMeww
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ReceivePokemon receivePokemon = new ReceivePokemon (ReceivePokemon.namePokemon ());
		}

		//______________________________________________________________________________________




			public string CharacterSetUp ()
			{
				Console.WriteLine ("Welcome ! Erm... What should we call you ?");
				return Console.ReadLine();
			}

		}
	}

