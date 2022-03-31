﻿using System;

///<summary>This class represents a Player object.</summary>
public class Player
{
    private string name { get; set; }
    private float maxHp { get; set;}
    private float hp { get; set; }

    ///<summary>Default constructor method.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
    }

    ///<summary>Prints the current health of the player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}