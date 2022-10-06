using System;

class Ex5
{
    static void Main()
    {
        // Вводжу рядок з іжую через пробіли
        string? temp = Console.ReadLine();


        // Створюю об'єкт з їжею
        FoodFactory foodFactory = new(temp);
        foodFactory.Filling();

        // Створюю об'єкт з настроєм
        MoodFactory moodFactory = new();
        moodFactory.Filling(foodFactory.Food);
        moodFactory.OutputMood();


        Console.ReadKey();
    }
}