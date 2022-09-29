// Задача 54


int[,] array = CreateArray();
print(array);
array = SortToLower(array);
Console.WriteLine();
print(array);


int[,] CreateArray()
{
    Random rnd = new Random();
    int[,] arr = new int[5,4];
    for (int i = 0; i < 5; i++){
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



int[,] SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}