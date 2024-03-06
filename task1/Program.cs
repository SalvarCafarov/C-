//task1
//Console.WriteLine("Enter a number:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = { 1, 2, 3, 4 };

//bool result = false;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] >= n)
//    {
//        result = true;
//        break;
//    }
//}
//Console.WriteLine(result);

//task2

//Console.WriteLine("Enter a number:");
//int num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Even digits:");
//while (num > 0)
//{
//    int digit = num % 10;
//    if (digit % 2 == 0)
//    {
//        Console.Write(digit + " ");
//    }
//    num /= 10;
//}

//int[] numbers = { 1, 2, 3, 4, 5, 6 };
//double sum = 0;
//int count = 0;
//for (int i = 0; i < numbers.Length; i += 2)
//{
//    sum += numbers[i];
//    count++;
//}
//double average = sum / count;
//Console.WriteLine("ededi orta: " + average);


//int[] array = { 1, 2, 3, 4 };
//Console.WriteLine("Reversed array:");
//for (int i = array.Length - 1; i >= 0; i--)
//{
//    Console.Write(array[i] + " ");
//}
//Console.WriteLine();
//task5
//int[] arr = { 1, 23, 543, 23 };
//foreach (int item in arr)
//{
//    int count = 0;
//    int reqem = item;
//    while (reqem > 0)
//    {
//        if (reqem % 10 > 0)
//        {
//            count++;
//        }
//       reqem=reqem / 10;
//    }
//        Console.WriteLine(count);
//}
//int[] numbers6 = { 1, 2, 3, 7, 6, 12, 5 };
//int max = numbers6[0];
//for (int i = 1; i < numbers6.Length; i++)
//{
//    if (numbers6[i] > max)
//    {
//        max = numbers6[i];
//    }
//}
//Console.WriteLine("Maximum number: " + max);



int[] numbers7 = { 1, 2, 3, 7, 6, 12, 5 };
int min = numbers7[0];
for (int i = 1; i < numbers7.Length; i++)
{
    if (numbers7[i] < min)
    {
        min = numbers7[i];
    }
}
Console.WriteLine("Minimum number: " + min);
