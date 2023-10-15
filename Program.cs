// Задача: Написать программу, которая будет складывать элементы двух матриксов если их позиции одинаковые

void PrintMatrix(int[,] matrix) { // Выводит элементы матрикса.
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SumOfMatrixes(int[,] matrix, int[,] matrix1) { // ищет сумму элементов матрикса в соответствии с позицией.
    int n = matrix.GetLength(0);
    int[,] sumMatrix = new int[n, n];
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < n; j++) {
            sumMatrix[i, j] = matrix[i, j] + matrix1[i, j];
        }
    }
    return sumMatrix;
}

int[,] PullMatrix(int[,] matrix) { // Заполняет матрикс случайными числами.
    var rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = rnd.Next(1, 15);
        }
    }
    return matrix;
}

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
int[,] matrix1 = new int[n, n];
int[,] sumMatrixes;
PullMatrix(matrix);
PullMatrix(matrix1);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
sumMatrixes = SumOfMatrixes(matrix, matrix1);
PrintMatrix(sumMatrixes);
