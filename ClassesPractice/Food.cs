using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    internal enum FoodStyle
    {
        Southern = 0,
        Soul = 1,
        Asian = 2,
        TexMex = 3,
        British = 4,
        Western = 5,
        Fusion = 6,
    }

    internal class Food
    {
        
        private DateTime _timeStartedCooking;

        public Food(string name, string description, FoodStyle style, int cookTimeMinutes)
        {
            Name = name;
            Description = description;
            Style = style;
            CookTimeMinutes = cookTimeMinutes;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        //public Book Book { get; set; }
        public FoodStyle Style { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public int CookTimeMinutes { get; set; }
        public void StartCooking()
        {
            _timeStartedCooking = DateTime.Now;
            Console.WriteLine($"{Name} started cooking at {_timeStartedCooking} and will need to cook for {CookTimeMinutes} minutes.");
        }
        public void FinishCooking()
        {
            TimeSpan timeCooked = DateTime.Now - _timeStartedCooking;
            bool overDone = timeCooked.TotalSeconds > CookTimeMinutes;
            string response = overDone ? $"The {Name} is a burnt mess!" : $"You have just made the world's first perfect {Name}.";
            Console.WriteLine(response);
        }
    }
}
