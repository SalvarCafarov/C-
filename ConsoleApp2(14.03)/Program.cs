
//#region task1
//int[] yaslar = { 15, 18, 20, 24 };
//bool check = false;

//geri:
//Console.WriteLine("Yas daxil edin");
//bool checkInput = int.TryParse(Console.ReadLine(),out int inpYas);

//if (!checkInput)
//{
//    goto geri;
//}

//foreach (int yas in yaslar)
//{
//    if (yas == inpYas)
//    {
//        check = true;
//    }
//}

//if (check)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}



//#endregion



#region task2
string[] yaslar = { "Selver" , "Eli" , "Eziz" };
bool check = false;

evvel:
Console.WriteLine("Ad daxil edin");
string checkInput = Console.ReadLine();



foreach (string yas in yaslar)
{
    if (yas == checkInput)
    {
        check = true;
    }
}

if (check)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine("Bele bir telebe tapilmadi");
    goto evvel;
}



#endregion



