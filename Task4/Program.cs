// (не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
//  Сформировать строку, в которой слова расположены в обратном порядке. 
//  В полученной строке слова должны быть также разделены пробелами.
using System.Text;
string ReverseString(string inputString)
{
  string result ="";
  string word = "";
  for (int i = 0; i < inputString.Length; i++)
  {
    if (inputString[i] == ' ' || i == inputString.Length - 1)
    { 
      if (i == inputString.Length - 1)
      {
        word += inputString[i];
        word += " ";
      }
      else
        { word += inputString[i]; } 
      result = word + result;
      word = "";
    }
    else
    {
      word += inputString[i];
    }
  }
  return result;
}

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
Console.Write("Введите строку: ");
string inputString = Console.ReadLine();
Console.WriteLine($"В обратном порядке: {ReverseString(inputString)}");