
Console.Write("Введите элементы (через пробел): ");
string num = Console.ReadLine();
var array = num.Split().Select(Int32.Parse).ToArray();
int[] new_num = array;


void Pologitelnie (int[] array)

{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;

}
Console.WriteLine($"Кодичуство чисел > 0: {count}");
}
Pologitelnie(new_num);
