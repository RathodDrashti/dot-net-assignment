using System;

public class C2
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter value");
		int num = int.Parse(Console.ReadLine());
		for(int i = 1; i < num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            Console.Write("\n");
            }
	}
}