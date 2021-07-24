using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Football_Team_Generator
{
    public class Program
    {
        static void Main()
        {
            var teams = new List<Team>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                if (line != null)
                {
                    string[] tokens = line.Split(";");

                    string command = tokens[0];
                    string teamName = tokens[1];
                    string playerName = String.Empty;

                    switch (command)
                    {
                        case "Team":
                            teams.Add(new Team(teamName));
                            break;

                        case "Add" when teams.Any(x =>x.Name == teamName):
                            playerName = tokens[2];
                            int endurance = int.Parse(tokens[3]);
                            int sprint= int.Parse(tokens[4]);
                            int dribble= int.Parse(tokens[5]);
                            int passing= int.Parse(tokens[6]);
                            int shooting= int.Parse(tokens[7]);

                            try
                            {
                                Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                                teams.First(n=>n.Name == teamName).AddPlayer(player);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                continue;
                                
                            }
                            break;

                        case "Remove" when teams.Any(x =>x.Name == teamName):
                            try
                            {
                                playerName = tokens[2];
                                teams.First(x => x.Name == teamName).RemovePlayer(playerName);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                continue;
                                
                            }
                            break;

                        case "Rating" when teams.Any(x =>x.Name == teamName):
                            Team team = teams.First(x => x.Name == teamName);
                            Console.WriteLine($"{teamName} - {team.GetTeamRaiting}");
                            break;

                        default:
                            Console.WriteLine($"Team {teamName} does not exist.");
                            break;
                        
                    }
                }
            }
        }
    }
}
