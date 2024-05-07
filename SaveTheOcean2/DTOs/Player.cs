using System;

namespace SaveTheOcean2.DTOs
{
    public class Player
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Role { get; set; }
        public bool AnimalRescued { get; set; }

        public Player(string name, int experience, string Role)
        {
            this.Name = name;
            this.Experience = experience;
            this.Role = Role;
        }

        public void AddExperience(int experience)
        {
            this.Experience += experience;
        }

        public void RemoveExperience(int experience)
        {
            this.Experience -= experience;
        }
        public override string ToString()
        {
            return $"Player: {Name} - Experience: {Experience} - Role: {Role}";
        }
    }
}
