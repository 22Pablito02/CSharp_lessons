// Задача 10
/*
int num = Convert.ToInt32(Console.ReadLine());
Console.Write((num % 100) / 10);
*/

// Задача 13
/*
int num = Convert.ToInt32(Console.ReadLine());
SecondNum(num);
void SecondNum(int number){

    if (number / 100 != 0 && number <= 999){
    Console.Write((number % 100) / 10);
    }else{
        Console.WriteLine("Введенное число не трехзначное!");   
}
}
*/


// Задача 13

Console.WriteLine("Введите число");
string num = Convert.ToString(Console.ReadLine());

int ThirdNum = search(num);

int search(string number){
if (number.Length > 2){
    Console.WriteLine(number[2]);
    return number[2];
}else{
    Console.WriteLine("Третьей цифры нет!");
    return 1;
}
}

void print(int value){
    Console.WriteLine("Третья цифра = " + value);
}



// Задача 15
/*
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
message(num);

void message(int day){

    switch(day){

        case 1:
        Console.WriteLine("Mondey");
        break;

        case 2:
        Console.WriteLine("Tuesday");
        break;

        case 3:
        Console.WriteLine("Wednesday");
        break;

        case 4:
        Console.WriteLine("Thursday");
        break;

        case 5:
        Console.WriteLine("Friday");
        break;

        case 6:
        Console.WriteLine("Saturday");
        break;

        case 7:
        Console.WriteLine("Sunday");
        break;

        default:
        Console.WriteLine(num + " Число не входит в нужный диапазон");
        break;
    }
}
*/