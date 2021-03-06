﻿namespace TexasHoldem.Tests.GameSimulations
{
    using System;
    using TexasHoldem.GameSimulations.GameSimulators;
    using TexasHoldem.Tests.GameSimulations.GameSimulators;

    public static class Program
    {
        public static void Main()
        {
            //SimulateGames(new BluffasaurusVsAllInPlayer());
            //SimulateGames(new BluffasaurusVsRandomPlayer());
            SimulateGames(new BluffasaurusVsSmartBot());
            SimulateGames(new SmartBotVsAllInPlayer());
        }

        private static void SimulateGames(IGameSimulator gameSimulator)
        {
            Console.WriteLine($"Running {gameSimulator.GetType().Name}...");

            var simulationResult = gameSimulator.Simulate(100);

            Console.WriteLine(simulationResult.SimulationDuration);
            Console.WriteLine($"Total games: {simulationResult.FirstPlayerWins:0,0} - {simulationResult.SecondPlayerWins:0,0}");
            Console.WriteLine($"Hands played: {simulationResult.HandsPlayed:0,0}");
            Console.WriteLine(new string('=', 75));
        }
    }
}
