int[,] sort(int[,] item){
    for(int x = 0; x < item.GetLength(0); x++){
         for (int i = 0; i + 1 < item.GetLength(1); i++){
            for (int j = 0; j + 1 < item.GetLength(1) - i; j++){
                if (item[x,j + 1] > item[x,j]) {
                    (item[x,j], item[x,j + 1])=(item[x,j + 1], item[x,j]);
                }
            }
        }
    }
    return item;
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в строке: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [rows,columns];
Console.WriteLine("Изначальный массив");
for (int i = 0; i<arr.GetLength(0); i++){
    for (int j = 0; j<arr.GetLength(1); j++){
        arr[i,j] = new Random().Next(-99,100);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}
arr = sort(arr);
Console.WriteLine("Отсортированный массив: ");
for (int i = 0; i<arr.GetLength(0); i++){
    for (int j = 0; j<arr.GetLength(1); j++){
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}