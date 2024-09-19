
Console.WriteLine("******* VIRTUAL PET SIMULATOR *******");
Console.WriteLine("\n");
string[] pets = { "Dog", "Cat", "Fish", "Bird", "Hamster" };
int noType = 0;
string type = "";
string name = "";
Console.WriteLine("Please choose a type of pet:");
Console.WriteLine("1. Dog");
Console.WriteLine("2. Cat");
Console.WriteLine("3. Fish");
Console.WriteLine("4. Bird");
Console.WriteLine("5. Hamster");
Console.WriteLine("\n");
while (true)
{
    Console.WriteLine("Please insert the number of your chosen pet:");
    if (int.TryParse(Console.ReadLine(), out noType) && noType >= 1 && noType <= pets.Length)
    {
        type = pets[noType - 1];
        break;
    }
    else
    {
        Console.WriteLine("The number must be between 1 and 5.");
    }
}
Console.WriteLine("\n");
Console.WriteLine("Congratulations! You've chosen a " + type + ". What would you like to name your pet?");
while (true)
{
    Console.WriteLine("Please insert the name of your " + type + ":");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && name.All(char.IsLetter))
    {
        break;
    } 
    else
    {
        Console.WriteLine("The name must contain letters only.");
    }
}
Console.WriteLine("\n");
Console.WriteLine("Welcome, " + name + "! Let's start our adventure together!");
Console.WriteLine("\n");
int action = 0;
int happiness = 5;
int health = 5;
int hunger = 5;
Console.WriteLine("*** MAIN MENU ***");
Console.WriteLine("1. Feed " + name);
Console.WriteLine("2. Play with " + name);
Console.WriteLine("3. Let " + name + " Rest");
Console.WriteLine("4. Check " + name + " Status");
Console.WriteLine("5. Exit");
Console.WriteLine("\n");
while (true)
{
    Console.WriteLine("Please insert the number of your chosen action:");
    if (int.TryParse(Console.ReadLine(), out action) && action >= 1 && action <= 5)
    {
        break;
    }
    else
    {
        Console.WriteLine("The number must be between 1 and 5.");
    }
}
switch (action)
{
    case 1:
        Console.WriteLine("\n");
        Console.WriteLine("You fed " + name + ". Its hunger decreases, and health improves slightly.");
        hunger -= 2;
        health += 1;
        break;
    case 2:
        Console.WriteLine("\n");
        Console.WriteLine("You played with " + name + ". Its happiness increases, but is a bit hungrier.");
        happiness += 2;
        hunger += 1;
        break;
    case 3:
        Console.WriteLine("\n");
        Console.WriteLine(name + " is resting. Its health improves, and happiness decreases slightly.");
        health += 3;
        happiness -= 1;
        break;
    case 4:
        happiness = happiness < 1 ? 1 : happiness > 10 ? 10 : happiness;
        health = health < 1 ? 1 : health > 10 ? 10 : health;
        hunger = hunger < 1 ? 1 : hunger > 10 ? 10 : hunger;
        Console.WriteLine("\n");
        Console.WriteLine(name + "'s Status:");
        Console.WriteLine("Happiness: " + happiness);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Hunger: " + hunger);
        break;
    case 5:
        Console.WriteLine("\n");
        Console.WriteLine("Thank you for using the application. Have a good one!");
        Environment.Exit(0);
        break;
    default:
        break;
}
