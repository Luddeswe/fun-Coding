// See https://aka.ms/new-console-template for more information
Console.WriteLine("Välkommen till mitt spel");
Random rnd = new Random();
int randomNumber = rnd.Next(1, 101);
Console.WriteLine("Vi har slupat ett nummer mellan 1 till 100");


int guess = 0;

while (guess != randomNumber)
{
    Console.Write("Skriv ett tal här: ");
    string input = Console.ReadLine();
    guess = int.Parse(input);
    if (guess == randomNumber)
        Console.WriteLine("Ja du gissade rätt");
    else if (guess > randomNumber)
        Console.WriteLine("Du gissade högt, gissa lägre");
    else if (guess < randomNumber)
        Console.WriteLine("Du gissade för lågt, gissa igen");
}