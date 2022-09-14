// Задача 34
/*
int quantity = prompt("Введите число элементов массива: ");
int[] array = CreateArray(quantity);
PrintArr(array);
Console.WriteLine("");
int result = SearchEvenNumber(array);
Console.Write($"Количество четных чисел в массиве: {result}");

int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[] CreateArray(int size){
    Random rnd = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArr(int[] arr){

    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}

int SearchEvenNumber(int[] arr){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(arr[i] % 2 == 0){
            count += 1;
        }
    }
    return count;
}
*/


// Задача 36: Найдите сумму элементов, стоящих на нечётных позициях.

int quantity = prompt("Введите число элементов массива: ");
int[] array = CreateArray(quantity);
PrintArr(array);
Console.WriteLine("");
int result = SumOdd(array);
Console.Write($"Сумма нечетных чисел в массиве: {result}");


int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[] CreateArray(int size){
    Random rnd = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

void PrintArr(int[] arr){

    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}

int SumOdd(int[] arr){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(i % 2 != 1){
            count += arr[i];
        }
    }
    return count;
}




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

