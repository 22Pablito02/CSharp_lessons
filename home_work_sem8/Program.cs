// Задача 54
/*
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
*/

//Задача 56
/*
int[,] array = CreateArray();

print(array);
Console.WriteLine();

int sum = 0;
int RowSum = 0;
int RowNum = 0;
for(int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j < array.GetLength(1); j++){
        sum = sum + array[i,j];
    }
    if(i == 0){
        RowSum = sum;
    }

    Console.WriteLine($"№ строки = {i+1}, сумма элементов = {sum}");
    if(RowSum > sum){
        RowSum = sum;
        RowNum = i;
    }
    sum = 0;
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов = {RowNum + 1}, сумма элементов = {RowSum}");

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
*/

// Задача 58
/*
int[,] array1 = CreateArray();
int[,] array2 = CreateArray();
int[,] ArrayResult = new int[4, 4];
print(array1);
Console.WriteLine();
print(array2);
Console.WriteLine();



if (array1.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine("Нельзя перемножить матрицы! ");
    return;
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        ArrayResult[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            ArrayResult[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

print(ArrayResult);

int[,] CreateArray()
{
    Random rnd = new Random();
    int[,] arr = new int[4,4];
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/

// Задача 62


int row = prompt("Введите количесво строк = ");
int col = prompt("Введите количество столбцов = ");

int[,] array = CreateSpiralArray(row, col);
print(array);


int[,] CreateSpiralArray(int rows, int column)
{
    Random rnd = new Random();
    int[,] arr = new int[rows,column];
    
    int count = 1;
    int i = 0;
    int j = 0;

while (count <= rows * column)
{
  arr[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < column - 1)
    j++;
  else if (i < j && i + j >= rows - 1)
    i++;
  else if (i >= j && i + j > column - 1)
    j--;
  else
    i--;
}
    return arr;
}


void print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
           if(arr[i,j] / 10 <= 0 ){
            Console.Write($"{arr[i,j]}  ");
           }else{
            Console.Write($"{arr[i,j]} ");
           }
        }
        Console.WriteLine();
    }
}

int prompt(string massage)
{
    Console.Write(massage);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}