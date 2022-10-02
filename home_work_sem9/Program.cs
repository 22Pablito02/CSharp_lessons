// Задание 64
/*
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
*/


// Задача 66
/*
int StarttNum = prompt("Введите число N: ") + 1;
int FinishNum = prompt("Введите число M: ");
int count = StarttNum;

Console.Write(IntervalSum(StarttNum, FinishNum, count));
int IntervalSum(int SNum, int FNum, int count)
{
    count++;
    if (StarttNum > FinishNum)
    {
        return 0;
    }
    else if (FinishNum == 0)
    {
        return 0;
    }
    else if (count == FNum) return SNum;
    return SNum + IntervalSum(SNum + 1, FNum, count);

}
    int prompt(string massege)
    {
        Console.Write(massege);
        int answer = Convert.ToInt32(Console.ReadLine());
        return answer;
    }

    */

// Задача 68

int Num_M = prompt("Введите число M: ");
int Num_N = prompt("Введите число N: ");
Console.Write(akkerman(Num_M, Num_N));

int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return akkerman(m - 1, 1);
    }
    else
    {
        return (akkerman(m - 1, akkerman(m, n - 1)));
    }
}


int prompt(string massege)
{
    Console.Write(massege);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
