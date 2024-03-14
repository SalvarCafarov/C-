flag:
bool eded = long.TryParse( Console.ReadLine(),out long count);


long temp = 0;
long temp2 = 1;
long num = 0;

if (!eded)
{
    goto flag;
}

for (int i = 0; i < count; i++)
{


   
        Console.WriteLine(num);
    
    num += temp2;
    temp2 = temp;
    temp = num;



    
}

