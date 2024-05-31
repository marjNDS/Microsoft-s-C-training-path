Console.Write("Would you like to play? ");
if (ShouldPlay())
{
   PlayGame();
}

void PlayGame()
{
   var play = true;

   while (play)
   {
      var rand = new Random();
      int target = rand.Next(1, 5);
      int roll = rand.Next(1, 6);

      Console.WriteLine($"Roll a number greater than {target} to win!");
      Console.WriteLine($"You rolled a {roll}");
      Console.WriteLine(WinOrLose(target, roll));
      Console.WriteLine("\nPlay again?");

      play = ShouldPlay();
   }
}

string WinOrLose(int target, int roll)
{
   if (roll >= target)
   {
      return "You won!";
   }
   return "You lost.";
}

bool ShouldPlay()
{
   string? readResult;
   do
   {
      Console.WriteLine("(Y/N)");
      readResult = Console.ReadLine();

      readResult?.ToLower();

   } while (readResult != "y" && readResult != "n");

   if (readResult == "y")
   {
      return true;
   }
   return false;
}

