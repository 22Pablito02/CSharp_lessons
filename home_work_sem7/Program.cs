// Задача 47


int row = prompt("Введите количество строк массива: ");
int col = prompt("Введите количество столбцов массива: ");

double[,] array = CreateArray(row, col);
print(array);

int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

double[,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    double[,] arr = new double[rows,columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            arr[i,j] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2);
        }
    }
    return arr;
}

void print(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}