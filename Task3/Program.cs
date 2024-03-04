// Задайте произвольную строку. Выясните, является ли она палиндромом.
using System.Text;

bool CheckPalindrom(string stringToCheck)
{
  bool result = new bool();
  string lowerString = stringToCheck.ToLower();
  for (int i = 0; i < lowerString.Length / 2; i++)
  {
    if (lowerString[i] != lowerString[lowerString.Length - 1 - i])
    {
      result = false;
      break;
    }
    else
    { result = true; }
  }
  return result;
}

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Write("Введите строку: ");
string inputString = Console.ReadLine();
if (CheckPalindrom(inputString))
  Console.WriteLine($"Строка {inputString} - палиндром.");
else
  Console.WriteLine($"Строка {inputString} - не палиндром.");