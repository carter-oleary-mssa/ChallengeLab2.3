Console.Write("Enter a number: ");
string display = Console.ReadLine();
Console.Write("Enter the desired width: ");
int width = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < width; i++)
{
    for(int j = 0; j < width-i; j++)
    {
        Console.Write(display);
    }
    Console.WriteLine();
}