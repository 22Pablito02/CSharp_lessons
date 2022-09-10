
//Задача 19
/*
string number = Console.ReadLine();
int i = 0;
int j = number.Length - 1;

while (i < number.Length){
   
    if (number[i] != number[j]){
        Console.WriteLine("Введеное число не является палиндромом!");
        break;
    }else{
        Console.WriteLine("Введеное число палиндром!");
        break;
    }
    i++;
    j--;
}
*/


//Задача 21

int x1 = сoordinate("x", "A");
int y1 = сoordinate("y", "A");
int z1 = сoordinate("z", "A");
int x2 = сoordinate("x", "B");
int y2 = сoordinate("y", "B");
int z2 = сoordinate("z", "B");

int сoordinate(string сoordinat, string point)
{
    Console.Write($"Введите координату {сoordinat} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double math(double x1, double x2, double y1, double y2, double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
double length =  Math.Round (math(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка  {length}");


// Задача 23
/*
int  N = Convert.ToInt32(Console.ReadLine());
int cobe = 0;

for(int i = 1; i <= N; i++){
    
    cobe = i;
    Console.Write(Math.Pow(cobe, 3) + " ");
}
*/



