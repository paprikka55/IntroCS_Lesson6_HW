// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// 
// Программа генератор паролей :-)

int[] InputSizes()
{
  int[] sizes = new int[2];
  bool exit = true;
  while(true)
  {
    Console.Write("Введите количество паролей: ");
    try
      { sizes[0] = Convert.ToInt32(Console.ReadLine()); }
    catch
    { 
      Console.WriteLine("Неверный формат данных! Необходимо ввести число.");
      exit = false; 
    }
    if (exit == true)
      break;
  }
  exit = true;
  while(true)
  {
    Console.Write("Введите длинну паролей: ");
    try
      { sizes[1] = Convert.ToInt32(Console.ReadLine()); }
    catch
    { 
      Console.WriteLine("Неверный формат данных! Необходимо ввести число.");
      exit = false; 
    }
    if (exit == true)
      break;
  }
  return sizes;
}

char[,] CreateCharArray(int rowCount, int colCount)
{
  char[,] charArray = new char[rowCount, colCount];
  Random rnd = new Random();
  for (int i = 0; i < charArray.GetLength(0); i++)
  {
    for (int j = 0; j < charArray.GetLength(1); j++)
    {
      charArray[i,j] = GetRandomChar();
    }
  }
  return charArray;
}

char GetRandomChar()
{
  string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
  Random rnd = new Random();
  int num = rnd.Next(0, chars.Length);
  return chars[num];
}



string ConvertCharArrayToString(char[,] arr)
{
  string result = "";
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      result += Convert.ToString(arr[i,j]);
    }
  result +="\n";
  }
  return result;
}

int[] sizes = InputSizes();
char[,] charArray = CreateCharArray(sizes[0], sizes[1]);
Console.WriteLine(ConvertCharArrayToString(charArray));
