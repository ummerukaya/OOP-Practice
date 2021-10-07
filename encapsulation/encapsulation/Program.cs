using System;

class SwordDamage
{
    public const int BASE_DAMAGE = 3;
    public const int FLAME_DAMAGE = 2;
    public int Roll;
    private decimal MagicMultiplier = 1M;
    private int FlamingDamage = 0;
    public int Damage;
    private void CalculateDamage()
    {
        Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
        Console.WriteLine(Damage);
    }
    public void SetMagic(bool isMagic)
    {
        if (isMagic)
        {
            MagicMultiplier = 1.75M;
        }
        else
        {
            MagicMultiplier = 1M;
        }
        CalculateDamage();
    }
    public void SetFlaming(bool isFlaming)
    {
        CalculateDamage();
        if (isFlaming)
        {
            Damage += FLAME_DAMAGE;
        }
    }

}

class main
{ 
    public static void Main(string[] args)
    {
        SwordDamage obj = new SwordDamage();
        obj.SetMagic(true);
        obj.SetFlaming(true);
    }
}


