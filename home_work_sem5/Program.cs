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


// Задача 36:
/*
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
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int quantity = prompt("Введите число элементов массива: ");
double[] array = CreateArray(quantity);
PrintArr(array);
Console.WriteLine("");
double result = DifferenceMaxMin(array);
Console.WriteLine($"Разность между максимальным и минимальным элементом массива: {result}");

int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

double[] CreateArray(int size)
{
    Random rnd = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2);
    }
    return arr;
}

void PrintArr(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

double DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max){
            max = arr[i];
        }    
        else if(arr[i] < max && arr[i] < min){
            min = arr[i];
        }
    }
    Console.WriteLine($"Максимум: {max}, \nМинимум: {min}");

    double diff = max - min;
    return diff;
}