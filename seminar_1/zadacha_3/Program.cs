Console.WriteLine("введите число!");
int N = Convert.ToInt32(Console.ReadLine());
int current = -N;
while(current <= N)
{
        Console.Write( current + " ");
        current++;
}