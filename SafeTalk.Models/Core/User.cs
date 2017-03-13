using System;
using System.Collections.Generic;

namespace SafeTalk.Models
{
    public class User
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public List<string> IgnoreGuids { get; set; }

        public User()
        {
            Guid = System.Guid.NewGuid().ToString();
            Name = GenerateRandomName();
            IgnoreGuids = new List<string>();
        }

        public static string GenerateRandomName()
        {
            // Build random 4 digits
            Random digits = new Random();
            string append = digits.Next(1000).ToString().PadLeft(4, '0');

            // Get random name
            List<string> Names = RandomNames();
            Random picker = new Random();
            int index = picker.Next(Names.Count - 1);

            return $"{Names[index]}:{append}";
        }

        private static List<string> RandomNames()
        {
            List<string> Names = new List<string>()
            {
                "Singing Parrot",
                "Tiny Leopard",
                "Blissful Bear",
                "Hungry Tiger",
                "Leaping Mantis",
                "Prancing Crow",
                "Swinging Owl",
                "Slow Sloth",
                "Electric Snake",
                "Prancing Horse",
                "Dancing Eel"
            };

            return Names;
        }
    }
}