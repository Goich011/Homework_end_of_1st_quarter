/* Написать программу, которая из имеющегося массива строк
формирует массив строк, длинна элементов которых меньше либо равна 3 символа.*/

string[] numbers1 = new[] {"Sergey", "Sasha", "Lev", "Egor", "Yan", "Pasha", "Li"};
string[] numbers2 = new string[7];
int j = 0;

for (int i = 0; i < numbers1.Length; i++)
{
    if (numbers1[i].Length <= 3)
    {
        numbers2[j] = numbers1[i];
        j++;
    }
}
Console.WriteLine("[" + string.Join(", ", numbers1) + "]");
numbers2 = numbers2.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
Console.WriteLine("[" + string.Join(", ", numbers2) + "]");
