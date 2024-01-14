//Вид 1 Ничего не возвращают,ничего не принимают.
void Method1()
{
    Console.WriteLine("Автор......");
}
Method1();


//Вид 2 принимают аргументы но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);//А можно вот так Method21(count: 4, msg: "Текст");

//Вид 3 Что то возвращяют но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


//Вид 4 что то принимает и что то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text ;
        i++;
    }
    return result;
}   

string res = Method4(10, "asdf");
Console.WriteLine(res);

// А можно и так сделать цикл , через for

string Method40(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text ;
    }
    return result;
}   

string res2 = Method40(10, "z");
Console.WriteLine(res);

//А тут будет цикл в цикле

for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}