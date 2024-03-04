// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

//Простое решение:
// Console.Write("Введите строку, содержащую символы с верхним и нижним регистром: ");
// string inputStr = Console.ReadLine();
// Console.WriteLine($"Результат: {inputStr.ToLower()}");


//Решение без применения ToLower()

string ConvertStringToLower(string inputString)
{
  string lowerStr = "";

  for (int i = 0; i < inputString.Length; i++)
  {
    switch(inputString[i])
    {
      case 'A':
      lowerStr += 'a';
      break;
      case 'B':
      lowerStr += 'b';
      break;
      case 'C':
      lowerStr += 'c';
      break;
      case 'D':
      lowerStr += 'd';
      break;
      case 'E':
      lowerStr += 'e';
      break;
      case 'F':
      lowerStr += 'f';
      break;
      case 'G':
      lowerStr += 'g';
      break;
      case 'H':
      lowerStr += 'h';
      break;    
      case 'I':
      lowerStr += 'i';
      break;
      case 'J':
      lowerStr += 'j';
      break;
      case 'K':
      lowerStr += 'k';
      break;
      case 'L':
      lowerStr += 'l';
      break;
      case 'M':
      lowerStr += 'm';
      break;
      case 'N':
      lowerStr += 'n';
      break;
      case 'O':
      lowerStr += 'o';
      break;
      case 'P':
      lowerStr += 'p';
      break;
      case 'Q':
      lowerStr += 'q';
      break;
      case 'R':
      lowerStr += 'r';
      break;
      case 'S':
      lowerStr += 's';
      break;
      case 'T':
      lowerStr += 't';
      break;
      case 'U':
      lowerStr += 'u';
      break;
      case 'V':
      lowerStr += 'v';
      break;
      case 'W':
      lowerStr += 'w';
      break;
      case 'X':
      lowerStr += 'x';
      break;
      case 'Y':
      lowerStr += 'y';
      break;
      case 'Z':
      lowerStr += 'z';
      break;

      default:
        lowerStr += inputString[i];
        break;
    }
  }
  return lowerStr;
}

Console.Write("Введите строку, содержащую символы с верхним и нижним регистром: ");
string inputStr = Console.ReadLine();
Console.WriteLine($"Результат: {ConvertStringToLower(inputStr)}");