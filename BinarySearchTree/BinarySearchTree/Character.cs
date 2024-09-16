using System;
namespace BinarySearchTree
{
    public class Character : IComparable<Character>
    {
        public int Power { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }

        public Character(string name, int power, int speed)
        {
            Name = name;
            Power = power;
            Speed = speed;
        }

        public int CompareTo(Character other)
        {
            if (Power == other.Power)
                return Speed.CompareTo(other.Speed);
            return Power.CompareTo(other.Power);
        }

        public override string ToString()
        {
            return $"Character: {Name}, Power: {Power}, Speed: {Speed}";
        }
    }
}