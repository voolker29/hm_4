using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Выберите размер первой матрицы.");
var fistMatrixSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите размер второй матрицы.");
var secondMatrixSize = Convert.ToInt32(Console.ReadLine());

int [,]matrixArray = new int[fistMatrixSize,secondMatrixSize];


for (int i = 0; i < fistMatrixSize; i++)
{
    for (int j = 0; j < secondMatrixSize; j++)
    {
        Console.WriteLine("Введите значение элемента (Число)");
        matrixArray[i,j] = Convert.ToInt32(Console.ReadLine());
    }
   
}
Console.WriteLine(new string('-', 100));
for(int i = 0; i < fistMatrixSize; i++)
{
    for (int j = 0; j < secondMatrixSize; j++)
    {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write($"{matrixArray[i, j]} ");
    }
    Console.ResetColor();
    Console.WriteLine();
}

Console.WriteLine(new string('-', 100));




while (true)
{
    Console.WriteLine("Выбирете действие");
    Console.WriteLine("1. Найти количество положительных/отрицательных чисел в матрице");
    Console.WriteLine("2. Сортировка элементов матрицы построчно");
    Console.WriteLine("3. Инверсия элементов матрицы построчно");
    Console.WriteLine("4. Выйти");
    var exite = false;
    switch (Console.ReadLine()) 
    {
        case "1":
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("1.Найти количество положительных");
            Console.WriteLine("2.Найти количество отрицательных");
            Console.WriteLine("3.Назад");
            switch (Console.ReadLine())
            {
                case "1":
                    var count = 0;
                    for (int i = 0; i < fistMatrixSize; i++)
                    {
                        for (int j = 0; j < secondMatrixSize; j++)
                        {
                            if (matrixArray[i,j] >= 0)
                            { 
                             count++;
                            }


                        }
                    }
                    Console.WriteLine($"Количество положительных {count}");
                    Console.WriteLine(new string('-', 100));
                    break;
                case "2":
                    count = 0;
                    for (int i = 0; i < fistMatrixSize; i++)
                    {
                        for (int j = 0; j < secondMatrixSize; j++)
                        {
                            if (matrixArray[i, j] < 0)
                            {
                                count++;
                            }


                        }
                    }
                    Console.WriteLine($"Количество отрицательных {count}");
                    Console.WriteLine(new string('-', 100));
                    break;
                default:
                    break;
            }
            break;

        case "2":
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("1.Отсортировать строки по убыванию");
            Console.WriteLine("2.Отсортировать строки по возрастанию");
            Console.WriteLine("3.Назад");
            switch (Console.ReadLine())
            {
                case "1":
                    var sort = 0;
                    for (int i = 0; i < fistMatrixSize; i++)
                    {
                        for (int j = 0; j < secondMatrixSize; j++)
                        {
                            for (int k = j + 1; k < secondMatrixSize; k++)
                            {
                                int tmp = 0;
                                if (matrixArray[i, j] < matrixArray[i, k])
                                {
                                    tmp = matrixArray[i, j];
                                    matrixArray[i, j] = matrixArray[i, k];
                                    matrixArray[i, k] = tmp;
                                }
                            }
                        }
                    }
                    Console.WriteLine("Массив отсортирован");
                    for (int i = 0; i < fistMatrixSize; i++)
                    {
                        for (int j = 0; j < secondMatrixSize; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{matrixArray[i, j]} ");
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    Console.WriteLine(new string('-', 100));
                    break;
                case "2":
                    var sortedArray = new int[1];
            
                    for (int i = 0; i < fistMatrixSize; i++)
                    {
                        for (int j = 0; j < secondMatrixSize; j++)
                        {
                            for (int k = j + 1; k < secondMatrixSize; k++)
                            {
                                int tmp = 0;
                                if (matrixArray[i,j] > matrixArray[i,k])
                                {
                                    tmp = matrixArray[i,j];
                                    matrixArray[i,j] = matrixArray[i,k];
                                    matrixArray[i,k] = tmp;
                                }
                            }
                        }
                        }
                    Console.WriteLine("Массив отсортирован");
                    for (int i = 0; i < fistMatrixSize; i++)
                    {
                        for (int j = 0; j <secondMatrixSize; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{matrixArray[i, j]} ");
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    Console.WriteLine(new string('-', 100));
                    break;
                default:
                    break;
            }
            break;     
        case "3":
            for (int i = 0; i < fistMatrixSize; i++)
            {

                var var_array = new int[secondMatrixSize];
                var count = 0;
                for (int j = secondMatrixSize-1; j>=0; j--)
                {
                    var_array[count] = matrixArray[i, j];
                    count++; 
                }
                for (int l = 0; l < secondMatrixSize; l++)
                {
                    matrixArray[i,l] = var_array[l];

                }
            }
            Console.WriteLine("Инверсия выполнена");
            for (int i = 0; i < fistMatrixSize; i++)
            {
                for (int j = 0; j < secondMatrixSize; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{matrixArray[i, j]} ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 100));
            break;

        case "4":
            exite = true;
            break;

        default:
            Console.WriteLine("Действие не распознано");
            break;


    }
    if (exite)
    {
        break;
    }


}