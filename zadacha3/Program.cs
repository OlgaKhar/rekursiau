//Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.



 void OutputReverseArray(int[] myArray, int i = 0) 
{ 
    if (i == myArray.Length) 
{
    return;
}
  
OutputReverseArray(myArray, i + 1); 
Console.Write($"{myArray[i]} "); 
}

  
int[] myArray = {1, 2, 5, 0, 10, 34};

OutputReverseArray(myArray);

