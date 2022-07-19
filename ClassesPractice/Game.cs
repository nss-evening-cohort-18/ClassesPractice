using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice;

internal class Game
{
    public Game(string name, string type, int numberOfPlayers)
    {
        Name = name;
        Type = type;
        NumberOfPlayers = numberOfPlayers;
    }
    
    private string lakhsdg;

    public bool InProgress { get; private set; } = false;
    public string Name { get; set; }
    public string Type { get; set; }
    public int NumberOfPlayers { get; set; }
    public void Start()
    {
        InProgress = true;
        Console.WriteLine($"It's time to play {Name}!");
    }
    public void GameOver()
    {
        InProgress = false;
        Console.WriteLine("Yikes, what a way to go out!");
    }
}
