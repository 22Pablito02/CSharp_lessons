// Задача 10
/*
int num = Convert.ToInt32(Console.ReadLine());
Console.Write((num % 100) / 10);
*/

// Задача 13

int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 != 0){
Console.Write((num % 100) % 10);
}else{
    Console.WriteLine("Введенное число двухзначное!");   
}