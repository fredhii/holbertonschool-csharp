using System;

namespace Enemies
{
    /// <summary>Defines a zombie</summary>
    public class Zombie
    {
        /// <summary>Health field</summary>
        public int health;
        /// <summary>Constructor</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Constructor with value to update healt field</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
