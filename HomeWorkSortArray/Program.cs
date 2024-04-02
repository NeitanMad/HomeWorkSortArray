namespace HomeWorkSortArray
{
    public class Program
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Дан двумерный массив:");

            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            PrintArray(a);

            Console.WriteLine("Получим из него олномерный массив:");

            int[] b = new int[a.GetLength(0) * a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i * a.GetLength(1) + j] = a[i, j];
                }
            }

            PrintArray(b);

            Console.WriteLine("Отсортируем..");
            Array.Sort(b);
            PrintArray(b);

            Console.WriteLine("Запишем его в двумерный массив:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = b[i * a.GetLength(1) + j];
                }
            }

            PrintArray(a);
        }
    }
}
