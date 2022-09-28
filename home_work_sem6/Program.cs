// Задача 41
/*
Console.WriteLine("Введите числа через запятую: ");
string input = Console.ReadLine();
int[] numbers = ParseStringToArray(input);
Console.WriteLine($"Чисел больше нуля: {Comparison(numbers)} ");


int Comparison(int[] Numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) count += 1; 
  }
  return count;
}

int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}
int GetCountNumbersInString(string input) 
{
    int count;
    if(input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
            count++;
    }
    return count;
}
*/

// Задача 43

double b1 = prompt("введите значение b1 = ");
double k1 = prompt("введите число k1 = ");
double b2 = prompt("введите значение b2 = ");
double k2 = prompt("введите число k2 = ");

double numberX = (b2 - b1)/(k1 - k2);
double numberY = k2 * numberX + b2;

Console.WriteLine($"Точка пересечения двух прямых: [{numberX},{numberY}]");


double prompt(string massage)
{
    Console.Write(massage);
    double answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}