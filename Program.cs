string[] array = {"hello","2","world",":-)"};
int a;
string[] line = new string[array.Length];
int b = 0;
for(a = 0; a < array.Length; a++)
{
    if(array[a].Length <= 3)
    {
        line[b] = array[a];
        b += 1;
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < b; i++)
    {
        if(i < b - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

PrintArray(line);