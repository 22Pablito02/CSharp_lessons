// Задача 2
/* 
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2){
    Console.WriteLine(num1);
}else if(num1 == num2){
    Console.WriteLine("Числа равны");
}else{
    Console.WriteLine(num2);
}
*/

// Задача 4
/*
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2){
    max = num1;
}else{
    max = num2;
}

if (max > num3){
    Console.WriteLine("Максимальное число: " + max);
}else{
    max = num3;
    Console.WriteLine("Максимальное число: " + max);
}
*/

// Задача 6
/*
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine("Число четное!");
}else{
    Console.WriteLine("Число нечетное!");
}
*/

// Задача 8

int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
int temp = 0;
while (i <= num){
    Console.Write(i + " ");
    i = i + 2;
}