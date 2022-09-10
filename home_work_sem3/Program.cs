
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


// Задача 23

int  N = Convert.ToInt32(Console.ReadLine());
int cobe = 0;

for(int i = 1; i <= N; i++){
    
    cobe = i;
    Console.Write(Math.Pow(cobe, 3) + " ");
}




