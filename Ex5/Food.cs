using System;

class Food
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    void Input()
    {
        Console.WriteLine(Name, Description);
    }

    public Food (string? name, string desctiption)
    {
        Name = name;
        Description = desctiption;
    }
}
