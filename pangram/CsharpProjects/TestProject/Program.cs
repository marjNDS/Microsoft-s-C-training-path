string pangram = "The quick brown fox jumps over the lazy dog";

string[] arr = pangram.Split(' '); //separa a string em um vetor de strings
int arrSize = arr.Length;

for (int i = 0; i < arrSize; i++)
{
   char[] reverse = arr[i].ToCharArray(); //transforma a string em um vetor de chars
   Array.Reverse(reverse);
   arr[i] = new string(reverse);
}

pangram = String.Join(" ", arr); // junta o vetor de strings em uma só
Console.WriteLine(pangram);
