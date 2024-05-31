string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] arr = orderStream.Split(',');

Array.Sort(arr);

int arrSize = arr.Length;
for (int i = 0; i < arrSize; i++)
{
   Console.Write(arr[i]);
   if (arr[i].Length != 4)
   {
      Console.Write("\t-Error");
   }
   Console.WriteLine();
}