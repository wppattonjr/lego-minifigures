using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Players
{
    class LukaDoncic
    {
        public string Position { get; set; }
        public string Skill { get; set; }
        public int Years { get; set; }
        public string Height { get; set; }

        public LukaDoncic(string position, string skill, int years, string height)
        {
            Position = position;
            Skill = skill;
            Years = years;
            Height = height;
            Console.WriteLine($"Luka Doncic's position is {position}. His best skill is {skill}. He has been in the NBA {years} years. He is {height} tall");
        }
        public void Dribble()
        {
            Console.WriteLine("Luka handles the basketball masterfully");
        }
        public void Shoot()
        {
            Console.WriteLine("Luka shoots the basketball like a seasoned veteran");
        }
        public void Pass()
        {
            Console.WriteLine("Luka involves his teamates masterfully");
        }
        public void Speak()
        {
            Console.WriteLine("Let's do this, Ja");
        }
        public void Results()
        {
            Console.WriteLine("Luka loses");
        }
    }
}
