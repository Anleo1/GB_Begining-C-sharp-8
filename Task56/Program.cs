Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в строке: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [rows, columns];
Console.WriteLine("Введите элементы массива, по одному: ");

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        arr[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}
int min = 1000000000;
int n_row = 0;
for (int i = 0; i < rows; i++){
    int sum = 0;
    for (int j = 0; j < columns; j++){
        sum += arr[i,j];
    }
    if (min > sum){
        n_row = i+1;
    }
    Console.WriteLine($"Сумма строки №{i+1} = {sum}");
}
Console.WriteLine($"Строка с наименьшей суммой элементов строки = {n_row}");