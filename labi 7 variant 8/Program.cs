////laba 7.1
//static string Separate(string S)
//{
//    char S1, S2;
//    string glas = "";
//    string soglas = "";
//    int count = 0;
//    int count2 = 0;
//    char[] S3 = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
//    for (int i = 0; i < S.Length; i++)
//    {
//        if (S3.Contains(S[i]))
//        {
//            S1 = S[i];
//            glas += S1;
//            count++;
//        }
//        else
//        {
//            S2 = S[i];
//            soglas += S2;
//            count2++;
//        }
//    }
//    Console.WriteLine("Сначала гласные, потом согласные буквы в предложении: ");
//    string bukvi = glas + " " + soglas;
//    Console.WriteLine("Количество гласных: " + count + "Количество согласных: " + count2);
//    return bukvi;
//}

//Console.WriteLine("Введите предложение на английском: ");
//string S = Console.ReadLine();
//Console.WriteLine(Separate(S));

////laba 7.2
//static int AddRightDigit(int K, int D1, int D2)
//{
//    string DD = Convert.ToString(D1);
//    K = int.Parse(K.ToString() + DD);
//    string DD2 = Convert.ToString(D2);
//    K = int.Parse(DD2 + K.ToString());
//    return K;
//}

//Console.WriteLine("Введите число K: ");
//int K = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите цифру, которая добавится первой справа от числа K: ");
//int D1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите цифру, которая добавится второй справа от числа K: ");
//int D2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Итог: " + AddRightDigit(K, D1, D2));

////laba 7.3
//static int Quarter(int x, int y)
//{
//    int result = 0;
//    if (x > 0 && y > 0)
//    {
//        result = 1;
//    }
//    else if (x < 0 && y > 0)
//    {
//        result = 2;
//    }
//    else if (x < 0 && y < 0)
//    {
//        result = 3;
//    }
//    else if (x > 0 && y < 0)
//    {
//        result = 4;
//    }
//    return result;
//}

//Console.WriteLine("Введите координаты x и y: ");
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine("Координаты точки находятся в четверти под номером " + Quarter(x, y));

////laba 7.4
//static void RemoveX(int N1, int N2, int N3, int X)
//{
//    int[] A = new int[N1];
//    int[] B = new int[N2];
//    int[] C = new int[N3];
//    Random rnd = new Random();
//    List<int> arrayList1 = new List<int>();
//    List<int> arrayList2 = new List<int>();
//    List<int> arrayList3 = new List<int>();
//    Console.WriteLine("Исходный массив A: ");
//    for (int i = 0; i < A.Length; i++)
//    {
//        A[i] = rnd.Next(1, 5);
//        Console.Write(A[i] + " ");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Исходный массив B: ");
//    for (int i = 0; i < B.Length; i++)
//    {
//        B[i] = rnd.Next(1, 5);
//        Console.Write(B[i] + " ");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Исходный массив C: ");
//    for (int i = 0; i < C.Length; i++)
//    {
//        C[i] = rnd.Next(1, 5);
//        Console.Write(C[i] + " ");
//    }
//    for (int i = 0; i < A.Length; i++)
//    {
//        if (A[i] != X)
//        {
//            arrayList1.Add(A[i]);
//        }
//    }
//    for (int i = 0; i < B.Length; i++)
//    {
//        if (B[i] != X)
//        {
//            arrayList2.Add(B[i]);
//        }
//    }
//    for (int i = 0; i < C.Length; i++)
//    {
//        if (C[i] != X)
//        {
//            arrayList3.Add(C[i]);
//        }
//    }
//    int[] A1 = arrayList1.ToArray();
//    int[] B2 = arrayList2.ToArray();
//    int[] C3 = arrayList3.ToArray();
//    Console.WriteLine();
//    Console.WriteLine("Полученный массив A:");
//    foreach (int i in A1)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Полученный массив B:");
//    foreach (int i in B2)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Полученный массив C:");
//    foreach (int i in C3)
//    {
//        Console.Write(i + " ");
//    }
//}
//Console.WriteLine("Введите размерность массива A: ");
//int N1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите размерность массива B: ");
//int N2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите размерность массива C: ");
//int N3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число X, которое нужно удалить из всех массивов: ");
//int X = int.Parse(Console.ReadLine());
//RemoveX(N1, N2, N3, X);

//laba 7.5 Описать рекурсивную функцию RootK(X, K, N) вещественного типа, находящую приближенное значение корня K-й степени из числа X по формуле: Y0 = 1, YN + 1 = YN – (YN – X / (YN) K–1)/ K
//,где YN обозначает RootK(X, K, N) при фиксированных X и K. Параметры
//функции: X(> 0) — вещественное число, K (> 1) и N (> 0) — целые.С помощью функции RootK найти для данного числа X приближенные значения его корня K-й степени при шести данных значениях N.

static double RootK(double X, int K, int N)
{
    if (N == 0)
    {
        return 1;
    }
    return RootK(X, K, N - 1) - (RootK(X, K, N - 1) - X / Math.Pow(RootK(X, K, N - 1), K - 1)) / K;
}
int X = int.Parse(Console.ReadLine());
int K = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
Console.WriteLine(RootK(X, K, N));


//static void CirclesS(double R, double T, double Y)
//{
//    double P = 3.14;
//    double S = P * Math.Pow(R, 2);
//    double S1 = P*Math.Pow(T, 2);
//    double S2 = P * Math.Pow(Y, 2);
//    Console.WriteLine("площадь круга " + S);
//    Console.WriteLine("площадь круга " + S1);
//    Console.WriteLine("площадь круга " + S2);
//}

//Console.WriteLine("введите периметр");
//int R = int.Parse(Console.ReadLine());
//int T = int.Parse(Console.ReadLine());
//int Y = int.Parse(Console.ReadLine());
//Console.WriteLine();
//CirclesS(R, T, Y);

//static void Nminmax(int N)
//{
//    int[] array = new int[N];
//    int min = 99999;
//    int max = 0;
//    int count = 0;
//    int count2 = 0; 
//    for (int i = 0; i < N; i++)
//    {
//       array[i]= new Random().Next(11);

//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//    for (int i = 0; i < N; i++)
//    {
//        if (array[i] > max)
//        {
//            max = array[i];
//            count = i;
//        }
//        if ( array[i] < min)
//        {
//            min = array[i];
//            count2 = i;

//        }
//    }
//    Console.WriteLine(count2 + "минимальный" + min);
//    Console.WriteLine(count + "максимальный" + max);
//}

//Console.WriteLine("введите размерность массива 1: ");
//int N = Convert.ToInt32(Console.ReadLine());
//Nminmax(N);
//Console.ReadKey();
//Console.Clear();
//Console.WriteLine("введите размерность массива2 : ");
//N = Convert.ToInt32(Console.ReadLine());
//Nminmax(N);
//Console.ReadKey();
//Console.Clear();
//Console.WriteLine("введите размерность массив3 : ");
//N = Convert.ToInt32(Console.ReadLine());
//Nminmax(N);
