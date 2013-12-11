using System;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquareHomework
	{
		// How to do homework:
		// Step 1: Press the Run Button (Ctrl+F5)
		// Step 2: Read the name of the Method that Failed
		// Step 3: Fill in the blank (___) to make it pass
		// Step 4: Repeat Until Enlightment
		// Do not change anything except the blank (___)

		private static void numbersdonotneedquotes()
		{
			Homework.CheckAnswer(___, equals, 42);
		}

		private static void defaultwidthforthetortoise()
		{
			Homework.CheckAnswer(___, equals, Tortoise.GetPenWidth());
		}

		private static void stringsneedquotes()
		{
			Homework.CheckAnswer(___, equals, "Green");
		}

		private static void stringscanincludespaces()
		{
			Homework.CheckAnswer(___, equals, "This is a string");
		}

		private static void defaultcolorforthetortoise()
		{
			Homework.CheckAnswer(___, equals, Tortoise.GetPenColor());
		}

		private static void changingthepenwidthto5()
		{
			Tortoise.SetPenWidth(___);
			Homework.CheckAnswer(5, equals, Tortoise.GetPenWidth());
		}

		private static void changingthepencolortogreen()
		{
			Tortoise.SetPenColor(___);
			Homework.CheckAnswer(Tortoise.GetPenColor(), equals, "Green");
		}

		private static void movingthetortoise100pixels()
		{
			var start = Tortoise.GetY();
			Tortoise.Move(___);
			Homework.CheckAnswer(start - 100, equals, Tortoise.GetY());
		}

		private static void thetortoiseturns21()
		{
			Tortoise.Turn(___);
			Homework.CheckAnswer(21, equals, Tortoise.GetAngle());
		}

		private static void thetortoiseturns15twice()
		{
			var ans = ___;
			Tortoise.Turn(ans);
			Tortoise.Turn(ans);
			Homework.CheckAnswer(30, equals, Tortoise.GetAngle());
		}

		private static void howfastcanthetortoisego()
		{
			Tortoise.SetSpeed(___);
			Homework.CheckAnswer(topSpeed, equals, Tortoise.GetSpeed());
			//Hint: Right Click SetSpeed then select 'Go to Declaration' 
		}

		private static void assigningvariables()
		{
			Primitive numberOfToes = 10;
			Homework.CheckAnswer(___, equals, numberOfToes);
		}

		private static void combiningnumbers()
		{
			Primitive age = 3 + 4;
			Homework.CheckAnswer(___, equals, age);
		}

		private static void combiningtext()
		{
			Primitive name = "Peter" + " " + "Pan";
			Homework.CheckAnswer(___, equals, name);
		}

		private static void combiningtextandnumbers()
		{
			Primitive name = "Henry The " + 8;
			Homework.CheckAnswer(___, equals, name);
		}

		private static void combiningtextinaloop()
		{
			Primitive sound = "A";
			for (int i = 1; i <= 3; i++)
			{
				sound = sound + "H";
			}
			Homework.CheckAnswer(___, equals, sound);
		}

		private static void forloopsendattheend()
		{
			Primitive numbers = "@";
			for (int i = 1; i <= ___; i++)
			{
				numbers = numbers + i;
			}
			Homework.CheckAnswer(numbers, equals, "@12345");
		}

		private static void forloopscanstartanywhere()
		{
			Primitive answer = "Because ";
			for (int i = ___; i <= 9; i++)
			{
				answer = answer + i;
			}
			//Question: Why is 7 the most feared number ?
			Homework.CheckAnswer(answer, equals, "Because 789");
		}

		private static void forloopscanskip()
		{
			Primitive numbers = "@";
			for (int i = 1; i <= 20; i += ___)
			{
				PreventInfiniteLoop();
				numbers = numbers + i + ",";
			}
			Homework.CheckAnswer(numbers, equals, "@1,3,5,7,9,11,13,15,17,19,");
		}

		private static void forloopscangobackwards()
		{
			Primitive numbers = "Countdown: ";
			for (int i = 5; i >= 1; i += ___)
			{
				PreventInfiniteLoop();
				numbers = numbers + i;
			}
			Homework.CheckAnswer(numbers, equals, "Countdown: 54321");
		}

		#region Ignore

		public static void Main()
		{
			Homework.StartSimpleSquareHomeworkAt += numbersdonotneedquotes;
		}
		private static void PreventInfiniteLoop()
		{
			if (infiniteLoopCount++ > 4000)
			{
				throw new Exception("You have created an infinite loop.");
			}
		}

		private static readonly Primitive ___ = "Fill in the blank ___";
		private static readonly Primitive ____ = 1;

		private static readonly Primitive topSpeed = 10;
		private static readonly Primitive equals = "=";
		private static int infiniteLoopCount = 0;

		#endregion
	}
}