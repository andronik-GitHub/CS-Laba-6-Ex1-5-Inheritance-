using System;

class FoodFactory : Person
{
    public override string? Importance 
    {
        get => Importance;
        set
        {
            if (value?.Length > 1000)
                Console.WriteLine("The number of characters must be no more than 1000");

            Importance = value;
        }
    }

    public override void Filling()
    {
        Importance = Console.ReadLine();
    }


    public FoodFactory() { }
}