using System;

namespace _05._Football_Team_Generator
{
    public class Player
    {
        private readonly int MinStatValue = 0;
        private readonly int MaxStatValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;


        public Player(string name,
            int endurance,
            int sprint,
            int dribble,
            int passing,
            int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;

        }


        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
           private set
            {
                ValidateStat(value, nameof(Endurance));
                this.endurance = value;
            }
        }


        public int Sprint
        {
            get => this.sprint;
          private  set
            {
                ValidateStat(value, nameof(Sprint));
                this.sprint = value;
            }

        }

        public int Dribble
        {
          private  get => this.dribble;
            set
            {
                ValidateStat(value,nameof(Dribble));
                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
          private  set
            {
                ValidateStat(value,nameof(Passing));
                this.passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
          private  set
            {
                ValidateStat(value,nameof(Shooting));
                this.shooting = value;
            }
        }

        public int GetSkillLevel
        {
            get => SkillLevel();
        }


        private void ValidateStat(int value, string statName)
        {
            if (value<= MinStatValue || value >= MaxStatValue)
            {
                throw new ArgumentException($"{statName} should be between {MinStatValue} and {MaxStatValue}.");
            }

        }

        private int SkillLevel()
        {
            double countOfPlayerSkill = 5.0;

           return (int) Math.Round((Endurance + Sprint + Dribble + Passing + Shooting )/ countOfPlayerSkill);
        }
    }
}
