using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Football_Team_Generator
{
    public class Team
    {
        private string name;
        private  List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
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

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            var player = players.FirstOrDefault(n => n.Name == name);
            if (player == null)
            {
                throw new InvalidOperationException($"Player {name} is not in {this.Name} team.");
            }
            players.Remove(player);
        }

        public int TeamRaiting()
        {
            var reiting = 0;

            foreach (var player in players)
            {
                reiting += player.GetSkillLevel;
            }

            if (reiting == 0)
            {
                return 0;
            }


            return reiting/ players.Count;
        }

        public int GetTeamRaiting => TeamRaiting();

    }
}
