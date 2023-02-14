// Создаем строковый массив. переменную count для подсчета длины второго массива, и переменную symbol для замены цифры переменной для комфортного
// использования.
string[] Array = { "hello", "2", ":-)", "-2", "1234" };
Console.WriteLine(String.Join(",", Array));
int count = 0;
int symbol = 3;
// Цикл for для подсчета длины массива Array2.
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= symbol)
    {
        count++;
    }

}
// создание нового массива длиной count.
string [] Array2 = new string [count];
int countArray2 = 0;
// for цикл для заполнения нового массива значениями длиной до 3 символов.
for(int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= symbol)
    {
        Array2[countArray2]=Array[i];
         countArray2++;
    }
}
Console.WriteLine(count);
Console.WriteLine(String.Join(",", Array2));
