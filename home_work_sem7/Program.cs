// Задача 47
/*
int row = prompt("Введите количество строк массива: ");
int col = prompt("Введите количество столбцов массива: ");

int[,] array = CreateArray(row, col);
print(array);

int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] arr = new int[rows,columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            arr[i,j] = rnd.Next(1, 10) + Math.Round(rnd.Nextint(), 2);
        }
    }
    return arr;
}

void print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}
*/

// Задача 50
/*
int[,] array = CreateArray();

int row = prompt("Введите номер строки элемента: ");
int col = prompt("Введите номер элемента в строке: ");


if(row > array.GetLength(0) || col > array.GetLength(1)){
    Console.WriteLine("Такого элемента нет");
}
else{
    Console.WriteLine($"Значение заданого элемента: {array[row-1,col-1]}");
}

print(array);


int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[,] CreateArray()
{
    Random rnd = new Random();
    int[,] arr = new int[4,4];
    for (int i = 0; i < 4; i++){
        for (int j = 0; j < 4; j++){
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}


void print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}
*/


// Задача 52

int[,] array = CreateArray();
print(array);

Console.WriteLine();

double sum = 0;
double avg = 0;
   for (int i = 0; i < 4; i++){
        for (int j = 0; j < 4; j++){
            sum = sum + array[i,j];
        }
        Console.WriteLine($"Cумма {i+1} строки = {sum} \nСреднее арифметическое {i+1} строки= {avg = sum / 4}");
        avg = 0;
        sum = 0;
    }


int[,] CreateArray()
{
    Random rnd = new Random();
    int[,] arr = new int[4,4];
    for (int i = 0; i < 4; i++){
        for (int j = 0; j < 4; j++){
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}