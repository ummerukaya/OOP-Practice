
using System;


interface animal
{
    void animalSound();
}

class cow : animal
{
    public void animalSound()
    {
        Console.WriteLine("hamba");
    }

    public static void Main()
    {
        cow obj = new cow();

        obj.animalSound();

    }
}