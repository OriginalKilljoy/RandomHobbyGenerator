using Microsoft.VisualBasic.CompilerServices;

string[] hobby = {"Dancing", "Dungeons and Dragons", "Collecting stamps", "Painting", "Bird watching", "Playing the guitar", "Reading"};
string name = "";




Run();
void Run()
{
    Console.WriteLine("Who would like a new hobby?");
    name = Console.ReadLine();
    int randomHobby = RandomValue();
    ChooseHobby(randomHobby);
}


void ChooseHobby(int chosenHobby)
{
    if (chosenHobby == 0)
    {
        Console.WriteLine($"{name} is now a dancing queen! Make sure to stock up on some dancing shoes;)");
    }
    else if (chosenHobby == 1)
    {
        Console.WriteLine($"{name} can make their wildest dreams come true in the magical world of Dungeons and Dragons. Enjoy traveller!");

    }
    else if (chosenHobby == 2)
    {
        Console.WriteLine($"{name} can travel the world!! Through looking at their magnificent stamp collection that is.");

    }
    else if (chosenHobby == 3)
    {
        Console.WriteLine($"Van Gogh is that you? No of course not, it's {name}! Have fun painting whatever lies in that creative noggin of yours;) ");

    }
    else if (chosenHobby == 4)
    {
        Console.WriteLine($"{name} can now enjoy staring at pigeons, sparrows, crows and what have you. The bird world is your oyster.");
   
    }
    else if (chosenHobby == 5)
    {
        Console.WriteLine($"I have a feeling {name} will start playing Wonderwall any second now with their new guitar skills");
   
    }
    else
    {
        Console.WriteLine($"{name} can find a nice and cosy corner, and snuggle down with a good book.");
  
    }
    Thread.Sleep(1000);
    Run();
}

int RandomValue()
{
    var randomHobby = new Random();
    int chosenHobby = randomHobby.Next(0, hobby.Length);
    return chosenHobby;
}