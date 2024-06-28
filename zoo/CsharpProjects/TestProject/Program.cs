using System;

int animalQt = 18;
string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

Console.WriteLine("Animal list:");
printArr(pettingZoo);

schoolVisit("School A");
schoolVisit("School B", 3);
schoolVisit("School C", 2);


void schoolVisit(string school, int groupSize = 6)
{
   randomizeAnimals();
   Console.WriteLine($"\n{school}");
   assignAnimals(groupSize);
}

void printArr(string[] arr)
{
   int len = arr.Length;
   for (int i = 0; i < len; i++)
   {
      Console.Write($"{arr[i]} ");
   }
   Console.WriteLine();
}

void randomizeAnimals()
{
   Random rand = new();
   int len = pettingZoo.Length;
   for (int i = 0; i < len; i++)
   {
      int randIdx = rand.Next(0, len);

      (pettingZoo[i], pettingZoo[randIdx]) = (pettingZoo[randIdx], pettingZoo[i]);
   }


}

void assignAnimals(int groupSize = 6)
{
   int animalGroup = animalQt / groupSize;
   int len = pettingZoo.Length;
   int arrPtr = 0;

   for (int i = 0; i < groupSize; i++)
   {
      Console.Write($"Group {i + 1}: ");
      for (int j = 0; j < animalGroup && arrPtr < len; j++)
      {
         Console.Write($"{pettingZoo[arrPtr++]} ");
      }
      Console.WriteLine();
   }
}
