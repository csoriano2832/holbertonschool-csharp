using System;

namespace Enemies
{
    /// <summary>Represents a zombie.</summary>
    public class Zombie
    {
        private int health;

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

        /// <summary>Gets the health of the <see cref="Zombie"/> instance.</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
