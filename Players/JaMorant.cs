using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Players

{
    class JaMorant
    {
        public string Position { get; set; }
        public string Skill { get; set; }
        public int Years { get; set; }
        public string Height { get; set; }

        public JaMorant(string position, string skill, int years, string height)
        {
            Position = position;
            Skill = skill;
            Years = years;
            Height = height;
            Console.WriteLine($"Ja Morant's position is {position}. His best skill is {skill}. He has been in the NBA {years} years. He is {height} tall");
        }
        public void Dribble()
        {
            Console.WriteLine("Ja handles the basketball great. He is able to get around his opponent");
        }
        public void Shoot()
        {
            Console.WriteLine("Ja shoots the basketball and is a pure scorer");
        }
        public void Pass()
        {
            Console.WriteLine("Ja has great court vision");
        }
        public void Speak()
        {
            Console.WriteLine("Ball");
        }
        public void Results()
        {
            Console.WriteLine("Ja wins");
        }
    }
}
