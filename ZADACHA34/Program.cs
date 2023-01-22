int[] FillArrayWithRandom(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 999);
}
return array;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0)
{
    count = count +1;
}
}

if(count > 0)
{
    Console.WriteLine("Количество четных цифр:" + count);
}
else
{
    Console.Write("Четных чисел нет");  
}
