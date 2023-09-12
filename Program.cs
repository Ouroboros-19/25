class Program
{
    static void Main()
    {
        int e, kolvoUnical = 0, kolvoPovtorov = 0, pointEnter = 0, pointExit = 0, point = 0;
        Random rand = new Random();
        int[] array1 = new int[9];
        int[,] array2 = new int[15, 3];
        Console.Write("Индексы: ");
        for (int i = 0; i < array1.Length; i++)
            Console.Write("{0,3}", i);
        Console.WriteLine();
        Console.Write("Массив:  ");
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = rand.Next(-5, 6);
            Console.Write("{0,3}", array1[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < array1.Length; i++)
        {
            e = array1[i];
            kolvoPovtorov = 0;
            for (int j = 0; j < i; j++)
            {
                if (array1[j] == e)
                    kolvoPovtorov++;
            }
            if (kolvoPovtorov == 0)
            {
                array2[kolvoUnical, 0] = e;
                kolvoUnical++;
            }
        }
        int kk = 0;
        for (int i = 0; i < kolvoUnical; i++)
        {
            kolvoPovtorov = 0;
            e = array2[i, 0];
            for (int j = 0; j < array1.Length; j++)
            {
                if (array1[j] == e)
                    kolvoPovtorov++;
            }
            array2[kk, 1] = kolvoPovtorov;
            kk++;
        }

        for (int i = 0; i < kolvoUnical; i++)
        {
            point = 0;
            for (int j = 0; j < array1.Length; j++)
            {
                if (array2[i, 0] == array1[j])
                {
                    if (point == 0)
                    {
                        pointEnter = j;
                        point++;
                    }
                    pointExit = j;
                }
            }
            if (array2[i, 0] < 0)
                array2[i, 2] = pointEnter;
            else
                array2[i, 2] = pointExit;
        }


        for (int i = 0; i < kolvoUnical; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0,3}", array2[i, j]);

            }
            Console.WriteLine();
        }
        Console.WriteLine("");
        Console.WriteLine("Повтор?(ДА - клавиша enter / НЕТ - 0)");
        string strokaDlaPovtora;
        strokaDlaPovtora = Convert.ToString(Console.ReadLine());
        if (strokaDlaPovtora == "")
            Main();
    }
}