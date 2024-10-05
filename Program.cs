#region
//1. 4x4 ölçülü matrixin elementlərinin cəmini tapın.
//int[,] numbers =
//{
//    {9,3,6,10},
//    {8,2,7,5},
//    {4,5,8,1},
//    {1,9,11,6 }
//};

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    int sum = 0;

//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        sum += numbers[i, j];

//    }
//    Console.WriteLine(sum);
//}
#endregion


#region
//2. Martrixin baş diaqonalındakı elementlərin cəmi
//int[,] numbers =
//{
//    { 9,3,6,10},
//    { 8,2,7,5},
//    { 4,5,8,1},
//    { 1,9,11,6 }
//};
//int basDiaqonalSum = 0;
//for (int i = 0; i < numbers.GetLength(0); i++)
//{


//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i == j)
//        { basDiaqonalSum += numbers[i, j]; }

//    }
//}
//Console.WriteLine(basDiaqonalSum);

#endregion

#region
//3. Matrixin baş diaqonal və ondan yuxarıdakı elementlərin cəmi
//int[,] numbers =
//{
//    {9,3,6,10},
//    {8,2,7,5},
//    {4,5,8,1},
//    {1,9,11,6 }
//};
//int basDiaqonalSum = 0;
//for (int i = 0; i < numbers.GetLength(0); i++)
//{


//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i <= j)
//        { basDiaqonalSum += numbers[i, j]; }

//    }
//}
//Console.WriteLine(basDiaqonalSum);
#endregion


#region
//4. Matrixin baş diaqonalından yuxarıda olan ədədlərin cəmindən aşağıda olan ədədlərin cəminin fərqi.
//int[,] numbers =
//{
//    {9,3,6,10},
//    {8,2,7,5},
//    {4,5,8,1},
//    {1,9,11,6 }
//};
//int Sum = 0;
//int ferq = 0;
//for (int i = 0; i < numbers.GetLength(0); i++)
//{


//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i < j)
//        { Sum += numbers[i, j]; }
//        if (i > j)
//        {
//            ferq += numbers[i, j];
//        }

//    }
//}
//Console.WriteLine(Sum - ferq);
#endregion