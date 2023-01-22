double[] FillArrayWithRandom(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] =  Convert.ToDouble(new Random().Next(0, 40))/10;
}
return array;
}
Console.Write("Введите размер массива: ");
 
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double [length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join("; ", array));

double min = array[0];
double max = array[0];
double dif = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
       max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
}
dif = max - min;

Console.WriteLine("Разница "+ dif);
