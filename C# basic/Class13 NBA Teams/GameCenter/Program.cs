using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TeamSource.Enteties;
using TeamSource.Helpers;


namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();
            #region od cas
            ////Find all TEAMS with names starting with LA
            ////Find all team NAMES which are playing in "Staples Center"
            ////---------------------------------------------------------
            //var teamNamesPlayingInStaplesCenter = teams             //ili so ==            
            //                                .Where(team => team.Arena.Equals("Staples Center"))
            //                                .Select(team => team.Name)
            //                                .ToList();
            ////teamNamesPlayingInStaplesCenter.ForEach(teamName => Console.WriteLine(teamName));
            //Console.WriteLine("--------------------------------------------------------------");
            ////Find all teams coaches
            ////----------------------
            //var allCoaches = teams.Select(team => team.Coach)
            //                      .ToList();
            ////allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));
            //Console.WriteLine("--------------------------------------------------------------");
            ////Find 3 oldest coaches NAMES and AGE
            //var threeOldestcoachesNamesAndAge = allCoaches
            //                            .OrderByDescending(coach => coach.Age)
            //                            .Take(3)
            //                            .Select(coach => coach.FullName)
            //                            .ToList();
            ////threeOldestcoachesNamesAndAge.ForEach(trainerName => Console.WriteLine(trainerName));
            //Console.WriteLine("---------------------------------------------------------------");
            //Group all teams by their arenas
            //------------------------------------------------------------------
            //var groupTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();
            //foreach (var group in groupTeamsByArenas)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"-------------------------------{team.Name}");
            //    }
            //}
            //Console.WriteLine("-----------------------------------------------------------------");
            //Find all players
            //------------------------------
            //bez LINQ, sampo so using System.Collections.Generic bez using System.Linq;
            //var allPlayers = new List<Player>();
            //teams.ForEach(team => allPlayers.AddRange(team.Players));
            //allPlayers.ForEach(player => Console.WriteLine(player.FullName));
            //votr nacin so LINQ, pokomplicirano, so using System.Linq;
            //var allPlayers1 = teams.Select(team => team.Players).ToList();
            //foreach (var players in allPlayers1)
            //{
            //    foreach (var player in players)
            //    {
            //        Console.WriteLine(player.FullName);
            //    }
            //}
            //Console.WriteLine("-----------------------------------------------------------------");
            //Find player with best avgPtsPerGame
            //1-st choice
            //var playerWithMostPointsPerGame = allPlayers
            //                                .OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
            //                                .ToList().FirstOrDefault(); // isto bi bilo da indeksirame so 0 indeks [0], za prviot da go dade vo listat
            //Console.WriteLine(playerWithMostPointsPerGame.FullName);
            #endregion

            // HOMEWORK
            //++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Find all coaches NAMES with Age > 50
            //--------------------------------------
            var coachesOver50 = teams
                                .Where(team => team.Coach.Age > 50)
                                .Select(team => team.Coach.FullName)
                                .ToList();
            coachesOver50.ForEach(fullName => Console.WriteLine(fullName));
            Console.WriteLine("--->");
            var coachesOver50Querry = (from team in teams
                                       where team.Coach.Age > 50
                                       select team.Coach.FullName)
                                      .ToList();
            coachesOver50Querry.ForEach(fullName => Console.WriteLine(fullName));
            Console.WriteLine("-------------------------------------------------");
            // Order players by AGE - DESC
            //----------------------------
            var players = new List<Player>();
            teams.ForEach(team => players.AddRange(team.Players));

            var orderedPlayers = players
                                .OrderByDescending(player => player.Age)
                                .ToList();
            orderedPlayers.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("--->");
            var orderedPlayersQuerry = (from player in players
                                        orderby player.Age descending
                                        select player)
                                       .ToList();
            orderedPlayersQuerry.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("-------------------------------------------------");
            // Find player with highest RebPerGame
            //------------------------------------
            var playerWithHighesrRebPerGame = players
                                        .OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                        .FirstOrDefault();
            Console.WriteLine(playerWithHighesrRebPerGame.FullName);
            Console.WriteLine("--->");
            var playerWithHighesrRebPerGameQuerry = (from player in players
                                                     orderby player.PlayerStatistic["RebPerGame"] descending
                                                     select player)
                                                    .First();
            Console.WriteLine(playerWithHighesrRebPerGameQuerry.FullName);
            Console.WriteLine("-------------------------------------------------");
            // Find all players with PtsPerGame > 20
            //--------------------------------------
            var playersWithPtsPerGameHigher20 = players
                                                .Where(player => player.PlayerStatistic["PtsPerGame"] > 20)
                                                .Select(player => player)
                                                .ToList();
            playersWithPtsPerGameHigher20.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("--->");
            var playersWithPtsPerGameHigher20Querry = (from player in players
                                                       where player.PlayerStatistic["PtsPerGame"] > 20
                                                       select player)
                                                      .ToList();
            playersWithPtsPerGameHigher20Querry.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("--------------------------------------------------");
            // Find all players NAMES older then 30 years
            //-------------------------------------------
            var playersOlder30 = players
                                .Where(player => player.Age > 30)
                                .Select(player => player.FullName)
                                .ToList();
            playersOlder30.ForEach(fullName => Console.WriteLine(fullName));
            Console.WriteLine("--->");
            var playersOlder30Querry = (from player in players
                                        where player.Age > 30
                                        select player.FullName)
                                       .ToList();
            playersOlder30Querry.ForEach(fullName => Console.WriteLine(fullName));
            Console.WriteLine("---------------------------------------------------");
            // Group players by age
            //---------------------
            var groupedPlayersByAge = players
                                    .GroupBy(player => player.Age)
                                    .ToList();
            foreach (var pair in groupedPlayersByAge)
            {
                Console.WriteLine(pair.Key);
                foreach (var player in pair)
                {
                    Console.WriteLine($"------------{player.FullName}");
                }
            }
            Console.WriteLine("---------------------------------------------------");
            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
            //---------------------------------------------------------------
            var playersWithRebPerGameOver7 = players
                        .Where(player => player.PlayerStatistic["RebPerGame"] > 7.0f)
                        .Select(player => new { Name = player.FullName, Points = player.PlayerStatistic["PtsPerGame"] })
                        .ToList();
            playersWithRebPerGameOver7
                .ForEach(namePts => Console.WriteLine($"{namePts.Name}: {namePts.Points} Points per game."));
            Console.WriteLine("--->");
            var playersWithRebPerGameOver7Querry = (from player in players
                                                    where player.PlayerStatistic["RebPerGame"] > 7.0f
                                                    select new { Name = player.FullName, Points = player.PlayerStatistic["PtsPerGame"] })
                                                    .ToList();
            playersWithRebPerGameOver7Querry.ForEach(namePts => Console.WriteLine($"{namePts.Name}: {namePts.Points} Points per game."));
            Console.WriteLine("----------------------------------------------------");
            // Find first 3 players with highest PtsPerGame
            //---------------------------------------------
            var first3PlayersWithHighestPtsPerGame = players
                                        .OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                        .Take(3)
                                        .ToList();
            first3PlayersWithHighestPtsPerGame.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("--->");
            var first3PlayersWithHighestPtsPerGameQuerry = (from player in players
                                                            orderby player.PlayerStatistic["PtsPerGame"] descending
                                                            select player)
                                                            .Take(3)
                                                            .ToList();
            first3PlayersWithHighestPtsPerGameQuerry.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("-----------------------------------------------------");
            // Find the TEAM which has the player with highest PtsPerGame
            //-----------------------------------------------------------
            var playerWithHighestPtsPerGame = players
                                .OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                .FirstOrDefault();
            foreach (var team in teams)
            {
                foreach (var player in team.Players)
                {
                    if (player.PlayerStatistic["PtsPerGame"] == playerWithHighestPtsPerGame.PlayerStatistic["PtsPerGame"])
                    {
                        Console.WriteLine(team.Name);
                    }
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC  
            //---------------------------------------------------------------------------------
            var first4PlayersWithHighestRebPerGameOrderedAscByPtsPerGame = players
                                        .OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                        .Take(4)
                                        .OrderBy(player => player.PlayerStatistic["PtsPerGame"])
                                        .ToList();

            first4PlayersWithHighestRebPerGameOrderedAscByPtsPerGame.ForEach(player => Console.WriteLine(player.FullName));







            Console.ReadLine();
        }
    }
}
