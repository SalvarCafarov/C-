//int[] arr = { 1, 2, 3, 4, 2 };
//bool check = false;
//int numb=0 ;
//int count;
//foreach (var item in arr)
//{
//count=0;
//    foreach (var item2 in arr)
//    {
//        if (item2 == item)
//        {
//            numb = item2;
//            count++;
//        }

//    }
//   if(count ==1) {
//        Console.WriteLine(numb);
//    }
//}



//int[] arr3 = { 1, 2, 3 };
//int[] arr4 = new int[arr3.Length];
//for (int i = 0; i < arr3.Length; i++)
//{
//    arr4[i]= arr3[i];
//}

//foreach (var item in arr4)
//{
//    Console.WriteLine(item);
//}


int[] arr = { 1, 2,5,5,5, 3, 4, 2,1 };
int[] arr2 = new int[arr.Length];
bool check = false;
int numb = 0;
int count;
int counter = 0;
foreach (var item in arr)
{
    count = 0;
    foreach (var item2 in arr)
    {
        foreach (var item3 in arr2)
        {
            if (item == item3)
            {
                check = true;
            }
        }
        if (!check)
        {
            if (item2 == item)
            {

                numb = item2;
                count++;

            }
        }


    }

    if (!check)
    {
        Console.WriteLine(numb + " " + count);
    }
    arr2[counter]=item;
    counter++;
    check = false;
}

