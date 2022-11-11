// Из имеющегося массива строк сформировать массив из строк, 
//длина которых меньше или равна 3 символа

Console.Clear();

string[] arrWord = { "Ckeck", "your", "new", "knowledges", ":)", "!" };
string[] arrNew = new string[arrWord.Length];

string word = " ";
int count = 0;

for (int i = 0; i < arrWord.Length; i++)
{
    word = arrWord[i];
    if (word.Length <= 3)
    {
        arrNew[count] = word;
        count++;
    }
}
if (count == 0) Console.WriteLine("[ ]");
else
{
    string[] arrNewPrint = new string[count];
    for (int i = 0; i < arrNewPrint.Length; i++)
    {
        arrNewPrint[i] = arrNew[i];
        Console.WriteLine(arrNewPrint[i]);
    }
}
