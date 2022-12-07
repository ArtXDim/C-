// Вид 1
/*
void Method1()
{
    Console.WriteLine("Author ...... ");
}

Method1();

// Вид 2 

void Method2_1(string msg)
{
    Console.WriteLine(msg);
}

// Method2_1(msg: "Text message");

void Method2_2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2_2(msg: "Text message", 4);
Method2_2(count: 4, msg: "New text");

// Вид №3 Что то возвращает в обязателном порядке укзать тип данных 

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид №4 Метод который что то принимает, и что то возвращает

// string Method4(int count, string text)
// {
//     int i = 0; 
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// !!!!! ЦИКЛ for

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, " Cycle for.");
Console.WriteLine(res);

// !!!!! Cycle in cicle (for) (Таблица умножения)

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");    //интерполяция строк
    }
    Console.WriteLine();
}

//

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//               012
// s[3]  //r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;


    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

*/



int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 4, 2 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arrya)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);

PrintArray(array);