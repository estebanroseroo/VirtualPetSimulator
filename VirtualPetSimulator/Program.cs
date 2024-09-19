
Console.WriteLine("******* VIRTUAL PET SIMULATOR *******");
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
Console.WriteLine("Welcome, " + name + "! Let's start our adventure together!");
