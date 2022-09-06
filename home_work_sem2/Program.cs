// Задача 10
/*
int num = Convert.ToInt32(Console.ReadLine());
Console.Write((num % 100) / 10);
*/

// Задача 13
/*
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 != 0){
Console.Write((num % 100) % 10);
}else{
    Console.WriteLine("Введенное число двухзначное!");   
}
*/

// Задача 15
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

switch(num){

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
