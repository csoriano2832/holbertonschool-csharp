using System;

namespace Enemies
{
    /// <summary>Represents a zombie.</summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        /// <summary>Gets or sets the name.</summary>
        public string Name 
        { 
            get => name;
            set => name = value;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie() 
        {
            health = 0;
        }
        
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }

        /// <summary>Gets the health value of the <see cref="Zombie"/> instance.</summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>Prints the string representation of a <see cref="Zombie"/> instance</summary>
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}
