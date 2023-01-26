string [] firstArray = new string[7] {"7", "hello", "world", "749", "(?)", "res", "1"};
string [] secondArray = new string[firstArray.Length];

void ThreeCharArray(string[] firstArray, string[] secondArray) //Метод сортировки строк из 3-х символов и менее
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}

    void Print1DArr (string[] array)       //Метод вывода массива на печать
    {
        for (int i=0; i<array.Length-1; i++)
        {
            Console.Write(array[i] + "   ");
        }
        Console.WriteLine(array[array.Length-1]);
    }

ThreeCharArray(firstArray, secondArray);
Print1DArr(secondArray);

