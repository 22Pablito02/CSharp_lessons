// Задача 25
/*
int num = prompt("Введите число возводимое в степень: "); 
int deg = prompt("Введите степень: ");
Console.WriteLine(raising(num, deg));

int prompt(string massage){
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine()); 
    return answer; 
}

int raising(int number, int degree){
    int result = 1;
    for(int i = 1; i <= degree; i++){
        result *=number;
    }
    return result;
}
*/

//Задача 27

int num = prompt("Введите число: ");
Console.WriteLine(sum(num));

int prompt(string massage){
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine()); 
    return answer; 
}

int sum(int number){
    int result = 0;
    while(number > 0){
        result += number % 10;
        number = number / 10; 
    }
    return result;
}