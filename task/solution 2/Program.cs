// Создаем строковый массив. переменную count для подсчета длины второго массива, и переменную symbol для замены цифры переменной для комфортного
// использования.
string[] Array = { "hello", "2", ":-)", "-2", "1234" };
Console.WriteLine(String.Join(",", Array));
int symbol = 3;
string [] Array2 = new string [3];
int countArray2 = 0;
// Цикл for для подсчета длины массива Array2.
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= symbol)
    {
         Array2[countArray2]=Array[i];
         countArray2++;
    }

}
// создание нового массива длиной count.
Console.WriteLine(String.Join(",", Array2));