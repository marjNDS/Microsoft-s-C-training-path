string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

bool workflowStatus = Workflow1(userEnteredValues);

if (workflowStatus)
{
   Console.WriteLine("Workflow1 finished flawleslly");
}
else
{
   Console.WriteLine("There was an error during Workflow1");
}

static bool Workflow1(string[][] userEnteredValues)
{
   bool status = true;
   foreach (string[] userEntries in userEnteredValues)
   {
      try
      {
         Process1(userEntries);
         Console.WriteLine("Process 1 completed.");
      }
      catch (FormatException ex)
      {
         status = false;
         Console.WriteLine($"Error: {ex.Message}");
         Console.WriteLine("Aborting Operation");
      }
      catch (DivideByZeroException ex)
      {
         status = false;
         Console.WriteLine($"Error: {ex.Message}");
         Console.WriteLine("Aborting Operation");
      }
   }

   return status;


}

static bool Process1(String[] userEntries)
{

   int valueEntered;

   foreach (string userValue in userEntries)
   {
      bool integerFormat = int.TryParse(userValue, out valueEntered);

      if (integerFormat == false) throw new FormatException("Argument can't be non-number.");
      if (valueEntered == 0) throw new DivideByZeroException("Argument can't be zero.");


      checked
      {
         int calculatedValue = 4 / valueEntered;
      }

   }

   return true;
}