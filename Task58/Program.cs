Console.Write("Введите количество строк в первой матрице: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в строке: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int [,] arr1 = new int [rows1, columns1];
Console.WriteLine("Введите элементы первой матрицы, по одному: ");

for (int i = 0; i < arr1.GetLength(0); i++){
    for (int j = 0; j < arr1.GetLength(1); j++){
        arr1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите количество строк во второй матрице: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в строке: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int [,] arr2 = new int [rows2, columns2];
Console.WriteLine("Введите элементы второй матрицы, по одному: ");

for (int i = 0; i < arr2.GetLength(0); i++){
    for (int j = 0; j < arr2.GetLength(1); j++){
        arr2[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Матрица1 = "); //Вывод 1 матрицы
for (int i = 0; i < arr1.GetLength(0); i++){
    for (int j = 0; j < arr1.GetLength(1); j++){
        Console.Write($"{arr1[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица2 = "); //Вывод 2 матрицы
for (int i = 0; i < arr2.GetLength(0); i++){
    for (int j = 0; j < arr2.GetLength(1); j++){
        Console.Write($"{arr2[i,j]} ");
    }
    Console.WriteLine();
}
if (columns1 == rows2){
    Console.WriteLine("Произведение этих матриц =");
    int [,] arr_res = new int [Math.Max(rows1,rows2), Math.Max(columns1,columns2)];
    for (int i = 0; i < arr_res.GetLength(0); i++){
        for (int j = 0; j < arr_res.GetLength(1); j++){
            for(int k = 0; k < columns1; k++){
                arr_res[i,j] += (arr1[i,k] * arr2[k,j]);
            }
            Console.Write($"{arr_res[i,j]} ");
        }
        Console.WriteLine();
    }
}
else{
    Console.WriteLine("Такие матрицы нельзя перемножать. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
}
