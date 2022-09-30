// Задание 64

int num = prompt("Введите число: ");
 Console.Write(ReversCounter(num));

int ReversCounter(int number)
{
    if(number == 1) return 1;
    Console.Write($"{number} ");   
    return ReversCounter(number - 1);
}



int prompt(string massege)
{
    Console.Write(massege);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}