using System;

namespace Enemies
{
    /// <summary>Defines a zombie</summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";
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
        /// <summary>Property</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>Returns zombie health value</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
