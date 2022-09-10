
//Задача 19

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
