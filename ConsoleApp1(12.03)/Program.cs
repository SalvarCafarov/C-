//task1
////int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int count = 0;
//foreach (var item in arr)
//{
//    if (item % 2 == 1)
//    {
//        count++;
//    }
//};

//Console.WriteLine(count);

//task2

//int[] arr2 = { 3, 8, 2, 10, 5 };
//int min = 100;
//int min = arr2[0];
//int max = arr2[0];
//foreach (int i in arr2)
//{
//    if (i > max)
//    {
//        max = i;
//    }
//    if (i < min)
//    {
//        min = i;
//    }
//};

//sum = min + max;
//Console.WriteLine(sum);

//task3

//int[] arr2 = { 3, 8, 2, 10, 5 };
//int min = arr2[0];
//int max = arr2[0];
//int minus = 0;
//foreach (int i in arr2)
//{
//    if (i > max)
//    {
//        max = i;
//    }
//    if (i < min)
//    {
//        min = i;
//    }
//};

//minus =  max-min;
//Console.WriteLine(minus);



//task5

//int[] arr4 = { 1, 2, 3, 4, 5 };
//int even = 0;

//int odd = 0;
//foreach (var item in arr4)
//{
//    if (item % 2 == 1)
//    {
//        odd+=item;
//    }

//    else if (even % 2 == 0)
//    {
//        even+=item;
//    }
//};
//Console.WriteLine(odd);
//Console.WriteLine(even);



//task4

int[] arr9 = { 1,9, 3, 8, 5, 4 };
bool check = true;
while (check)
{
    check = false;
    Console.WriteLine("salam");
    for(int i = 0; i < arr9.Length-1; i++)
    {
    int temp = 0;
        if (arr9[i] > arr9[i + 1])
        {
            temp = arr9[i];
            arr9[i] = arr9[i + 1];
            arr9[i + 1] = temp;
            check = true;
        }
    }
}
foreach (var item in arr9)
{
    Console.WriteLine(item);
}