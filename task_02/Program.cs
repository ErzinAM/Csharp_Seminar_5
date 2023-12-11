// Задание 2.
var array = new int[3,3]
 {      {4, 3, 1},
        {2, 6, 9},
        {4, 6, 2}
 };     

for(int i = 0; i < array.GetLength(1); i++)
{
    var temp = array[2,i];
    array[2,i] = array[0,i];
    array[0,i] = temp;
}
for(int i = 0; i < array.GetLength(1); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
       Console.WriteLine();
}
Console.ReadKey(true);