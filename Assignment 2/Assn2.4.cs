using System;

public class Car
{
	protected String name;
	protected int id;
	private double version;
	public Car(String s, int i, double ver){
		name = s;
		id = i;
		version = ver;
	}
	public void Display(){
		Console.WriteLine("Your car is " + name + " with id " + id + " of version " + version);
	}
}

public class Maruti:Car
{
	public Maruti(String s, int i,double ver):base(s,i,ver){
		
	}
}

public class Mahindra:Car
{
	public Mahindra(String s, int i, double ver):base(s,i,ver){
		
	}
}

public class Impl
{
	public static void Main()
	{
		Maruti mu = new Maruti("maruti", 10, 2.1);
		Mahindra ma = new Mahindra("mahindra", 20, 3.1);
		mu.Display();
		ma.Display();
	}
}