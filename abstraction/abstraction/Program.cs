using System;

public abstract class animal
{
    public abstract void animalSound();
}

public class cow : animal
{
    public override void animalSound()
    {
        Console.WriteLine("hamba");
    }
}

public class cat : animal
{
    public override void animalSound()
    {
        Console.WriteLine("meow");
    }
}

public class main_method
{
    public static void Main()
    {
        animal obj;

        obj = new cow();
        obj.animalSound();

        obj = new cat();
        obj.animalSound();

    }
}


