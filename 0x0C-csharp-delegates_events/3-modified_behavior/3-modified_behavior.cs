using System;

///<summary>This class represents a Player object.</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Default constructor method.</summary>
    ///
    ///<param name="name">The name of the player</param>
    ///<param name="maxHp">Represents the health points of the player</param>
    ///
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp > 0)
            this.maxHp = maxHp;
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>Prints the current health of the player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>Handles health related events</summary>
    public delegate void CalculateHealth(float points);

    ///<summary>Prints damage taken</summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp - damage);
        }
    }

    ///<summary>Prints health points recovered</summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
            Console.WriteLine($"{name} heals 0 HP!");
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp + heal);
        }

    }

    ///<summary>Sets the new value of HP</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    ///<summary>Calculate and </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
}

enum Modifier
{
    Weak,
    Base,
    Strong
}

delegate float CalculateModifier(float baseValue, Modifier modifier);
