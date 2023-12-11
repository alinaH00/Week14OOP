Dog goodBoy = new Dog("Good Boy");

Console.WriteLine($"Name:{goodBoy.Name}; Level of Happiness:{goodBoy.LevelOfHappiness}");


while (goodBoy.LevelOfHappiness < 5)
{
    goodBoy.Bark();
}
goodBoy.Wag();



Console.WriteLine($"Name:{goodBoy.Name}; Level of Happiness:{goodBoy.LevelOfHappiness}");


class Dog
{
    public string Name;
    public int LevelOfHappiness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappiness = 0;
        Console.WriteLine($"{Name} is your friend now");

    }

    public void Bark()
    {
        LevelOfHappiness++;
        Console.WriteLine("WOof-Woof");
    }

    public void Wag()
    {
       
        Console.WriteLine($"{Name} starts wagging its tail.");
    }
}